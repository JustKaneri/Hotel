using HotelAPI;
using HotelAPI.Regestry.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Total
{
    public partial class FormContinie : Form
    {
        private MainManager Manager;
        private RegestryController regestryController;
        private int Id_Room;

        public FormContinie(MainManager manager, int Id_Room)
        {
            InitializeComponent();

            Manager = manager;
            this.Id_Room = Id_Room;
        }

        private async void FormContinie_Load(object sender, EventArgs e)
        {
            regestryController = Manager.GetRegestryController();

            string res = await regestryController.GetFinsihDateRegestry(Id_Room);

            if(res.Equals("Not Conect"))
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            try
            {
                DtmFinish.MinDate = DateTime.Parse(res.Substring(1,res.IndexOf("T")-1));
            }
            catch
            {
                return;
            }
            
        }

        private void buttonSpecial2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnContinie_Click(object sender, EventArgs e)
        {
            var res = await regestryController.ExtendReg(Id_Room, DtmFinish.Value);

            if(res.Equals("Not Conect"))
            {
                MessageBox.Show("Не удалось продлить проживание", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            MessageBox.Show("Проживание успешно продлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
    }
}
