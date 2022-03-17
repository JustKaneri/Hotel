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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
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
    }
}
