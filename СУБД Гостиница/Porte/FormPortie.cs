using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HotelAPI;

namespace СУБД_Гостиница.Porte
{
    public partial class FormPortie : Form
    {

        private MainManager Manager;

        public FormPortie(MainManager manager)
        {
            InitializeComponent();
            Manager = manager;
        }

        private Panel CursorSelectBtn;
        private Button SelectBtn;
        private Form CurrentForm;

        private Boolean IsShow = true;

        /// <summary>
        /// Изменений нажатой кнопки.
        /// </summary>
        /// <param name="CurrentBtn"></param>
        private void ActivateButton(Button CurrentBtn)
        {
            CursorSelectBtn.Location = CurrentBtn.Location;
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

        private void FormPortie_Load(object sender, EventArgs e)
        {
            CursorSelectBtn = new Panel();
            CursorSelectBtn.Size = new Size(6, 68);
            CursorSelectBtn.BackColor = Colors.ButtonForeSelect;
            this.Controls.Add(CursorSelectBtn);
            CursorSelectBtn.BringToFront();

            BtnNomer_Click(BtnNomer, null);
        }

        private void BtnNomer_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormRooms(Manager));

        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormClients(Manager));
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormAlert(Manager));
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

        private void HidePanel()
        {
            PnlMenu.Width = 80;

            foreach (Control item in PnlMenu.Controls)
            {
                if(item is Button)
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
                if(item is Button)
                {
                    item.Text = item.Tag.ToString();
                    (item as Button).ImageAlign = ContentAlignment.MiddleLeft;
                }
                
            }

            BtnMenu.ImageAlign = ContentAlignment.MiddleRight;
        }
    }
}
