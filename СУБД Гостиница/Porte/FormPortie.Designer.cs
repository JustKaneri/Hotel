namespace СУБД_Гостиница.Porte
{
    partial class FormPortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortie));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnNomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbxLine = new System.Windows.Forms.PictureBox();
            this.LbxTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFragment = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.PnlMenu.Controls.Add(this.BtnMessage);
            this.PnlMenu.Controls.Add(this.BtnClients);
            this.PnlMenu.Controls.Add(this.BtnNomer);
            this.PnlMenu.Controls.Add(this.label2);
            this.PnlMenu.Controls.Add(this.BtnMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(194, 538);
            this.PnlMenu.TabIndex = 1;
            // 
            // BtnMessage
            // 
            this.BtnMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMessage.FlatAppearance.BorderSize = 0;
            this.BtnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMessage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnMessage.Image = global::СУБД_Гостиница.Properties.Resources.MiniMessag;
            this.BtnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMessage.Location = new System.Drawing.Point(0, 232);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnMessage.Size = new System.Drawing.Size(194, 68);
            this.BtnMessage.TabIndex = 3;
            this.BtnMessage.Tag = "Оповещения";
            this.BtnMessage.Text = "Оповещения";
            this.BtnMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMessage.UseVisualStyleBackColor = true;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnClients.Image = global::СУБД_Гостиница.Properties.Resources.MiniClients;
            this.BtnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClients.Location = new System.Drawing.Point(0, 164);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnClients.Size = new System.Drawing.Size(194, 68);
            this.BtnClients.TabIndex = 2;
            this.BtnClients.Tag = "Клиенты";
            this.BtnClients.Text = "Клиенты";
            this.BtnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnNomer
            // 
            this.BtnNomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNomer.FlatAppearance.BorderSize = 0;
            this.BtnNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNomer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnNomer.Image = global::СУБД_Гостиница.Properties.Resources.MiniRoom;
            this.BtnNomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNomer.Location = new System.Drawing.Point(0, 96);
            this.BtnNomer.Name = "BtnNomer";
            this.BtnNomer.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnNomer.Size = new System.Drawing.Size(194, 68);
            this.BtnNomer.TabIndex = 5;
            this.BtnNomer.Tag = "Номера";
            this.BtnNomer.Text = "Номера";
            this.BtnNomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNomer.UseVisualStyleBackColor = true;
            this.BtnNomer.Click += new System.EventHandler(this.BtnNomer_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(0, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "v 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnMenu.Size = new System.Drawing.Size(194, 96);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.Tag = "Меню";
            this.BtnMenu.Text = "Меню";
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.PbxLine);
            this.panel3.Controls.Add(this.LbxTitle);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 96);
            this.panel3.TabIndex = 2;
            // 
            // PbxLine
            // 
            this.PbxLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PbxLine.Image = ((System.Drawing.Image)(resources.GetObject("PbxLine.Image")));
            this.PbxLine.Location = new System.Drawing.Point(0, 78);
            this.PbxLine.Name = "PbxLine";
            this.PbxLine.Size = new System.Drawing.Size(857, 18);
            this.PbxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLine.TabIndex = 3;
            this.PbxLine.TabStop = false;
            // 
            // LbxTitle
            // 
            this.LbxTitle.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxTitle.Location = new System.Drawing.Point(15, 17);
            this.LbxTitle.Name = "LbxTitle";
            this.LbxTitle.Size = new System.Drawing.Size(438, 57);
            this.LbxTitle.TabIndex = 1;
            this.LbxTitle.Text = "label1";
            this.LbxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFragment
            // 
            this.PnlFragment.BackColor = System.Drawing.Color.White;
            this.PnlFragment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFragment.Location = new System.Drawing.Point(194, 96);
            this.PnlFragment.Name = "PnlFragment";
            this.PnlFragment.Size = new System.Drawing.Size(857, 442);
            this.PnlFragment.TabIndex = 3;
            // 
            // FormPortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1051, 538);
            this.Controls.Add(this.PnlFragment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1069, 585);
            this.Name = "FormPortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormPortie_Load);
            this.PnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Panel PnlFragment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbxTitle;
        private System.Windows.Forms.PictureBox PbxLine;
    }
}