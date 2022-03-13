namespace СУБД_Гостиница
{
    partial class FormRemont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemont));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentYear = new System.Windows.Forms.Label();
            this.LbxLastMonth = new System.Windows.Forms.Label();
            this.LbxNextMonth = new System.Windows.Forms.Label();
            this.LbxMonthName = new System.Windows.Forms.Label();
            this.DgvCalendar = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRem = new System.Windows.Forms.Button();
            this.DtmFinish = new System.Windows.Forms.DateTimePicker();
            this.DtmStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 94);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1045, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ремонт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentYear
            // 
            this.CurrentYear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentYear.Location = new System.Drawing.Point(602, 104);
            this.CurrentYear.Name = "CurrentYear";
            this.CurrentYear.Size = new System.Drawing.Size(139, 23);
            this.CurrentYear.TabIndex = 30;
            this.CurrentYear.Text = "MonthName";
            this.CurrentYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbxLastMonth
            // 
            this.LbxLastMonth.AutoSize = true;
            this.LbxLastMonth.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxLastMonth.Location = new System.Drawing.Point(248, 100);
            this.LbxLastMonth.Name = "LbxLastMonth";
            this.LbxLastMonth.Size = new System.Drawing.Size(23, 24);
            this.LbxLastMonth.TabIndex = 29;
            this.LbxLastMonth.Text = "<";
            this.LbxLastMonth.Click += new System.EventHandler(this.LbxLastMonth_Click);
            // 
            // LbxNextMonth
            // 
            this.LbxNextMonth.AutoSize = true;
            this.LbxNextMonth.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxNextMonth.Location = new System.Drawing.Point(436, 99);
            this.LbxNextMonth.Name = "LbxNextMonth";
            this.LbxNextMonth.Size = new System.Drawing.Size(23, 24);
            this.LbxNextMonth.TabIndex = 28;
            this.LbxNextMonth.Text = ">";
            this.LbxNextMonth.Click += new System.EventHandler(this.LbxNextMonth_Click);
            // 
            // LbxMonthName
            // 
            this.LbxMonthName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxMonthName.Location = new System.Drawing.Point(286, 100);
            this.LbxMonthName.Name = "LbxMonthName";
            this.LbxMonthName.Size = new System.Drawing.Size(139, 23);
            this.LbxMonthName.TabIndex = 27;
            this.LbxMonthName.Text = "MonthName";
            this.LbxMonthName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvCalendar
            // 
            this.DgvCalendar.AllowUserToAddRows = false;
            this.DgvCalendar.AllowUserToDeleteRows = false;
            this.DgvCalendar.AllowUserToResizeColumns = false;
            this.DgvCalendar.AllowUserToResizeRows = false;
            this.DgvCalendar.BackgroundColor = System.Drawing.Color.White;
            this.DgvCalendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvCalendar.GridColor = System.Drawing.Color.White;
            this.DgvCalendar.Location = new System.Drawing.Point(12, 137);
            this.DgvCalendar.Name = "DgvCalendar";
            this.DgvCalendar.ReadOnly = true;
            this.DgvCalendar.RowHeadersVisible = false;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DgvCalendar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCalendar.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCalendar.RowTemplate.Height = 90;
            this.DgvCalendar.Size = new System.Drawing.Size(729, 478);
            this.DgvCalendar.TabIndex = 26;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Понедельник";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Вторник";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Среда";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Четверг";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Пятница";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Суббота";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Воскресенье";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // BtnRem
            // 
            this.BtnRem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRem.FlatAppearance.BorderSize = 2;
            this.BtnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRem.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRem.Location = new System.Drawing.Point(766, 296);
            this.BtnRem.Name = "BtnRem";
            this.BtnRem.Size = new System.Drawing.Size(248, 55);
            this.BtnRem.TabIndex = 37;
            this.BtnRem.Text = "Начать ремонт";
            this.BtnRem.UseVisualStyleBackColor = true;
            this.BtnRem.MouseEnter += new System.EventHandler(this.BtnRem_MouseEnter);
            this.BtnRem.MouseLeave += new System.EventHandler(this.BtnRem_MouseLeave);
            // 
            // DtmFinish
            // 
            this.DtmFinish.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DtmFinish.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmFinish.Location = new System.Drawing.Point(814, 239);
            this.DtmFinish.Name = "DtmFinish";
            this.DtmFinish.Size = new System.Drawing.Size(200, 30);
            this.DtmFinish.TabIndex = 36;
            // 
            // DtmStart
            // 
            this.DtmStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DtmStart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtmStart.Location = new System.Drawing.Point(814, 193);
            this.DtmStart.Name = "DtmStart";
            this.DtmStart.Size = new System.Drawing.Size(200, 30);
            this.DtmStart.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(762, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "По:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(762, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "С:";
            // 
            // TbxPrice
            // 
            this.TbxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPrice.Location = new System.Drawing.Point(829, 137);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.Size = new System.Drawing.Size(185, 30);
            this.TbxPrice.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(759, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Цена:";
            // 
            // FormRemont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 648);
            this.Controls.Add(this.BtnRem);
            this.Controls.Add(this.DtmFinish);
            this.Controls.Add(this.DtmStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentYear);
            this.Controls.Add(this.LbxLastMonth);
            this.Controls.Add(this.LbxNextMonth);
            this.Controls.Add(this.LbxMonthName);
            this.Controls.Add(this.DgvCalendar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRemont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormRemont_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentYear;
        private System.Windows.Forms.Label LbxLastMonth;
        private System.Windows.Forms.Label LbxNextMonth;
        private System.Windows.Forms.Label LbxMonthName;
        private System.Windows.Forms.DataGridView DgvCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button BtnRem;
        private System.Windows.Forms.DateTimePicker DtmFinish;
        private System.Windows.Forms.DateTimePicker DtmStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.Label label6;
    }
}