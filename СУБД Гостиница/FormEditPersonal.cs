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
    public partial class FormEditPersonal : Form
    {
        public FormEditPersonal()
        {
            InitializeComponent();
        }

        private void FormEditPersonal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Colors.ButtonMousEnter;
            (sender as Button).ForeColor = Colors.ButtonForeSelect;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Colors.ButtonMousLeave;
            (sender as Button).ForeColor = Colors.ButtonForeNoSelect;
        }

    }
}
