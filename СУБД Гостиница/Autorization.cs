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

namespace СУБД_Гостиница
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        public static void PaitBorderTextBox(TextBox tbx,Graphics g)
        {
            int SizeLine = 1;

            Pen penLine = new Pen(Colors.BorderTextBox, SizeLine);

            Point LeftAngel = new Point(tbx.Left, tbx.Top - SizeLine);
            Point LeftDownAngel = new Point(tbx.Left, tbx.Top + tbx.Height + SizeLine);
            Point RightUpAngel = new Point(tbx.Left + tbx.Width, tbx.Top - SizeLine);
            Point RightDownAngel = new Point(tbx.Left + tbx.Width, tbx.Top + tbx.Height + SizeLine);

            g.DrawLine(penLine, LeftAngel, RightUpAngel);
            g.DrawLine(penLine, LeftDownAngel, RightDownAngel);

            g.DrawArc(penLine,new Rectangle(LeftAngel.X-5,LeftAngel.Y,15,15), 270, -90);
            g.DrawArc(penLine, new Rectangle(LeftDownAngel.X - 5, LeftDownAngel.Y-15, 15, 15), 180, -90);
            g.DrawLine(penLine, LeftAngel.X - 5, LeftAngel.Y+5, LeftDownAngel.X - 5, LeftDownAngel.Y-5);

            g.DrawArc(penLine, new Rectangle(RightUpAngel.X - 6, RightUpAngel.Y, 15, 15), 0, -90);
            g.DrawArc(penLine, new Rectangle(RightDownAngel.X - 6, RightDownAngel.Y - 15, 15, 15), 0, 90);
            g.DrawLine(penLine, RightUpAngel.X + 9, RightUpAngel.Y + 5, RightDownAngel.X + 9, RightDownAngel.Y - 7);
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            BtnLogIn.FlatAppearance.BorderColor = Colors.BorderButton;
        }

        private void BtnLogIn_MouseEnter(object sender, EventArgs e)
        {
            BtnLogIn.BackColor = Colors.ButtonMousEnter;
            BtnLogIn.ForeColor = Colors.ButtonForeSelect;
        }

        private void BtnLogIn_MouseLeave(object sender, EventArgs e)
        {
            BtnLogIn.BackColor = Colors.ButtonMousLeave;
            BtnLogIn.ForeColor = Colors.ButtonForeNoSelect;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //FormPortie formPortie = new FormPortie();
            //formPortie.ShowDialog();

            FormAdmin admin = new FormAdmin();
            admin.ShowDialog();
        }
    }
}
