using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Controls
{
    class PanelRoom : Panel
    {
        public Label LbxStatus;
        public Label LbxNumber;

        public PanelRoom()
        {
            this.LbxNumber = new System.Windows.Forms.Label();
            this.LbxStatus = new System.Windows.Forms.Label();
            // 
            // panel1

            //this.Controls.Add(this.LbxStatus);
            this.Controls.Add(this.LbxNumber);
            this.Location = new System.Drawing.Point(50, 24);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(211, 140);
            this.TabIndex = 0;
            this.Dock = DockStyle.Fill;
            // 
            // LbxNumber
            // 
            this.LbxNumber.BorderStyle = BorderStyle.FixedSingle;
            this.LbxNumber.Dock = DockStyle.Fill;
            this.LbxNumber.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxNumber.Location = new System.Drawing.Point(0, 0);
            this.LbxNumber.Name = "LbxNumber";
            this.LbxNumber.Size = new System.Drawing.Size(287, 203);
            this.LbxNumber.TabIndex = 0;
            this.LbxNumber.Text = "label1";
            this.BackColor = Color.White;
            this.LbxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbxStatus
            // 
            this.LbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbxStatus.Location = new System.Drawing.Point(12, 172);
            this.LbxStatus.Name = "LbxStatus";
            this.LbxStatus.Size = new System.Drawing.Size(258, 22);
            this.LbxStatus.TabIndex = 1;
            this.LbxStatus.Text = "label2";
            this.LbxStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}
