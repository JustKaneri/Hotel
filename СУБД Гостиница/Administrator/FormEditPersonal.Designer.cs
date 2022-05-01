namespace СУБД_Гостиница
{
    partial class FormEditPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPersonal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.CmbxPost = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtmBorn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxInn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxNomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxSeria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxOtch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 94);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDel
            // 
            this.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnDel.FlatAppearance.BorderSize = 2;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDel.ForeColor = System.Drawing.Color.Red;
            this.BtnDel.Location = new System.Drawing.Point(16, 459);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(154, 49);
            this.BtnDel.TabIndex = 19;
            this.BtnDel.Text = "Уволить";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // CmbxPost
            // 
            this.CmbxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxPost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbxPost.FormattingEnabled = true;
            this.CmbxPost.Location = new System.Drawing.Point(540, 269);
            this.CmbxPost.Name = "CmbxPost";
            this.CmbxPost.Size = new System.Drawing.Size(269, 32);
            this.CmbxPost.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(420, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 24);
            this.label12.TabIndex = 63;
            this.label12.Text = "Должность";
            // 
            // TbxPass
            // 
            this.TbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPass.Location = new System.Drawing.Point(528, 228);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(281, 30);
            this.TbxPass.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(425, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 59;
            this.label10.Text = "Пароль";
            // 
            // TbxLogin
            // 
            this.TbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLogin.Location = new System.Drawing.Point(528, 187);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(281, 30);
            this.TbxLogin.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(425, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "Логин";
            // 
            // DtmBorn
            // 
            this.DtmBorn.CalendarFont = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmBorn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmBorn.Location = new System.Drawing.Point(180, 357);
            this.DtmBorn.Name = "DtmBorn";
            this.DtmBorn.Size = new System.Drawing.Size(216, 30);
            this.DtmBorn.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Дата рождения";
            // 
            // TbxInn
            // 
            this.TbxInn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxInn.Location = new System.Drawing.Point(528, 142);
            this.TbxInn.Name = "TbxInn";
            this.TbxInn.Size = new System.Drawing.Size(281, 30);
            this.TbxInn.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(425, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "ИНН:";
            // 
            // TbxNomer
            // 
            this.TbxNomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxNomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNomer.Location = new System.Drawing.Point(180, 313);
            this.TbxNomer.Name = "TbxNomer";
            this.TbxNomer.Size = new System.Drawing.Size(216, 30);
            this.TbxNomer.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Номер паспорта:";
            // 
            // TbxSeria
            // 
            this.TbxSeria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxSeria.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxSeria.Location = new System.Drawing.Point(180, 269);
            this.TbxSeria.Name = "TbxSeria";
            this.TbxSeria.Size = new System.Drawing.Size(216, 30);
            this.TbxSeria.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Серия паспорта:";
            // 
            // TbxOtch
            // 
            this.TbxOtch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxOtch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxOtch.Location = new System.Drawing.Point(115, 228);
            this.TbxOtch.Name = "TbxOtch";
            this.TbxOtch.Size = new System.Drawing.Size(281, 30);
            this.TbxOtch.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Отчество:";
            // 
            // TbxName
            // 
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(115, 187);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(281, 30);
            this.TbxName.TabIndex = 46;
            // 
            // TbxFam
            // 
            this.TbxFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFam.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFam.Location = new System.Drawing.Point(115, 142);
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.Size = new System.Drawing.Size(281, 30);
            this.TbxFam.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Имя:";
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnSave.FlatAppearance.BorderSize = 2;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.Location = new System.Drawing.Point(655, 459);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(154, 49);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // FormEditPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 520);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbxPost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TbxPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtmBorn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbxInn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbxNomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxSeria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxOtch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.TbxFam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormEditPersonal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.ComboBox CmbxPost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtmBorn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbxInn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxNomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxSeria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxOtch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.ButtonSpecial BtnSave;
    }
}