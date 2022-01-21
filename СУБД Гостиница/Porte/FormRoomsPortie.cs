using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Porte
{
    public partial class FormRoomsPortie : Form
    {
        public FormRoomsPortie()
        {
            InitializeComponent();
        }

        private Color ColorReapair = Color.FromArgb(195,37,48);
        private Color ColorBusy = Color.FromArgb(53, 54, 82);

        private void FormRoomsPortie_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                DgvRooms.Rows.Add(200 + i * i, 
                                  200 + (i * i) + 1, 
                                  200 + (i * i) + 2, 
                                  200 + (i * i) + 3, 
                                  200 + (i * i) + 4);
            }
        }

        private void DgvRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //FormOformlen oformlen = new FormOformlen();
            //oformlen.ShowDialog();

            CntMenu.Show(Cursor.Position);
        }

        private void CntReg_MouseLeave(object sender, EventArgs e)
        {
            
            ((ToolStripMenuItem)(sender)).BackColor = Color.FromArgb(52, 52, 77);
            ((ToolStripMenuItem)(sender)).ForeColor = Colors.ButtonForeSelect;
        }

        private void CntReg_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)(sender)).BackColor = Colors.ButtonMousEnter;
            ((ToolStripMenuItem)(sender)).ForeColor = Color.Black;
        }

        private void CntReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DgvRooms.CurrentCell.Value.ToString());
         
        }
    }
}
