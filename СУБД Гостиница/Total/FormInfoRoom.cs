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
    public partial class FormInfoRoom : Form
    {
        

        public FormInfoRoom(Room room)
        {
            InitializeComponent();

            TbxCountPerson.Text = room.CountPerson.ToString();
            TbxPrice.Text = room.Money.ToString();
            TbxStatus.Text = room.Status;
            TbxType.Text = room.TypeRoom;

            foreach (var item in room.Equpments)
            {
                LstEqupm.Items.Add(item.Name);
            }
        }

        private void FormInfoRoom_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
