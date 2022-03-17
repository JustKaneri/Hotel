namespace СУБД_Гостиница
{
    partial class FormPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            this.BtnFind = new System.Windows.Forms.Button();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.DgvPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFind
            // 
            this.BtnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.BtnFind.FlatAppearance.BorderSize = 2;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFind.Image = global::СУБД_Гостиница.Properties.Resources.MiniSearhB;
            this.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFind.Location = new System.Drawing.Point(534, 13);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(132, 48);
            this.BtnFind.TabIndex = 7;
            this.BtnFind.Text = "Поиск";
            this.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.MouseEnter += new System.EventHandler(this.BtnFind_MouseEnter);
            this.BtnFind.MouseLeave += new System.EventHandler(this.BtnFind_MouseLeave);
            // 
            // TbxFind
            // 
            this.TbxFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbxFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.TbxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFind.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFind.Location = new System.Drawing.Point(207, 23);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(322, 30);
            this.TbxFind.TabIndex = 5;
            // 
            // DgvPersonal
            // 
            this.DgvPersonal.AllowUserToAddRows = false;
            this.DgvPersonal.AllowUserToDeleteRows = false;
            this.DgvPersonal.AllowUserToResizeColumns = false;
            this.DgvPersonal.AllowUserToResizeRows = false;
            this.DgvPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonal.ColumnHeadersVisible = false;
            this.DgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvPersonal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.DgvPersonal.Location = new System.Drawing.Point(12, 68);
            this.DgvPersonal.Name = "DgvPersonal";
            this.DgvPersonal.ReadOnly = true;
            this.DgvPersonal.RowHeadersVisible = false;
            this.DgvPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DgvPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.DgvPersonal.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonal.RowTemplate.Height = 50;
            this.DgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersonal.Size = new System.Drawing.Size(776, 303);
            this.DgvPersonal.TabIndex = 6;
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
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(557, 377);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(232, 35);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Новый сотрудник";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BtnAdd.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.DgvPersonal);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.DataGridView DgvPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnAdd;
    }
}