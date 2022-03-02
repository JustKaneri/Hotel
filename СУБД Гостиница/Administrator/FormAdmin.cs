using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СУБД_Гостиница.Porte;

namespace СУБД_Гостиница.Administrator
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private Panel CursorSelectBtn;
        private Button SelectBtn;
        private Form CurrentForm;

        public bool IsShow { get; private set; }

        /// <summary>
        /// Изменений нажатой кнопки.
        /// </summary>
        /// <param name="CurrentBtn"></param>
        private void ActivateButton(Button CurrentBtn)
        {
            //CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CursorSelectBtn.Location = CurrentBtn.Location;
            //CurrentBtn.BackColor = Color.White;
            //CurrentBtn.ForeColor = Color.Black;
            SelectBtn = CurrentBtn;
            LbxTitle.Text = CurrentBtn.Tag.ToString();
        }

        /// <summary>
        /// Снятие нажатия.
        /// </summary>
        /// <param name="CurrentBtn"></param>
        private void EnableButton(Button CurrentBtn)
        {
            if (CurrentBtn == null)
                return;

            //CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            //CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            //CurrentBtn.BackColor = Colors.PanelColor;

        }

        private void ActivateForm(Form form)
        {
            if (form == null)
            {
                return;
            }

            if (CurrentForm != null)
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

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CursorSelectBtn = new Panel();
            CursorSelectBtn.Size = new Size(6, 68);
            CursorSelectBtn.BackColor = Colors.ButtonForeSelect;
            this.Controls.Add(CursorSelectBtn);
            CursorSelectBtn.BringToFront();

            HidePanel();

            BtnNomer_Click(BtnNomer, null);

        }

        private void BtnNomer_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormRooms("Admin"));
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
            ActivateForm(new FormAlert());
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormPersonal());
        }

        private void BtnStatic_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormStatistic());
        }

        private void HidePanel()
        {
            PnlMenu.Width = 80;

            foreach (Control item in PnlMenu.Controls)
            {
                if (item is Button)
                {
                    item.Tag = item.Text;
                    item.Text = "";
                    (item as Button).ImageAlign = ContentAlignment.MiddleCenter;
                }


            }
        }

        private void ShowPanel()
        {
            PnlMenu.Width = 200;

            foreach (Control item in PnlMenu.Controls)
            {
                if (item is Button)
                {
                    item.Text = item.Tag.ToString();
                    (item as Button).ImageAlign = ContentAlignment.MiddleLeft;
                }

            }

            BtnMenu.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (IsShow)
            {
                IsShow = false;
                HidePanel();
            }
            else
            {
                IsShow = true;
                ShowPanel();
            }
        }
    }
}
