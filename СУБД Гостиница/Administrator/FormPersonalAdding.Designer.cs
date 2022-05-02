namespace СУБД_Гостиница
{
    partial class FormPersonalAdding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalAdding));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.TbxPolic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.TbxOtch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCancel = new СУБД_Гостиница.Controls.ButtonSpecial();
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
            this.panel1.Size = new System.Drawing.Size(832, 88);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(655, 429);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(154, 49);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TbxPolic
            // 
            this.TbxPolic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPolic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPolic.Location = new System.Drawing.Point(528, 166);
            this.TbxPolic.MaxLength = 16;
            this.TbxPolic.Name = "TbxPolic";
            this.TbxPolic.Size = new System.Drawing.Size(281, 30);
            this.TbxPolic.TabIndex = 89;
            this.TbxPolic.Tag = "полис";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(425, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 88;
            this.label11.Text = "Полис:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "Имя:";
            // 
            // CmbxPost
            // 
            this.CmbxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxPost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbxPost.FormattingEnabled = true;
            this.CmbxPost.Location = new System.Drawing.Point(540, 291);
            this.CmbxPost.Name = "CmbxPost";
            this.CmbxPost.Size = new System.Drawing.Size(269, 32);
            this.CmbxPost.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(420, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 85;
            this.label12.Text = "Должность:";
            // 
            // TbxPass
            // 
            this.TbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPass.Location = new System.Drawing.Point(528, 250);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(281, 30);
            this.TbxPass.TabIndex = 84;
            this.TbxPass.Tag = "пароль";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(425, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 83;
            this.label10.Text = "Пароль:";
            // 
            // TbxLogin
            // 
            this.TbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLogin.Location = new System.Drawing.Point(528, 209);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(281, 30);
            this.TbxLogin.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(425, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 81;
            this.label9.Text = "Логин:";
            // 
            // DtmBorn
            // 
            this.DtmBorn.CalendarFont = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmBorn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmBorn.Location = new System.Drawing.Point(180, 336);
            this.DtmBorn.Name = "DtmBorn";
            this.DtmBorn.Size = new System.Drawing.Size(216, 30);
            this.DtmBorn.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 79;
            this.label8.Text = "Дата рождения";
            // 
            // TbxInn
            // 
            this.TbxInn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxInn.Location = new System.Drawing.Point(528, 121);
            this.TbxInn.MaxLength = 12;
            this.TbxInn.Name = "TbxInn";
            this.TbxInn.Size = new System.Drawing.Size(281, 30);
            this.TbxInn.TabIndex = 78;
            this.TbxInn.Tag = "ИНН";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(425, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "ИНН:";
            // 
            // TbxNomer
            // 
            this.TbxNomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxNomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNomer.Location = new System.Drawing.Point(180, 292);
            this.TbxNomer.MaxLength = 6;
            this.TbxNomer.Name = "TbxNomer";
            this.TbxNomer.Size = new System.Drawing.Size(216, 30);
            this.TbxNomer.TabIndex = 76;
            this.TbxNomer.Tag = "номер паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 75;
            this.label6.Text = "Номер паспорта:";
            // 
            // TbxSeria
            // 
            this.TbxSeria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxSeria.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxSeria.Location = new System.Drawing.Point(180, 248);
            this.TbxSeria.MaxLength = 4;
            this.TbxSeria.Name = "TbxSeria";
            this.TbxSeria.Size = new System.Drawing.Size(216, 30);
            this.TbxSeria.TabIndex = 74;
            this.TbxSeria.Tag = "серию паспорта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 24);
            this.label13.TabIndex = 73;
            this.label13.Text = "Серия паспорта:";
            // 
            // TbxOtch
            // 
            this.TbxOtch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxOtch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxOtch.Location = new System.Drawing.Point(115, 207);
            this.TbxOtch.Name = "TbxOtch";
            this.TbxOtch.Size = new System.Drawing.Size(281, 30);
            this.TbxOtch.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 71;
            this.label14.Text = "Отчество:";
            // 
            // TbxName
            // 
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(115, 166);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(281, 30);
            this.TbxName.TabIndex = 70;
            this.TbxName.Tag = "имя";
            // 
            // TbxFam
            // 
            this.TbxFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFam.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFam.Location = new System.Drawing.Point(115, 121);
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.Size = new System.Drawing.Size(281, 30);
            this.TbxFam.TabIndex = 69;
            this.TbxFam.Tag = "фамилию";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 24);
            this.label15.TabIndex = 68;
            this.label15.Text = "Фамилия:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnCancel.FlatAppearance.BorderSize = 2;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(17, 429);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(154, 49);
            this.BtnCancel.TabIndex = 90;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormPersonalAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 490);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TbxPolic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TbxOtch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.TbxFam);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersonalAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormPersonalAdding_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Controls.ButtonSpecial BtnAdd;
        private System.Windows.Forms.TextBox TbxPolic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbxOtch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.Label label15;
        private Controls.ButtonSpecial BtnCancel;
    }
}