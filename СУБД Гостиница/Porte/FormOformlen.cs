using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Porte
{
    public partial class FormOformlen : Form
    {
        public FormOformlen()
        {
            InitializeComponent();
        }

        private void FormOformlen_Load(object sender, EventArgs e)
        {
            BtnReg.FlatAppearance.BorderColor = Colors.BorderButton;
        }

        private void BtnReg_MouseEnter(object sender, EventArgs e)
        {
            BtnReg.BackColor = Colors.ButtonMousEnter;
            BtnReg.ForeColor = Colors.ButtonForeSelect;
        }

        private void BtnReg_MouseLeave(object sender, EventArgs e)
        {
            BtnReg.BackColor = Colors.ButtonMousLeave;
            BtnReg.ForeColor = Colors.ButtonForeNoSelect;
        }

        private void CbxExsist_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxExsist.Checked)
                CmbxFam.DropDownStyle = ComboBoxStyle.DropDownList;
            else
                CmbxFam.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }
}
