using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Controls
{
    class ButtonSpecial: Button
    {
        public ButtonSpecial()
        {
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(671, 276);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BtnLogIn";
            this.Size = new System.Drawing.Size(154, 49);
            this.TabIndex = 3;
            this.Text = "Вход";
            this.UseVisualStyleBackColor = true;
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Colors.BorderButton;
            this.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Colors.ButtonMousLeave;
            this.ForeColor = Colors.ButtonForeNoSelect;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Colors.ButtonMousEnter;
            this.ForeColor = Colors.ButtonForeSelect;
        }
    }
}
