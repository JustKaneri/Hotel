namespace СУБД_Гостиница
{
    partial class FormAlert
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
            this.DgvAlert = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GgFilter = new System.Windows.Forms.GroupBox();
            this.RbxClient = new System.Windows.Forms.RadioButton();
            this.RbxRoom = new System.Windows.Forms.RadioButton();
            this.RbxAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlert)).BeginInit();
            this.GgFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAlert
            // 
            this.DgvAlert.AllowUserToAddRows = false;
            this.DgvAlert.AllowUserToDeleteRows = false;
            this.DgvAlert.AllowUserToResizeColumns = false;
            this.DgvAlert.AllowUserToResizeRows = false;
            this.DgvAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAlert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvAlert.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DgvAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlert.ColumnHeadersVisible = false;
            this.DgvAlert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvAlert.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvAlert.Location = new System.Drawing.Point(33, 76);
            this.DgvAlert.MultiSelect = false;
            this.DgvAlert.Name = "DgvAlert";
            this.DgvAlert.ReadOnly = true;
            this.DgvAlert.RowHeadersVisible = false;
            this.DgvAlert.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12.8F);
            this.DgvAlert.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.DgvAlert.RowTemplate.Height = 80;
            this.DgvAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlert.Size = new System.Drawing.Size(839, 377);
            this.DgvAlert.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // GgFilter
            // 
            this.GgFilter.Controls.Add(this.RbxClient);
            this.GgFilter.Controls.Add(this.RbxRoom);
            this.GgFilter.Controls.Add(this.RbxAll);
            this.GgFilter.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GgFilter.Location = new System.Drawing.Point(33, 12);
            this.GgFilter.Name = "GgFilter";
            this.GgFilter.Size = new System.Drawing.Size(839, 58);
            this.GgFilter.TabIndex = 1;
            this.GgFilter.TabStop = false;
            this.GgFilter.Text = "Фильтрация";
            // 
            // RbxClient
            // 
            this.RbxClient.AutoSize = true;
            this.RbxClient.Location = new System.Drawing.Point(277, 24);
            this.RbxClient.Name = "RbxClient";
            this.RbxClient.Size = new System.Drawing.Size(115, 28);
            this.RbxClient.TabIndex = 2;
            this.RbxClient.Text = "Клиенты";
            this.RbxClient.UseVisualStyleBackColor = true;
            // 
            // RbxRoom
            // 
            this.RbxRoom.AutoSize = true;
            this.RbxRoom.Location = new System.Drawing.Point(127, 24);
            this.RbxRoom.Name = "RbxRoom";
            this.RbxRoom.Size = new System.Drawing.Size(103, 28);
            this.RbxRoom.TabIndex = 1;
            this.RbxRoom.Text = "Номера";
            this.RbxRoom.UseVisualStyleBackColor = true;
            // 
            // RbxAll
            // 
            this.RbxAll.AutoSize = true;
            this.RbxAll.Checked = true;
            this.RbxAll.Location = new System.Drawing.Point(6, 24);
            this.RbxAll.Name = "RbxAll";
            this.RbxAll.Size = new System.Drawing.Size(63, 28);
            this.RbxAll.TabIndex = 0;
            this.RbxAll.TabStop = true;
            this.RbxAll.Text = "Все";
            this.RbxAll.UseVisualStyleBackColor = true;
            // 
            // FormAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 465);
            this.Controls.Add(this.GgFilter);
            this.Controls.Add(this.DgvAlert);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormAlert";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlert)).EndInit();
            this.GgFilter.ResumeLayout(false);
            this.GgFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox GgFilter;
        private System.Windows.Forms.RadioButton RbxClient;
        private System.Windows.Forms.RadioButton RbxRoom;
        private System.Windows.Forms.RadioButton RbxAll;
    }
}