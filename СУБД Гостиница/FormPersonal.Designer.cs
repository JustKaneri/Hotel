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
            this.TblPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TblPersonal
            // 
            this.TblPersonal.ColumnCount = 1;
            this.TblPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblPersonal.Location = new System.Drawing.Point(13, 13);
            this.TblPersonal.Name = "TblPersonal";
            this.TblPersonal.RowCount = 1;
            this.TblPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblPersonal.Size = new System.Drawing.Size(775, 399);
            this.TblPersonal.TabIndex = 0;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.TblPersonal);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Гостиница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPersonal;
    }
}