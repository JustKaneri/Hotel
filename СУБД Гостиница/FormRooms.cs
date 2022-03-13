using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СУБД_Гостиница.Controls;

namespace СУБД_Гостиница.Porte
{
    public partial class FormRooms : Form
    {
        public FormRooms(string typeUser)
        {
            InitializeComponent();

            TypeUser = typeUser;
        }

        private string TypeUser { get; set; }
        private Color ColorReapair = Color.FromArgb(195,37,48);
        private Color ColorBusy = Color.FromArgb(53, 54, 82);
        private PanelRoom CurrentRoom;

        private void FormRoomsPortie_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    DgvRooms.Rows.Add(200 + i * i,
            //                      200 + (i * i) + 1,
            //                      200 + (i * i) + 2,
            //                      200 + (i * i) + 3,
            //                      200 + (i * i) + 4);
            //}
        }

        private void DgvRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!TypeUser.Equals("Admin"))
                CntMenu.Show(Cursor.Position);
            else
                CntMenuAdmin.Show(Cursor.Position);
        }

        private void CntReg_MouseLeave(object sender, EventArgs e)
        {
            
            //((ToolStripMenuItem)(sender)).BackColor = Color.FromArgb(123, 190, 175);
            //((ToolStripMenuItem)(sender)).ForeColor = Colors.PanelColor;
        }

        private void CntReg_MouseEnter(object sender, EventArgs e)
        {
            //((ToolStripMenuItem)(sender)).BackColor = Color.FromArgb(52, 52, 77);
            //((ToolStripMenuItem)(sender)).ForeColor = Color.White;
        }

        private void CntReg_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DgvRooms.CurrentCell.Value.ToString());
            FormOformlen oformlen = new FormOformlen();
            oformlen.ShowDialog();
        }

        private void CntHistory_Click(object sender, EventArgs e)
        {
            FormHistoryRoom formHistory = new FormHistoryRoom();
            formHistory.Show();
        }

        private void CntDeReg_Click(object sender, EventArgs e)
        {
            FormAssept formAssept = new FormAssept();
            if(formAssept.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void FormRooms_Shown(object sender, EventArgs e)
        {
            TblRoom.SuspendLayout();

            int num = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PanelRoom panelRoom = new PanelRoom();
                    panelRoom.LbxNumber.Text = (num + 20).ToString();
                    panelRoom.LbxNumber.Click += PanelRoom_Click;
                    num++;
                    panelRoom.LbxStatus.Text = "Свободно";
                    TblRoom.Controls.Add(panelRoom, j, i);
                }
            }

            TblRoom.ResumeLayout();
        }

        private void PanelRoom_Click(object sender, EventArgs e)
        {
            if (CurrentRoom != null)
            {
                CurrentRoom.BackColor = Color.White;
            }

            CurrentRoom = (sender as Label).Parent as PanelRoom;
            CurrentRoom.BackColor = Colors.ColorSelectPanelRoom;

            if (!TypeUser.Equals("Admin"))
                CntMenu.Show(Cursor.Position);
            else
                CntMenuAdmin.Show(Cursor.Position);
        }

        private void CntInfo_Click(object sender, EventArgs e)
        {
            FormInfoRoom infoRoom = new FormInfoRoom();
            infoRoom.ShowDialog();
        }

        private void CntEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void CnmRemont_Click(object sender, EventArgs e)
        {
            FormRemont remont = new FormRemont();
            remont.ShowDialog();
        }
    }
}
