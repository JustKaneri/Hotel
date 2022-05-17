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
            this.CntMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CnmInfoReg = new System.Windows.Forms.ToolStripMenuItem();
            this.CntReg = new System.Windows.Forms.ToolStripMenuItem();
            this.CntDeReg = new System.Windows.Forms.ToolStripMenuItem();
            this.CnContinie = new System.Windows.Forms.ToolStripMenuItem();
            this.CntInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.CntHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.CntMenuAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CnmInfoRegAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmRegAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmDeRegAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.CntContinie = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmHistoryAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.CntInfoRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.CntEditRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.CnmRemont = new System.Windows.Forms.ToolStripMenuItem();
            this.TblRoom = new System.Windows.Forms.TableLayoutPanel();
            this.CntDeRemont = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnDeRemont = new System.Windows.Forms.ToolStripMenuItem();
            this.PbxLoad = new System.Windows.Forms.PictureBox();
            this.CntMenu.SuspendLayout();
            this.CntMenuAdmin.SuspendLayout();
            this.CntDeRemont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // CntMenu
            // 
            this.CntMenu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CnmInfoReg,
            this.CntReg,
            this.CntDeReg,
            this.CnContinie,
            this.CntInfo,
            this.CntHistory});
            this.CntMenu.Name = "CntMenu";
            this.CntMenu.Size = new System.Drawing.Size(377, 172);
            this.CntMenu.Text = "Функции";
            this.CntMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.CntMenuAdmin_Closing);
            // 
            // CnmInfoReg
            // 
            this.CnmInfoReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmInfoReg.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmInfoReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmInfoReg.Image = ((System.Drawing.Image)(resources.GetObject("CnmInfoReg.Image")));
            this.CnmInfoReg.Name = "CnmInfoReg";
            this.CnmInfoReg.Size = new System.Drawing.Size(376, 28);
            this.CnmInfoReg.Text = "Информация о проживании";
            this.CnmInfoReg.Visible = false;
            this.CnmInfoReg.Click += new System.EventHandler(this.CnmInfoRegAdmin_Click);
            // 
            // CntReg
            // 
            this.CntReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntReg.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntReg.Image = ((System.Drawing.Image)(resources.GetObject("CntReg.Image")));
            this.CntReg.Name = "CntReg";
            this.CntReg.Size = new System.Drawing.Size(376, 28);
            this.CntReg.Text = "Регистрация";
            this.CntReg.Click += new System.EventHandler(this.CntReg_Click);
            // 
            // CntDeReg
            // 
            this.CntDeReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntDeReg.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntDeReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntDeReg.Image = ((System.Drawing.Image)(resources.GetObject("CntDeReg.Image")));
            this.CntDeReg.Name = "CntDeReg";
            this.CntDeReg.Size = new System.Drawing.Size(376, 28);
            this.CntDeReg.Text = "Снятие с регистрации";
            this.CntDeReg.Click += new System.EventHandler(this.CntDeReg_Click);
            // 
            // CnContinie
            // 
            this.CnContinie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnContinie.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnContinie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnContinie.Image = ((System.Drawing.Image)(resources.GetObject("CnContinie.Image")));
            this.CnContinie.Name = "CnContinie";
            this.CnContinie.Size = new System.Drawing.Size(376, 28);
            this.CnContinie.Text = "Продлить";
            this.CnContinie.Click += new System.EventHandler(this.CnContinie_Click);
            // 
            // CntInfo
            // 
            this.CntInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntInfo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntInfo.Image = ((System.Drawing.Image)(resources.GetObject("CntInfo.Image")));
            this.CntInfo.Name = "CntInfo";
            this.CntInfo.Size = new System.Drawing.Size(376, 28);
            this.CntInfo.Text = "Информация";
            this.CntInfo.Click += new System.EventHandler(this.CntInfo_Click);
            // 
            // CntHistory
            // 
            this.CntHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntHistory.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntHistory.Image = ((System.Drawing.Image)(resources.GetObject("CntHistory.Image")));
            this.CntHistory.Name = "CntHistory";
            this.CntHistory.Size = new System.Drawing.Size(376, 28);
            this.CntHistory.Text = "История";
            this.CntHistory.Click += new System.EventHandler(this.CntHistory_Click);
            // 
            // CntMenuAdmin
            // 
            this.CntMenuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntMenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CnmInfoRegAdmin,
            this.CnmRegAdm,
            this.CnmDeRegAdmin,
            this.CntContinie,
            this.CnmHistoryAdm,
            this.CntInfoRoom,
            this.CntEditRoom,
            this.CnmRemont});
            this.CntMenuAdmin.Name = "CntMenuAdmin";
            this.CntMenuAdmin.Size = new System.Drawing.Size(377, 228);
            this.CntMenuAdmin.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.CntMenuAdmin_Closing);
            // 
            // CnmInfoRegAdmin
            // 
            this.CnmInfoRegAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmInfoRegAdmin.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmInfoRegAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmInfoRegAdmin.Image = ((System.Drawing.Image)(resources.GetObject("CnmInfoRegAdmin.Image")));
            this.CnmInfoRegAdmin.Name = "CnmInfoRegAdmin";
            this.CnmInfoRegAdmin.Size = new System.Drawing.Size(376, 28);
            this.CnmInfoRegAdmin.Text = "Информация о проживании";
            this.CnmInfoRegAdmin.Visible = false;
            this.CnmInfoRegAdmin.Click += new System.EventHandler(this.CnmInfoRegAdmin_Click);
            // 
            // CnmRegAdm
            // 
            this.CnmRegAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmRegAdm.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmRegAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmRegAdm.Image = ((System.Drawing.Image)(resources.GetObject("CnmRegAdm.Image")));
            this.CnmRegAdm.Name = "CnmRegAdm";
            this.CnmRegAdm.Size = new System.Drawing.Size(376, 28);
            this.CnmRegAdm.Text = "Регистрация";
            this.CnmRegAdm.Visible = false;
            this.CnmRegAdm.Click += new System.EventHandler(this.CntReg_Click);
            // 
            // CnmDeRegAdmin
            // 
            this.CnmDeRegAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmDeRegAdmin.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmDeRegAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmDeRegAdmin.Image = ((System.Drawing.Image)(resources.GetObject("CnmDeRegAdmin.Image")));
            this.CnmDeRegAdmin.Name = "CnmDeRegAdmin";
            this.CnmDeRegAdmin.Size = new System.Drawing.Size(376, 28);
            this.CnmDeRegAdmin.Text = "Снятие с регистрации";
            this.CnmDeRegAdmin.Visible = false;
            this.CnmDeRegAdmin.Click += new System.EventHandler(this.CntDeReg_Click);
            // 
            // CntContinie
            // 
            this.CntContinie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntContinie.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntContinie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntContinie.Image = ((System.Drawing.Image)(resources.GetObject("CntContinie.Image")));
            this.CntContinie.Name = "CntContinie";
            this.CntContinie.Size = new System.Drawing.Size(376, 28);
            this.CntContinie.Text = "Продлить";
            this.CntContinie.Visible = false;
            this.CntContinie.Click += new System.EventHandler(this.CnContinie_Click);
            // 
            // CnmHistoryAdm
            // 
            this.CnmHistoryAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmHistoryAdm.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmHistoryAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmHistoryAdm.Image = ((System.Drawing.Image)(resources.GetObject("CnmHistoryAdm.Image")));
            this.CnmHistoryAdm.Name = "CnmHistoryAdm";
            this.CnmHistoryAdm.Size = new System.Drawing.Size(376, 28);
            this.CnmHistoryAdm.Text = "История";
            this.CnmHistoryAdm.Click += new System.EventHandler(this.CntHistory_Click);
            // 
            // CntInfoRoom
            // 
            this.CntInfoRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntInfoRoom.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntInfoRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntInfoRoom.Image = ((System.Drawing.Image)(resources.GetObject("CntInfoRoom.Image")));
            this.CntInfoRoom.Name = "CntInfoRoom";
            this.CntInfoRoom.Size = new System.Drawing.Size(376, 28);
            this.CntInfoRoom.Text = "Информация";
            this.CntInfoRoom.Click += new System.EventHandler(this.CntInfo_Click);
            // 
            // CntEditRoom
            // 
            this.CntEditRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CntEditRoom.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntEditRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CntEditRoom.Image = ((System.Drawing.Image)(resources.GetObject("CntEditRoom.Image")));
            this.CntEditRoom.Name = "CntEditRoom";
            this.CntEditRoom.Size = new System.Drawing.Size(376, 28);
            this.CntEditRoom.Text = "Редактировать";
            this.CntEditRoom.Visible = false;
            this.CntEditRoom.Click += new System.EventHandler(this.CntEditRoom_Click);
            // 
            // CnmRemont
            // 
            this.CnmRemont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.CnmRemont.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnmRemont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.CnmRemont.Image = ((System.Drawing.Image)(resources.GetObject("CnmRemont.Image")));
            this.CnmRemont.Name = "CnmRemont";
            this.CnmRemont.Size = new System.Drawing.Size(376, 28);
            this.CnmRemont.Text = "Ремонт";
            this.CnmRemont.Visible = false;
            this.CnmRemont.Click += new System.EventHandler(this.CnmRemont_Click);
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
            this.TblRoom.Location = new System.Drawing.Point(24, 12);
            this.TblRoom.Margin = new System.Windows.Forms.Padding(3, 3, 266, 3);
            this.TblRoom.Name = "TblRoom";
            this.TblRoom.RowCount = 4;
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRoom.Size = new System.Drawing.Size(812, 426);
            this.TblRoom.TabIndex = 2;
            this.TblRoom.Visible = false;
            // 
            // CntDeRemont
            // 
            this.CntDeRemont.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntDeRemont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDeRemont});
            this.CntDeRemont.Name = "CntDeRemont";
            this.CntDeRemont.Size = new System.Drawing.Size(263, 32);
            // 
            // BtnDeRemont
            // 
            this.BtnDeRemont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.BtnDeRemont.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeRemont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnDeRemont.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeRemont.Image")));
            this.BtnDeRemont.Name = "BtnDeRemont";
            this.BtnDeRemont.Size = new System.Drawing.Size(262, 28);
            this.BtnDeRemont.Text = "Снятие с ремонта";
            this.BtnDeRemont.Click += new System.EventHandler(this.BtnDeRemont_Click);
            // 
            // PbxLoad
            // 
            this.PbxLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxLoad.Image = ((System.Drawing.Image)(resources.GetObject("PbxLoad.Image")));
            this.PbxLoad.Location = new System.Drawing.Point(-1, 0);
            this.PbxLoad.Name = "PbxLoad";
            this.PbxLoad.Size = new System.Drawing.Size(864, 452);
            this.PbxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLoad.TabIndex = 3;
            this.PbxLoad.TabStop = false;
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.PbxLoad);
            this.Controls.Add(this.TblRoom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Book Antiqua", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRooms";
            this.Text = "СУБД Гостинца";
            this.Load += new System.EventHandler(this.FormRoomsPortie_Load);
            this.CntMenu.ResumeLayout(false);
            this.CntMenuAdmin.ResumeLayout(false);
            this.CntDeRemont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem CntInfo;
        private System.Windows.Forms.ToolStripMenuItem CntInfoRoom;
        private System.Windows.Forms.ToolStripMenuItem CntEditRoom;
        private System.Windows.Forms.ToolStripMenuItem CnContinie;
        private System.Windows.Forms.ToolStripMenuItem CntContinie;
        private System.Windows.Forms.ContextMenuStrip CntDeRemont;
        private System.Windows.Forms.ToolStripMenuItem BtnDeRemont;
        private System.Windows.Forms.ToolStripMenuItem CnmInfoReg;
        private System.Windows.Forms.ToolStripMenuItem CnmInfoRegAdmin;
        private System.Windows.Forms.PictureBox PbxLoad;
    }
}