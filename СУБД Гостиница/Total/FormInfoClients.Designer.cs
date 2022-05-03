namespace СУБД_Гостиница
{
    partial class FormInfoClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoClients));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbxTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxOtch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxPasportS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxPasportN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancel = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.BtnEdit = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel3.Controls.Add(this.LbxTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 81);
            this.panel3.TabIndex = 3;
            // 
            // LbxTitle
            // 
            this.LbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.LbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxTitle.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.LbxTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbxTitle.Location = new System.Drawing.Point(0, 0);
            this.LbxTitle.Name = "LbxTitle";
            this.LbxTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LbxTitle.Size = new System.Drawing.Size(712, 81);
            this.LbxTitle.TabIndex = 0;
            this.LbxTitle.Text = "Подробная информация";
            this.LbxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbxTitle.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // TbxFam
            // 
            this.TbxFam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFam.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFam.Location = new System.Drawing.Point(104, 41);
            this.TbxFam.Name = "TbxFam";
            this.TbxFam.ReadOnly = true;
            this.TbxFam.Size = new System.Drawing.Size(146, 27);
            this.TbxFam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(104, 80);
            this.TbxName.Name = "TbxName";
            this.TbxName.ReadOnly = true;
            this.TbxName.Size = new System.Drawing.Size(146, 27);
            this.TbxName.TabIndex = 2;
            // 
            // TbxOtch
            // 
            this.TbxOtch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxOtch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxOtch.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxOtch.Location = new System.Drawing.Point(104, 122);
            this.TbxOtch.Name = "TbxOtch";
            this.TbxOtch.ReadOnly = true;
            this.TbxOtch.Size = new System.Drawing.Size(147, 27);
            this.TbxOtch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // TbxPasportS
            // 
            this.TbxPasportS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxPasportS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPasportS.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPasportS.Location = new System.Drawing.Point(151, 196);
            this.TbxPasportS.MaxLength = 4;
            this.TbxPasportS.Name = "TbxPasportS";
            this.TbxPasportS.ReadOnly = true;
            this.TbxPasportS.Size = new System.Drawing.Size(100, 27);
            this.TbxPasportS.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Паспорт Серия";
            // 
            // TbxPasportN
            // 
            this.TbxPasportN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxPasportN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPasportN.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPasportN.Location = new System.Drawing.Point(151, 236);
            this.TbxPasportN.MaxLength = 6;
            this.TbxPasportN.Name = "TbxPasportN";
            this.TbxPasportN.ReadOnly = true;
            this.TbxPasportN.Size = new System.Drawing.Size(100, 27);
            this.TbxPasportN.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Паспорт Номер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbxPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbxPasportN);
            this.groupBox1.Controls.Add(this.TbxFam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxPasportS);
            this.groupBox1.Controls.Add(this.TbxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbxOtch);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(22, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 376);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // TbxPhone
            // 
            this.TbxPhone.Enabled = false;
            this.TbxPhone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPhone.Location = new System.Drawing.Point(90, 155);
            this.TbxPhone.Mask = "+7(999)999-99-99";
            this.TbxPhone.Name = "TbxPhone";
            this.TbxPhone.Size = new System.Drawing.Size(177, 30);
            this.TbxPhone.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Телефон";
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnCancel.FlatAppearance.BorderSize = 2;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(57, 334);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(160, 36);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnEdit.FlatAppearance.BorderSize = 2;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.Location = new System.Drawing.Point(57, 283);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(160, 36);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvHistory);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(320, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 407);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История проживания";
            // 
            // DgvHistory
            // 
            this.DgvHistory.AllowUserToAddRows = false;
            this.DgvHistory.AllowUserToDeleteRows = false;
            this.DgvHistory.AllowUserToResizeColumns = false;
            this.DgvHistory.AllowUserToResizeRows = false;
            this.DgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.ColumnHeadersVisible = false;
            this.DgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvHistory.Location = new System.Drawing.Point(22, 31);
            this.DgvHistory.MultiSelect = false;
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.ReadOnly = true;
            this.DgvHistory.RowHeadersVisible = false;
            this.DgvHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12.8F);
            this.DgvHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.DgvHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.DgvHistory.RowTemplate.Height = 80;
            this.DgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistory.Size = new System.Drawing.Size(352, 370);
            this.DgvHistory.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Дата заселения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Дата выезда";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormInfoClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(712, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfoClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormInfoClients_Load);
            this.Shown += new System.EventHandler(this.FormInfoClients_Shown);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxFam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxOtch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxPasportS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxPasportN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvHistory;
        private Controls.ButtonSpecial BtnCancel;
        private Controls.ButtonSpecial BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TbxPhone;
    }
}