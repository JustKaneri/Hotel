namespace СУБД_Гостиница
{
    partial class FormTMP
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
            this.LbxStatus = new System.Windows.Forms.Label();
            this.LbxNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbxStatus);
            this.panel1.Controls.Add(this.LbxNumber);
            this.panel1.Location = new System.Drawing.Point(50, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 140);
            this.panel1.TabIndex = 0;
            // 
            // LbxStatus
            // 
            this.LbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbxStatus.Location = new System.Drawing.Point(20, 107);
            this.LbxStatus.Name = "LbxStatus";
            this.LbxStatus.Size = new System.Drawing.Size(161, 22);
            this.LbxStatus.TabIndex = 1;
            this.LbxStatus.Text = "label2";
            this.LbxStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbxNumber
            // 
            this.LbxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxNumber.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxNumber.Location = new System.Drawing.Point(0, 0);
            this.LbxNumber.Name = "LbxNumber";
            this.LbxNumber.Size = new System.Drawing.Size(211, 140);
            this.LbxNumber.TabIndex = 0;
            this.LbxNumber.Text = "label1";
            this.LbxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 473);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormTMP";
            this.Text = "FormTMP";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LbxStatus;
        public System.Windows.Forms.Label LbxNumber;
    }
}