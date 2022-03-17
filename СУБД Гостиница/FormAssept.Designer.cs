namespace СУБД_Гостиница
{
    partial class FormAssept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssept));
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAsseppt = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxPass
            // 
            this.TbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPass.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPass.Location = new System.Drawing.Point(57, 134);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(473, 38);
            this.TbxPass.TabIndex = 0;
            this.TbxPass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль для подтверждения";
            // 
            // BtnAsseppt
            // 
            this.BtnAsseppt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAsseppt.FlatAppearance.BorderSize = 2;
            this.BtnAsseppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsseppt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAsseppt.Location = new System.Drawing.Point(376, 195);
            this.BtnAsseppt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAsseppt.Name = "BtnAsseppt";
            this.BtnAsseppt.Size = new System.Drawing.Size(154, 49);
            this.BtnAsseppt.TabIndex = 4;
            this.BtnAsseppt.Text = "Подтвердить";
            this.BtnAsseppt.UseVisualStyleBackColor = true;
            this.BtnAsseppt.Click += new System.EventHandler(this.BtnAsseppt_Click);
            this.BtnAsseppt.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BtnAsseppt.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancel.FlatAppearance.BorderSize = 2;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(218, 195);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(154, 49);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.BtnCancel.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BtnCancel.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // FormAssept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 256);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAsseppt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbxPass);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAssept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Под";
            this.Load += new System.EventHandler(this.FormAssept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAsseppt;
        private System.Windows.Forms.Button BtnCancel;
    }
}