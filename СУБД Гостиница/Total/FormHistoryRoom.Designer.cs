namespace СУБД_Гостиница
{
    partial class FormHistoryRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoryRoom));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbxTitle = new System.Windows.Forms.Label();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOk = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.panel3.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(756, 82);
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
            this.LbxTitle.Size = new System.Drawing.Size(756, 82);
            this.LbxTitle.TabIndex = 0;
            this.LbxTitle.Text = "История: ";
            this.LbxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbxTitle.UseCompatibleTextRendering = true;
            // 
            // DgvHistory
            // 
            this.DgvHistory.AllowUserToAddRows = false;
            this.DgvHistory.AllowUserToDeleteRows = false;
            this.DgvHistory.AllowUserToResizeColumns = false;
            this.DgvHistory.AllowUserToResizeRows = false;
            this.DgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvHistory.Location = new System.Drawing.Point(12, 99);
            this.DgvHistory.MultiSelect = false;
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.ReadOnly = true;
            this.DgvHistory.RowHeadersVisible = false;
            this.DgvHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DgvHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.DgvHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.DgvHistory.RowTemplate.Height = 27;
            this.DgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHistory.Size = new System.Drawing.Size(732, 407);
            this.DgvHistory.TabIndex = 4;
            this.DgvHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistory_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 284.7716F;
            this.Column1.HeaderText = "Дата заселения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 0.7365992F;
            this.Column2.HeaderText = "Дата выезда";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 14.49183F;
            this.Column3.HeaderText = "ФИО проживавшего";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnOk.FlatAppearance.BorderSize = 2;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOk.Location = new System.Drawing.Point(601, 521);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(143, 33);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "ОК";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FormHistoryRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 566);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.DgvHistory);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHistoryRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormHistoryRoom_Load);
            this.Shown += new System.EventHandler(this.FormHistoryRoom_Shown);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbxTitle;
        private System.Windows.Forms.DataGridView DgvHistory;
        private Controls.ButtonSpecial BtnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}