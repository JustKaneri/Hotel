using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница
{
    public partial class FormRoomEdit : Form
    {
        public FormRoomEdit()
        {
            InitializeComponent();
        }
        

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImgList.Images.Add(Image.FromFile(openFileDialog1.FileName));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = ImgList.Images.Count-1;
                LstPhoto.Items.Add(item);
            }
        }

        private void FormRoomEdit_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelImage_Click(object sender, EventArgs e)
        {
            if (LstPhoto.SelectedItems.Count == 0)
                return;

            ImgList.Images.RemoveAt(LstPhoto.SelectedIndices[0]);
            LstPhoto.Items.Remove(LstPhoto.SelectedItems[0]);
            
        }
    }
}
