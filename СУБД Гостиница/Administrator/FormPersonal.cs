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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {

        }

        private void BtnFind_MouseEnter(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousEnter;
            BtnFind.ForeColor = Colors.ButtonForeSelect;
            BtnFind.Image = Properties.Resources.MiniSearhW;
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousLeave;
            BtnFind.ForeColor = Colors.ButtonForeNoSelect;
            BtnFind.Image = Properties.Resources.MiniSearhB;
        }

       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormPersonalAdding formPersonal = new FormPersonalAdding();
            formPersonal.ShowDialog();
        }
    }
}
