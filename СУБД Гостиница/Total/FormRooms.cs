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

        private void FormRoomsPortie_Load(object sender, EventArgs e)
        {
            roomController = Manager.GetRoomController();
        }

        private void DgvRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!Manager.User.RoleUser.Equals("Admin"))
                CntMenu.Show(Cursor.Position);
            else
                CntMenuAdmin.Show(Cursor.Position);
        }

        private void CntReg_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DgvRooms.CurrentCell.Value.ToString());
            FormOformlen oformlen = new FormOformlen();
            oformlen.ShowDialog();
        }

        private void CntHistory_Click(object sender, EventArgs e)
        {
            FormHistoryRoom formHistory = new FormHistoryRoom();
            formHistory.Show();
        }

        private void CntDeReg_Click(object sender, EventArgs e)
        {
            FormAssept formAssept = new FormAssept();
            if(formAssept.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private async void FormRooms_Shown(object sender, EventArgs e)
        {
            TblRoom.SuspendLayout();

            List<Room> rooms = await roomController.GetRooms();

            int rows = 0;
            int column = 0;

            foreach (var item in rooms)
            {
                if(column == 5)
                {
                    column = 0;
                    rows++;
                }

                PanelRoom panelRoom = new PanelRoom();
                panelRoom.LbxNumber.Text = item.Name + "\r\n" + item.Status;
                panelRoom.LbxNumber.Click += PanelRoom_Click;
                TblRoom.Controls.Add(panelRoom, column, rows);

                if (item.Status == "ремонт")
                    panelRoom.BackColor = Color.Yellow;

                if (item.Status == "занят")
                    panelRoom.BackColor = ColorBusy;

                column++;

            }

            TblRoom.ResumeLayout();
        }

        private void PanelRoom_Click(object sender, EventArgs e)
        {
            if (CurrentRoom != null)
            {
                CurrentRoom.BackColor = Color.White;
            }

            PanelRoom panel = (sender as Label).Parent as PanelRoom;

            if(panel.BackColor == Color.White)
            {
                CurrentRoom = (sender as Label).Parent as PanelRoom;
                CurrentRoom.BackColor = Colors.ColorSelectPanelRoom;
            }

            if (!Manager.User.RoleUser.Equals("Admin"))
                CntMenu.Show(Cursor.Position);
            else
                CntMenuAdmin.Show(Cursor.Position);
        }

        private void CntInfo_Click(object sender, EventArgs e)
        {
            FormInfoRoom infoRoom = new FormInfoRoom();
            infoRoom.ShowDialog();
        }

        private void CntEditRoom_Click(object sender, EventArgs e)
        {
            FormRoomEdit roomEdit = new FormRoomEdit();
            roomEdit.ShowDialog();
        }

        private void CnmRemont_Click(object sender, EventArgs e)
        {
            FormRemont remont = new FormRemont();
            remont.ShowDialog();
        }

        private void CnContinie_Click(object sender, EventArgs e)
        {
            FormContinie continie = new FormContinie();
            continie.ShowDialog();
        }
    }
}
