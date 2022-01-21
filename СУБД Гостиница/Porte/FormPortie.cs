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
    public partial class FormPortie : Form
    {
        public FormPortie()
        {
            InitializeComponent();
        }

        private Panel CursorSelectBtn;
        private Button SelectBtn;
        private Form CurrentForm;

        /// <summary>
        /// Изменений нажатой кнопки.
        /// </summary>
        /// <param name="CurrentBtn"></param>
        private void ActivateButton(Button CurrentBtn)
        {
            CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
            CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CursorSelectBtn.Location = CurrentBtn.Location;
            CurrentBtn.BackColor = Colors.ButtonMousEnter;
            SelectBtn = CurrentBtn;
            LbxTitle.Text = CurrentBtn.Text;
        }

        /// <summary>
        /// Снятие нажатия.
        /// </summary>
        /// <param name="CurrentBtn"></param>
        private void EnableButton(Button CurrentBtn)
        {
            if (CurrentBtn == null)
                return;

            CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CurrentBtn.BackColor = Colors.PanelColor;
           
        }

        private void ActivateForm(Form form)
        {
            if(form == null)
            {
                return;
            }

            if(CurrentForm != null)
            {
                CurrentForm.Close();
            }

            CurrentForm = form;
            CurrentForm.Show();
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.TopLevel = false;
            PnlFragment.Controls.Add(CurrentForm);
            CurrentForm.Dock = DockStyle.Fill;
        }

        private void FormPortie_Load(object sender, EventArgs e)
        {
            CursorSelectBtn = new Panel();
            CursorSelectBtn.Size = new Size(10,68);
            CursorSelectBtn.BackColor = Colors.ButtonForeSelect;
            this.Controls.Add(CursorSelectBtn);
            CursorSelectBtn.BringToFront();

            BtnNomer_Click(BtnNomer, null);
        }

        private void BtnNomer_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormRoomsPortie());

        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormClients());
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(null);
        }
    }
}
