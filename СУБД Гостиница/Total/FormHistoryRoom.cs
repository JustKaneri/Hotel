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

namespace СУБД_Гостиница
{
    public partial class FormHistoryRoom : Form
    {
        /// <summary>
        /// Написать о HTTP and API
        /// </summary>

        private MainManager Manager;
        private RoomController roomController;
        private int Id_Room;

        public FormHistoryRoom(MainManager manager,int id)
        {
            InitializeComponent();
            Manager = manager;
            Id_Room = id;

            roomController = manager.GetRoomController();
        }

        private void FormHistoryRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormHistoryRoom_Shown(object sender, EventArgs e)
        {
            string conect = await Manager.GetConect();

            if (!conect.Equals("OK"))
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            RoomHistory history = await roomController.GetHistoryRoom(Id_Room);

            if (history == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            for (int i = 0; i < history.DateStart.Count; i++)
            {
                DgvHistory.Rows.Add(history.DateStart[i].ToString("dd.MM.yyyy"), history.DateFinish[i].ToString("dd.MM.yyyy"), history.FIO[i]);
            }
        }
    }
}
