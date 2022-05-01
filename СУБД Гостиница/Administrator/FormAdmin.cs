using HotelAPI;
using HotelAPI.Autohrization;
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
        private MainManager Manager;
        
        public FormAdmin(MainManager manager)
        {
            InitializeComponent();
            Manager = manager;
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

        private async void ActivateForm(Form form)
        {
            PnlFragment.Controls.Clear();

            if (form == null)
            {
                return;
            }

            if (CurrentForm != null)
            {
                CurrentForm.Close();
                CurrentForm.Dispose();
                CurrentForm = null;
            }

            string conect = await Manager.GetConect();

            if (!conect.Equals("OK"))
            {
                form.Close();
                form.Dispose();
                form = null;
                form = new FormNotConect();
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

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            EnableButton(SelectBtn);
            ActivateButton((Button)(sender));
            ActivateForm(new FormPersonal(Manager));
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
