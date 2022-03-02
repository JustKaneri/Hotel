namespace СУБД_Гостиница.Porte
{
    partial class FormRooms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRooms));
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.LstEnvirmoment = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxCountPerson = new System.Windows.Forms.TextBox();
            this.TbxStatus = new System.Windows.Forms.TextBox();
            this.TbxType = new System.Windows.Forms.TextBox();
            this.TbxFloor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CntMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntReg = new System.Windows.Forms.ToolStripMenuItem();
            this.CntDeReg = new System.Windows.Forms.ToolStripMenuItem();
            this.CntHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.CntMenuAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CnmRegAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmDeRegAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmHistoryAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmRemont = new System.Windows.Forms.ToolStripMenuItem();
            this.TblRoom = new System.Windows.Forms.TableLayoutPanel();
            this.PnlInfo.SuspendLayout();
            this.CntMenu.SuspendLayout();
            this.CntMenuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlInfo
            // 
            this.PnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlInfo.Controls.Add(this.LstEnvirmoment);
            this.PnlInfo.Controls.Add(this.label5);
            this.PnlInfo.Controls.Add(this.TbxCountPerson);
            this.PnlInfo.Controls.Add(this.TbxStatus);
            this.PnlInfo.Controls.Add(this.TbxType);
            this.PnlInfo.Controls.Add(this.TbxFloor);
            this.PnlInfo.Controls.Add(this.label4);
            this.PnlInfo.Controls.Add(this.label3);
            this.PnlInfo.Controls.Add(this.label2);
            this.PnlInfo.Controls.Add(this.label1);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlInfo.Location = new System.Drawing.Point(883, 0);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Size = new System.Drawing.Size(266, 450);
            this.PnlInfo.TabIndex = 1;
            // 
            // LstEnvirmoment
            // 
            this.LstEnvirmoment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstEnvirmoment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstEnvirmoment.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LstEnvirmoment.FormattingEnabled = true;
            this.LstEnvirmoment.ItemHeight = 20;
            this.LstEnvirmoment.Location = new System.Drawing.Point(13, 265);
            this.LstEnvirmoment.Name = "LstEnvirmoment";
            this.LstEnvirmoment.Size = new System.Drawing.Size(241, 140);
            this.LstEnvirmoment.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "В номере есть:";
            // 
            // TbxCountPerson
            // 
            this.TbxCountPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxCountPerson.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCountPerson.Location = new System.Drawing.Point(10, 174);
            this.TbxCountPerson.Name = "TbxCountPerson";
            this.TbxCountPerson.ReadOnly = true;
            this.TbxCountPerson.Size = new System.Drawing.Size(244, 27);
            this.TbxCountPerson.TabIndex = 18;
            // 
            // TbxStatus
            // 
            this.TbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxStatus.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxStatus.Location = new System.Drawing.Point(81, 87);
            this.TbxStatus.Multiline = true;
            this.TbxStatus.Name = "TbxStatus";
            this.TbxStatus.ReadOnly = true;
            this.TbxStatus.Size = new System.Drawing.Size(170, 51);
            this.TbxStatus.TabIndex = 17;
            // 
            // TbxType
            // 
            this.TbxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxType.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxType.Location = new System.Drawing.Point(81, 52);
            this.TbxType.Name = "TbxType";
            this.TbxType.ReadOnly = true;
            this.TbxType.Size = new System.Drawing.Size(142, 27);
            this.TbxType.TabIndex = 16;
            // 
            // TbxFloor
            // 
            this.TbxFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFloor.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxFloor.Location = new System.Drawing.Point(81, 19);
            this.TbxFloor.Name = "TbxFloor";
            this.TbxFloor.ReadOnly = true;
            this.TbxFloor.Size = new System.Drawing.Size(142, 27);
            this.TbxFloor.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кол-во людей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Этаж:";
            // 
            // CntMenu
            // 
            this.CntMenu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntReg,
            this.CntDeReg,
            this.CntHistory});
            this.CntMenu.Name = "CntMenu";
            this.CntMenu.Size = new System.Drawing.Size(307, 88);
            this.CntMenu.Text = "Функции";
            // 
            // CntReg
            // 
            this.CntReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntReg.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntReg.Image = ((System.Drawing.Image)(resources.GetObject("CntReg.Image")));
            this.CntReg.Name = "CntReg";
            this.CntReg.Size = new System.Drawing.Size(306, 28);
            this.CntReg.Text = "Регистрация";
            this.CntReg.Click += new System.EventHandler(this.CntReg_Click);
            this.CntReg.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CntReg.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CntDeReg
            // 
            this.CntDeReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntDeReg.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntDeReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntDeReg.Image = ((System.Drawing.Image)(resources.GetObject("CntDeReg.Image")));
            this.CntDeReg.Name = "CntDeReg";
            this.CntDeReg.Size = new System.Drawing.Size(306, 28);
            this.CntDeReg.Text = "Снятие с регестрации";
            this.CntDeReg.Click += new System.EventHandler(this.CntDeReg_Click);
            this.CntDeReg.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CntDeReg.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CntHistory
            // 
            this.CntHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntHistory.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntHistory.Image = ((System.Drawing.Image)(resources.GetObject("CntHistory.Image")));
            this.CntHistory.Name = "CntHistory";
            this.CntHistory.Size = new System.Drawing.Size(306, 28);
            this.CntHistory.Text = "История";
            this.CntHistory.Click += new System.EventHandler(this.CntHistory_Click);
            this.CntHistory.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CntHistory.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CntMenuAdmin
            // 
            this.CntMenuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntMenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CnmRegAdm,
            this.CnmDeRegAdmin,
            this.CnmHistoryAdm,
            this.CnmRemont});
            this.CntMenuAdmin.Name = "CntMenuAdmin";
            this.CntMenuAdmin.Size = new System.Drawing.Size(307, 116);
            // 
            // CnmRegAdm
            // 
            this.CnmRegAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmRegAdm.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmRegAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmRegAdm.Image = ((System.Drawing.Image)(resources.GetObject("CnmRegAdm.Image")));
            this.CnmRegAdm.Name = "CnmRegAdm";
            this.CnmRegAdm.Size = new System.Drawing.Size(306, 28);
            this.CnmRegAdm.Text = "Регистрация";
            this.CnmRegAdm.Click += new System.EventHandler(this.CntReg_Click);
            this.CnmRegAdm.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CnmRegAdm.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CnmDeRegAdmin
            // 
            this.CnmDeRegAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmDeRegAdmin.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmDeRegAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmDeRegAdmin.Image = ((System.Drawing.Image)(resources.GetObject("CnmDeRegAdmin.Image")));
            this.CnmDeRegAdmin.Name = "CnmDeRegAdmin";
            this.CnmDeRegAdmin.Size = new System.Drawing.Size(306, 28);
            this.CnmDeRegAdmin.Text = "Снятие с регестрации";
            this.CnmDeRegAdmin.Click += new System.EventHandler(this.CntDeReg_Click);
            this.CnmDeRegAdmin.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CnmDeRegAdmin.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CnmHistoryAdm
            // 
            this.CnmHistoryAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmHistoryAdm.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmHistoryAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmHistoryAdm.Image = ((System.Drawing.Image)(resources.GetObject("CnmHistoryAdm.Image")));
            this.CnmHistoryAdm.Name = "CnmHistoryAdm";
            this.CnmHistoryAdm.Size = new System.Drawing.Size(306, 28);
            this.CnmHistoryAdm.Text = "История";
            this.CnmHistoryAdm.Click += new System.EventHandler(this.CntHistory_Click);
            this.CnmHistoryAdm.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CnmHistoryAdm.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // CnmRemont
            // 
            this.CnmRemont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmRemont.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmRemont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmRemont.Image = ((System.Drawing.Image)(resources.GetObject("CnmRemont.Image")));
            this.CnmRemont.Name = "CnmRemont";
            this.CnmRemont.Size = new System.Drawing.Size(306, 28);
            this.CnmRemont.Text = "Ремонт";
            this.CnmRemont.MouseEnter += new System.EventHandler(this.CntReg_MouseEnter);
            this.CnmRemont.MouseLeave += new System.EventHandler(this.CntReg_MouseLeave);
            // 
            // TblRoom
            // 
            this.TblRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TblRoom.ColumnCount = 5;
            this.TblRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.Location = new System.Drawing.Point(24, 0);
            this.TblRoom.Margin = new System.Windows.Forms.Padding(3, 3, 266, 3);
            this.TblRoom.Name = "TblRoom";
            this.TblRoom.RowCount = 5;
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.Size = new System.Drawing.Size(824, 438);
            this.TblRoom.TabIndex = 2;
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.TblRoom);
            this.Controls.Add(this.PnlInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Book Antiqua", 7.8F);
            this.Name = "FormRooms";
            this.Load += new System.EventHandler(this.FormRoomsPortie_Load);
            this.Shown += new System.EventHandler(this.FormRooms_Shown);
            this.PnlInfo.ResumeLayout(false);
            this.PnlInfo.PerformLayout();
            this.CntMenu.ResumeLayout(false);
            this.CntMenuAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.ListBox LstEnvirmoment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxCountPerson;
        private System.Windows.Forms.TextBox TbxStatus;
        private System.Windows.Forms.TextBox TbxType;
        private System.Windows.Forms.TextBox TbxFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CntMenu;
        private System.Windows.Forms.ToolStripMenuItem CntReg;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CntDeReg;
        private System.Windows.Forms.ToolStripMenuItem CntHistory;
        private System.Windows.Forms.ContextMenuStrip CntMenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem CnmRegAdm;
        private System.Windows.Forms.ToolStripMenuItem CnmDeRegAdmin;
        private System.Windows.Forms.ToolStripMenuItem CnmHistoryAdm;
        private System.Windows.Forms.ToolStripMenuItem CnmRemont;
        private System.Windows.Forms.TableLayoutPanel TblRoom;
    }
}