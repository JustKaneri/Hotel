namespace СУБД_Гостиница
{
    partial class FormClients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmxFind = new System.Windows.Forms.ComboBox();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnFind);
            this.panel1.Controls.Add(this.CmxFind);
            this.panel1.Controls.Add(this.TbxFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 132);
            this.panel1.TabIndex = 0;
            // 
            // CmxFind
            // 
            this.CmxFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CmxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmxFind.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmxFind.FormattingEnabled = true;
            this.CmxFind.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Этаж",
            "Номер",
            "Дата заселения"});
            this.CmxFind.Location = new System.Drawing.Point(346, 78);
            this.CmxFind.Name = "CmxFind";
            this.CmxFind.Size = new System.Drawing.Size(165, 32);
            this.CmxFind.TabIndex = 1;
            // 
            // TbxFind
            // 
            this.TbxFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TbxFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFind.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFind.Location = new System.Drawing.Point(280, 42);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(300, 30);
            this.TbxFind.TabIndex = 0;
            // 
            // DgvClients
            // 
            this.DgvClients.AllowUserToAddRows = false;
            this.DgvClients.AllowUserToDeleteRows = false;
            this.DgvClients.AllowUserToResizeColumns = false;
            this.DgvClients.AllowUserToResizeRows = false;
            this.DgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.ColumnHeadersVisible = false;
            this.DgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvClients.Location = new System.Drawing.Point(38, 147);
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.ReadOnly = true;
            this.DgvClients.RowHeadersVisible = false;
            this.DgvClients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.DgvClients.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClients.RowTemplate.Height = 50;
            this.DgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClients.Size = new System.Drawing.Size(816, 334);
            this.DgvClients.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // BtnFind
            // 
            this.BtnFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.BtnFind.FlatAppearance.BorderSize = 2;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFind.Image = global::СУБД_Гостиница.Properties.Resources.MiniSearhB;
            this.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFind.Location = new System.Drawing.Point(585, 32);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(132, 48);
            this.BtnFind.TabIndex = 4;
            this.BtnFind.Text = "Поиск";
            this.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.MouseEnter += new System.EventHandler(this.BtnFind_MouseEnter);
            this.BtnFind.MouseLeave += new System.EventHandler(this.BtnFind_MouseLeave);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.DgvClients);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmxFind;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.DataGridView DgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnFind;
    }
}