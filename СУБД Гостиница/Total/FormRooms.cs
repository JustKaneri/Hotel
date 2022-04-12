using HotelAPI;
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

using СУБД_Гостиница.Controls;
using СУБД_Гостиница.Total;

namespace СУБД_Гостиница.Porte
{
    public partial class FormRooms : Form
    {
        private MainManager Manager;

        public FormRooms(MainManager manager)
        {
            InitializeComponent();

            Manager = manager;
            
        }
        
        private Color ColorReapair = Color.FromArgb(195,37,48);
        private Color ColorBusy = Color.FromArgb(53, 54, 82);
        private PanelRoom CurrentRoom;
        private RoomController roomController;
        private List<Room> rooms;

        private async void FormRoomsPortie_Load(object sender, EventArgs e)
        {
            roomController = Manager.GetRoomController();

            TblRoom.SuspendLayout();

            TblRoom.Controls.Clear(); 

            rooms = await roomController.GetRooms();

            if(rooms == null)
            {
                Close();
                return;
            }

            FillTblRoom();
        }


        public void FillTblRoom()
        {
            int rows = 0;
            int column = 0;

            TblRoom.Controls.Clear();

            foreach (var item in rooms)
            {
                if (column == 5)
                {
                    column = 0;
                    rows++;
                }

                PanelRoom panelRoom = new PanelRoom();
                panelRoom.Tag = item.Id;
                panelRoom.LbxNumber.Text = item.Name + "\r\n" + item.Status;
                panelRoom.LbxNumber.Click += PanelRoom_Click;
                TblRoom.Controls.Add(panelRoom, column, rows);

                if (item.Status == "ремонт")
                    panelRoom.BackColor = Color.FromArgb(230, 178, 104);

                if (item.Status == "занят")
                    panelRoom.BackColor = Color.FromArgb(76, 112, 173);

                column++;

            }

            TblRoom.ResumeLayout();
        }

        private void CntReg_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DgvRooms.CurrentCell.Value.ToString());
            FormOformlen oformlen = new FormOformlen();
            oformlen.ShowDialog();
        }

        private void CntHistory_Click(object sender, EventArgs e)
        {
            FormHistoryRoom formHistory = new FormHistoryRoom(Manager,int.Parse(CurrentRoom.Tag.ToString()));
            formHistory.Show();
        }

        private void CntDeReg_Click(object sender, EventArgs e)
        {
            FormAssept formAssept = new FormAssept(Manager);
            if(formAssept.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void PanelRoom_Click(object sender, EventArgs e)
        {

            if (CurrentRoom != null)
            {
                if(CurrentRoom.LbxNumber.Text.Contains("свободен"))
                    CurrentRoom.BackColor = Color.White;
            }

            CurrentRoom = (sender as Label).Parent as PanelRoom;

            if(CurrentRoom.BackColor == Color.White)
            {
                CurrentRoom.BackColor = Colors.ColorSelectPanelRoom;
            }

            if (CurrentRoom.LbxNumber.Text.Contains("ремонт")) 
            {
                CntDeRemont.Show(Cursor.Position);
                return;
            }

            if(CurrentRoom.LbxNumber.Text.Contains("занят"))
            {
                CntDeReg.Visible = true;
                CnmDeRegAdmin.Visible = true;
                CnContinie.Visible = true;
                CntContinie.Visible = true;
            }
            else
            {
                CnmRemont.Visible = true;
                CntReg.Visible = true;
                CnmRegAdm.Visible = true;
                CntEditRoom.Visible = true;
            }

            if (!Manager.User.RoleUser.Equals("Admin"))
                CntMenu.Show(Cursor.Position);
            else
                CntMenuAdmin.Show(Cursor.Position);
        }

        private async void CntInfo_Click(object sender, EventArgs e)
        {
            Room room = await roomController.GetRoomInfoAsync(int.Parse(CurrentRoom.Tag.ToString()));

            FormInfoRoom infoRoom = new FormInfoRoom(room);
            infoRoom.ShowDialog();
        }

        private void CntEditRoom_Click(object sender, EventArgs e)
        {
            FormRoomEdit roomEdit = new FormRoomEdit();
            roomEdit.ShowDialog();
        }

        private async void CnmRemont_Click(object sender, EventArgs e)
        {
            FormRemont remont = new FormRemont(Manager, int.Parse(CurrentRoom.Tag.ToString()));
            if(remont.ShowDialog()== DialogResult.OK)
            {
                rooms = await roomController.GetRooms();

                FillTblRoom();
            }
        }

        private void CnContinie_Click(object sender, EventArgs e)
        {
            FormContinie continie = new FormContinie();
            continie.ShowDialog();
        }

        private async void BtnDeRemont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для снятия с ремонта, укажите пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FormAssept assept = new FormAssept(Manager);
            if(assept.ShowDialog() == DialogResult.OK)
            {
                roomController.DeRepair(int.Parse(CurrentRoom.Tag.ToString()));

                await Task.Delay(1000);

                rooms = await roomController.GetRooms();

                FillTblRoom();
            }
        }

        private void CntMenuAdmin_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            CntDeReg.Visible = false;
            CnmDeRegAdmin.Visible = false;
            CnContinie.Visible = false;
            CntContinie.Visible = false;
            CntEditRoom.Visible = false;
            CntReg.Visible = false;
            CnmRegAdm.Visible = false;
            CnmRemont.Visible = false;
        }
    }
}
