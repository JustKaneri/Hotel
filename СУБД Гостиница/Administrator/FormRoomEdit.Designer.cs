namespace СУБД_Гостиница
{
    partial class FormRoomEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxNomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxCntPers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstPhoto = new System.Windows.Forms.ListView();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbxTitle = new System.Windows.Forms.Label();
            this.BtnSave = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.BtnCancel = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.BtnDelImage = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.BtnAddImage = new СУБД_Гостиница.Controls.ButtonSpecial();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CmbType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbxNomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbxPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbxCntPers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(17, 284);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(304, 32);
            this.CmbType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип номера";
            // 
            // TbxNomer
            // 
            this.TbxNomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxNomer.Location = new System.Drawing.Point(17, 67);
            this.TbxNomer.Name = "TbxNomer";
            this.TbxNomer.Size = new System.Drawing.Size(304, 30);
            this.TbxNomer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер:";
            // 
            // TbxPrice
            // 
            this.TbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPrice.Location = new System.Drawing.Point(17, 208);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.Size = new System.Drawing.Size(304, 30);
            this.TbxPrice.TabIndex = 3;
            this.TbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // TbxCntPers
            // 
            this.TbxCntPers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxCntPers.Location = new System.Drawing.Point(17, 139);
            this.TbxCntPers.MaxLength = 1;
            this.TbxCntPers.Name = "TbxCntPers";
            this.TbxCntPers.Size = new System.Drawing.Size(304, 30);
            this.TbxCntPers.TabIndex = 2;
            this.TbxCntPers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во человек:";
            // 
            // LstPhoto
            // 
            this.LstPhoto.HideSelection = false;
            this.LstPhoto.LargeImageList = this.ImgList;
            this.LstPhoto.Location = new System.Drawing.Point(365, 93);
            this.LstPhoto.Name = "LstPhoto";
            this.LstPhoto.Size = new System.Drawing.Size(764, 387);
            this.LstPhoto.TabIndex = 1;
            this.LstPhoto.UseCompatibleStateImageBehavior = false;
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList.ImageSize = new System.Drawing.Size(320, 179);
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel3.Controls.Add(this.LbxTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 82);
            this.panel3.TabIndex = 8;
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
            this.LbxTitle.Size = new System.Drawing.Size(1141, 82);
            this.LbxTitle.TabIndex = 0;
            this.LbxTitle.Text = "Редактирование номера";
            this.LbxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbxTitle.UseCompatibleTextRendering = true;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnSave.FlatAppearance.BorderSize = 2;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.Location = new System.Drawing.Point(975, 550);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(154, 49);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnCancel.FlatAppearance.BorderSize = 2;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(30, 551);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(154, 49);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnDelImage
            // 
            this.BtnDelImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnDelImage.FlatAppearance.BorderSize = 2;
            this.BtnDelImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelImage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelImage.Location = new System.Drawing.Point(540, 487);
            this.BtnDelImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDelImage.Name = "BtnDelImage";
            this.BtnDelImage.Size = new System.Drawing.Size(140, 38);
            this.BtnDelImage.TabIndex = 3;
            this.BtnDelImage.Text = "Удалить";
            this.BtnDelImage.UseVisualStyleBackColor = true;
            this.BtnDelImage.Click += new System.EventHandler(this.BtnDelImage_Click);
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BtnAddImage.FlatAppearance.BorderSize = 2;
            this.BtnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddImage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddImage.Location = new System.Drawing.Point(364, 486);
            this.BtnAddImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(156, 39);
            this.BtnAddImage.TabIndex = 3;
            this.BtnAddImage.Text = "Добавить";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // FormRoomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 611);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelImage);
            this.Controls.Add(this.BtnAddImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LstPhoto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoomEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.Load += new System.EventHandler(this.FormRoomEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxNomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxCntPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LstPhoto;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbxTitle;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label label5;
        private Controls.ButtonSpecial BtnAddImage;
        private Controls.ButtonSpecial BtnDelImage;
        private Controls.ButtonSpecial BtnCancel;
        private Controls.ButtonSpecial BtnSave;
    }
}