using HotelAPI;
using HotelAPI.Alerts.Models;
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

namespace СУБД_Гостиница
{
    public partial class FormRemont : Form
    {
        private Calendar calendar;
        private MainManager Manager;
        private RoomController roomController;

        private int Id_Room;

        public DateTime GlDt { get; private set; }

        public FormRemont(MainManager manager,int Id)
        {
            InitializeComponent();
            Manager = manager;
            Id_Room = Id;
            roomController = manager.GetRoomController();
        }

        private async void FormRemont_Load(object sender, EventArgs e)
        {
            string conect = await Manager.GetConect();

            if (!conect.Equals("OK"))
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            DtmStart.MinDate = DateTime.Now.Date;

            RoomHistory history = await roomController.GetHistoryRoom(Id_Room);

            try
            {
                CurrentYear.Text = DateTime.Now.Year + " год";

                calendar = new Calendar(history.DateStart, history.DateFinish);
                FillCalendar(calendar.SetNowMont(), calendar.NameMonth);
            }
            catch
            {
                return;
            }
            
        }

        private void FillCalendar(List<Calendar.DayMonth> list, string name)
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

                DgvCalendar[list[i].NumWeek - 1, row].Value = list[i].Name;

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

        private void TbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (Keys.Back == (Keys)e.KeyChar)
                e.Handled = false;

            if (e.KeyChar == ',')
                e.Handled = false; 
        }

        private async void BtnRem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbxPrice.Text))
            {
                MessageBox.Show("Укажите стоймость ремонта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double tmp = 0;

            if(!double.TryParse(TbxPrice.Text,out tmp))
            {
                MessageBox.Show("Укажите коректную стоймость ремонта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(DateTime.Now.Date > DtmStart.Value.Date)
            {
                MessageBox.Show("Дата начала не может быть в прошлом времени", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Repair repair = new Repair();
            repair.IdRoom = Id_Room;
            repair.DateStart = DtmStart.Value;
            repair.Price = float.Parse(TbxPrice.Text);
            repair.DateFinish = null;

            string result = await roomController.Repair(Id_Room,repair);

            if(!result.Equals("OK"))
            {
                MessageBox.Show("Не удалось начать ремонт", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GlDt = DtmStart.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
