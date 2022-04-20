using HotelAPI;
using HotelAPI.Client.Controller;
using HotelAPI.Client.Model;
using HotelAPI.Regestry.Controler;
using HotelAPI.Rooms.Controller;
using HotelAPI.Rooms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СУБД_Гостиница.Total;

namespace СУБД_Гостиница.Porte
{
    public partial class FormOformlen : Form
    {
        private MainManager Manager;
        private int Id_Room;
        private RoomController roomController;
        private RegestryController regestryController;
        private ClientController clientController;
        private Calendar calendar;
        private Room room;


        public int Id_Reg { get; private set;}

        private bool IsEdit = false;
        private ClientInfo client;

        public FormOformlen(MainManager manager,int id)
        {
            InitializeComponent();
            Manager = manager;
            Id_Room = id;

            roomController = Manager.GetRoomController();
            regestryController = Manager.GetRegestryController();
            clientController = Manager.GetClientController();
        }


        private async void FormOformlen_Load(object sender, EventArgs e)
        {
            string conect = await Manager.GetConect();

            if (!conect.Equals("OK"))
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            RoomHistory history = await roomController.GetHistoryRoom(Id_Room);

            CurrentYear.Text = DateTime.Now.Year + " год";

            calendar = new Calendar(history.DateStart, history.DateFinish);
            FillCalendar(calendar.SetNowMont(), calendar.NameMonth);

            room = await roomController.GetRoomInfoAsync(Id_Room); 
        }

        private void FillCalendar(List<Calendar.DayMonth> list,string name)
        {
            LbxMonthName.Text = name;

            DgvCalendar.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                DgvCalendar.Rows.Add();
            }

            int row = 0;

            for (int i = 0; i < list.Count; i++)
            {

                DgvCalendar[list[i].NumWeek-1 , row].Value = list[i].Name;

                if (!list[i].IsFree)
                {
                    DgvCalendar[list[i].NumWeek - 1, row].Style.BackColor = Colors.ColorSelectPanelRoom;
                    DgvCalendar[list[i].NumWeek - 1, row].Style.SelectionBackColor = Colors.ColorSelectPanelRoom;
                }

                if (list[i].NumWeek == 7)
                {
                    row++;
                }

            }
        }

        private void LbxNextMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.NextMonth(), calendar.NameMonth);
        }

        private void LbxLastMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.PrevMonth(), calendar.NameMonth);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            FormSelectClient selectClient = new FormSelectClient(Manager);
            if(selectClient.ShowDialog() == DialogResult.OK)
            {
                GetSelectClient(selectClient.CurrentId);
            }
        }
        
        private async void GetSelectClient(int id)
        {
            client = await clientController.GetClientInfo(id);

            TbxFam.Text = client.Fam;
            TbxName.Text = client.Name;
            TbxOtch.Text = client.Othc;
            TbxNomer.Text = client.PasportN;
            TbxSeria.Text = client.PasportS;
            TbxPhone.Text = client.Phone;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            client = null;
            TbxFam.Clear();
            TbxName.Clear();
            TbxOtch.Clear();
            TbxPhone.Clear();
            TbxSeria.Clear();
            TbxNomer.Clear();
        }
    }
}
