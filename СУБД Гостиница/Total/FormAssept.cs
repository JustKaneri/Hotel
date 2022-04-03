using HotelAPI;
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
    public partial class FormAssept : Form
    {
        private MainManager Manager;

        public FormAssept(MainManager manager)
        {
            InitializeComponent();

            Manager = manager;
        }

        private void FormAssept_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnAsseppt_Click(object sender, EventArgs e)
        {

        }

        private async void BtnAsseppt_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbxPass.Text))
            {
                MessageBox.Show("Введите пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = await Manager.PasswordVerification(TbxPass.Text);

            if (result.Equals("OK"))
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Не верный пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
