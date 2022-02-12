namespace СУБД_Гостиница.Administrator
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnNomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbxTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlFragment = new System.Windows.Forms.Panel();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnStatic = new System.Windows.Forms.Button();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.BtnMessage);
            this.panel1.Controls.Add(this.BtnStatic);
            this.panel1.Controls.Add(this.BtnPersonal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnClients);
            this.panel1.Controls.Add(this.BtnNomer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 579);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(0, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "v 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnClients
            // 
            this.BtnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.BtnClients.Image = global::СУБД_Гостиница.Properties.Resources.MiniClients;
            this.BtnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClients.Location = new System.Drawing.Point(0, 134);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnClients.Size = new System.Drawing.Size(201, 68);
            this.BtnClients.TabIndex = 2;
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
            this.BtnNomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.BtnNomer.Image = global::СУБД_Гостиница.Properties.Resources.MiniRoom;
            this.BtnNomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNomer.Location = new System.Drawing.Point(0, 66);
            this.BtnNomer.Name = "BtnNomer";
            this.BtnNomer.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnNomer.Size = new System.Drawing.Size(201, 68);
            this.BtnNomer.TabIndex = 1;
            this.BtnNomer.Text = "Номера";
            this.BtnNomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNomer.UseVisualStyleBackColor = true;
            this.BtnNomer.Click += new System.EventHandler(this.BtnNomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 66);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(201, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гостиница";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.LbxTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(201, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 66);
            this.panel3.TabIndex = 3;
            // 
            // LbxTitle
            // 
            this.LbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.LbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxTitle.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.LbxTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbxTitle.Location = new System.Drawing.Point(0, 0);
            this.LbxTitle.Name = "LbxTitle";
            this.LbxTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LbxTitle.Size = new System.Drawing.Size(965, 66);
            this.LbxTitle.TabIndex = 0;
            this.LbxTitle.Text = "Текст";
            this.LbxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbxTitle.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 66);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(965, 66);
            this.label3.TabIndex = 0;
            this.label3.Text = "Текст";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // PnlFragment
            // 
            this.PnlFragment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFragment.Location = new System.Drawing.Point(201, 66);
            this.PnlFragment.Name = "PnlFragment";
            this.PnlFragment.Size = new System.Drawing.Size(965, 513);
            this.PnlFragment.TabIndex = 4;
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.BtnPersonal.Image = global::СУБД_Гостиница.Properties.Resources.MiniPersonal;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 202);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnPersonal.Size = new System.Drawing.Size(201, 68);
            this.BtnPersonal.TabIndex = 5;
            this.BtnPersonal.Text = "Персонал";
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnStatic
            // 
            this.BtnStatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStatic.FlatAppearance.BorderSize = 0;
            this.BtnStatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.BtnStatic.Image = global::СУБД_Гостиница.Properties.Resources.MiniStatistic;
            this.BtnStatic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatic.Location = new System.Drawing.Point(0, 270);
            this.BtnStatic.Name = "BtnStatic";
            this.BtnStatic.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnStatic.Size = new System.Drawing.Size(201, 68);
            this.BtnStatic.TabIndex = 6;
            this.BtnStatic.Text = "Статистика";
            this.BtnStatic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStatic.UseVisualStyleBackColor = true;
            this.BtnStatic.Click += new System.EventHandler(this.BtnStatic_Click);
            // 
            // BtnMessage
            // 
            this.BtnMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMessage.FlatAppearance.BorderSize = 0;
            this.BtnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMessage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.BtnMessage.Image = global::СУБД_Гостиница.Properties.Resources.MiniMessag;
            this.BtnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMessage.Location = new System.Drawing.Point(0, 338);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnMessage.Size = new System.Drawing.Size(201, 68);
            this.BtnMessage.TabIndex = 7;
            this.BtnMessage.Text = "Оповещения";
            this.BtnMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMessage.UseVisualStyleBackColor = true;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1166, 579);
            this.Controls.Add(this.PnlFragment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница (администратор)";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button BtnNomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbxTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.Button BtnStatic;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Panel PnlFragment;
    }
}