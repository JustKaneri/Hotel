namespace СУБД_Гостиница
{
    partial class Autorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PbxUser = new System.Windows.Forms.PictureBox();
            this.PbxPass = new System.Windows.Forms.PictureBox();
            this.BtnLogIn = new СУБД_Гостиница.Controls.ButtonSpecial();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxLogin
            // 
            this.TbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLogin.Location = new System.Drawing.Point(495, 139);
            this.TbxLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(330, 30);
            this.TbxLogin.TabIndex = 1;
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPassword.Location = new System.Drawing.Point(495, 227);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(330, 30);
            this.TbxPassword.TabIndex = 2;
            this.TbxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(456, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(460, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(460, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // PbxUser
            // 
            this.PbxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxUser.Image = ((System.Drawing.Image)(resources.GetObject("PbxUser.Image")));
            this.PbxUser.Location = new System.Drawing.Point(459, 139);
            this.PbxUser.Name = "PbxUser";
            this.PbxUser.Size = new System.Drawing.Size(35, 30);
            this.PbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxUser.TabIndex = 8;
            this.PbxUser.TabStop = false;
            // 
            // PbxPass
            // 
            this.PbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPass.Image = ((System.Drawing.Image)(resources.GetObject("PbxPass.Image")));
            this.PbxPass.Location = new System.Drawing.Point(459, 227);
            this.PbxPass.Name = "PbxPass";
            this.PbxPass.Size = new System.Drawing.Size(35, 30);
            this.PbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPass.TabIndex = 9;
            this.PbxPass.TabStop = false;
            this.PbxPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxPass_MouseDown);
            this.PbxPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxPass_MouseUp);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnLogIn.FlatAppearance.BorderSize = 2;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogIn.Location = new System.Drawing.Point(671, 282);
            this.BtnLogIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(154, 49);
            this.BtnLogIn.TabIndex = 3;
            this.BtnLogIn.Text = "Вход";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_ClickAsync);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(863, 356);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.PbxPass);
            this.Controls.Add(this.PbxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxLogin);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbxUser;
        private System.Windows.Forms.PictureBox PbxPass;
        private Controls.ButtonSpecial BtnLogIn;
    }
}

