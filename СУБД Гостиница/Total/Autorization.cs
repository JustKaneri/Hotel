using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using СУБД_Гостиница.Administrator;
using СУБД_Гостиница.Porte;
using HotelAPI.Autohrization.Controller;
using HotelAPI.Autohrization;
using HotelAPI;

namespace СУБД_Гостиница
{
    public partial class Autorization : Form
    {
        private MainManager manager;

        public Autorization()
        {
            InitializeComponent();
        }

        public static void PaitBorderTextBox(TextBox tbx, Graphics g)
        {
            int SizeLine = 1;

            Pen penLine = new Pen(Colors.BorderTextBox, SizeLine);

            Point LeftAngel = new Point(tbx.Left, tbx.Top - SizeLine);
            Point LeftDownAngel = new Point(tbx.Left, tbx.Top + tbx.Height + SizeLine);
            Point RightUpAngel = new Point(tbx.Left + tbx.Width, tbx.Top - SizeLine);
            Point RightDownAngel = new Point(tbx.Left + tbx.Width, tbx.Top + tbx.Height + SizeLine);

            g.DrawLine(penLine, LeftAngel, RightUpAngel);
            g.DrawLine(penLine, LeftDownAngel, RightDownAngel);

            g.DrawArc(penLine, new Rectangle(LeftAngel.X - 5, LeftAngel.Y, 15, 15), 270, -90);
            g.DrawArc(penLine, new Rectangle(LeftDownAngel.X - 5, LeftDownAngel.Y - 15, 15, 15), 180, -90);
            g.DrawLine(penLine, LeftAngel.X - 5, LeftAngel.Y + 5, LeftDownAngel.X - 5, LeftDownAngel.Y - 5);

            g.DrawArc(penLine, new Rectangle(RightUpAngel.X - 6, RightUpAngel.Y, 15, 15), 0, -90);
            g.DrawArc(penLine, new Rectangle(RightDownAngel.X - 6, RightDownAngel.Y - 15, 15, 15), 0, 90);
            g.DrawLine(penLine, RightUpAngel.X + 9, RightUpAngel.Y + 5, RightDownAngel.X + 9, RightDownAngel.Y - 7);
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            manager = new MainManager();
        }

        private async void BtnLogIn_ClickAsync(object sender, EventArgs e)
        {
            BtnLogIn.Enabled = false;

            string conect = await manager.GetConect(); 
        
            if(!conect.Equals("OK"))
            {
                BtnLogIn.Enabled = true;
                MessageBox.Show("Не соединения с сервером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }

            Authorization authorization = manager.GetAutohrization(TbxLogin.Text, TbxPassword.Text);

            CurrentUser user = null;

            try
            {
                user = await authorization.LogIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BtnLogIn.Enabled = true;
                return;
            }

            manager.User = user;

            this.Hide();

            if(user.RoleUser == "Admin")
            {
                FormAdmin admin = new FormAdmin(manager);
                admin.ShowDialog();
            }
            else if(user.RoleUser == "Porte")
            {
                FormPortie formPortie = new FormPortie(manager);
                formPortie.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав для авторизации, обратитесь к администратору", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Show();
            TbxLogin.Text = "";
            TbxPassword.Text = "";
            BtnLogIn.Enabled = true;

        }

        private void PbxPass_MouseDown(object sender, MouseEventArgs e)
        {
            TbxPassword.UseSystemPasswordChar = false;
        }

        private void PbxPass_MouseUp(object sender, MouseEventArgs e)
        {
            TbxPassword.UseSystemPasswordChar = true;
        }
    }
}
