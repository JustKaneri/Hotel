using HotelAPI;
using HotelAPI.Rooms.Controller;
using HotelAPI.Rooms.Model;
using HotelAPI.TypeNomer.Controller;
using HotelAPI.TypeNomer.Model;
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
        private MainManager Manager;
        private RoomController roomController;
        private TypeNomerController typeNomerController;
        private Room roomInfo;
        private int Id_Room;
        private List<TypeNomers> typeNomers;

        public FormRoomEdit(MainManager manager,int id_room)
        {
            InitializeComponent();

            Manager = manager;

            roomController = Manager.GetRoomController();
            typeNomerController = Manager.GetTypeNomerController();
            Id_Room = id_room;
        }

        private async void FormRoomEdit_Load(object sender, EventArgs e)
        {
            roomInfo = await roomController.GetRoomInfoAsync(Id_Room);

            if(roomInfo == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            typeNomers = await typeNomerController.GetTypeNomers();

            if (typeNomers == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            TbxCntPers.Text = roomInfo.CountPerson.ToString();
            TbxNomer.Text = roomInfo.Name;
            TbxPrice.Text = roomInfo.Money.ToString();

            FillTypeNomer();

            CmbType.SelectedItem = roomInfo.TypeRoom;
        }

        private void FillTypeNomer()
        {
            for (int i = 0; i < typeNomers.Count; i++)
            {
                CmbType.Items.Add(typeNomers[i].Name);
            }
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


        private void BtnDelImage_Click(object sender, EventArgs e)
        {
            if (LstPhoto.SelectedItems.Count == 0)
                return;

            ImgList.Images.RemoveAt(LstPhoto.SelectedIndices[0]);
            LstPhoto.Items.Remove(LstPhoto.SelectedItems[0]);
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbxCntPers.Text) 
              || string.IsNullOrWhiteSpace(TbxNomer.Text) 
              || string.IsNullOrWhiteSpace(TbxPrice.Text))
            {
                MessageBox.Show("Заполните все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Price = int.Parse(TbxPrice.Text);

            if(Price == 0)
            {
                MessageBox.Show("Укажите цену", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CountPerson = int.Parse(TbxCntPers.Text);

            if(CountPerson == 0)
            {
                MessageBox.Show("Укажите кол-во человек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomInfo.Money = Price;
            roomInfo.Name = TbxNomer.Text;
            roomInfo.CountPerson = CountPerson;
            roomInfo.IdTypeRoom = typeNomers[CmbType.SelectedIndex].Id_Type;

            string res = await roomController.RoomEdit(roomInfo);

            if(!res.Equals("OK"))
            {
                MessageBox.Show("Не удалось сохранить изменения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Изменения сохранены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void TbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if ((Keys)e.KeyChar == Keys.Back)
                e.Handled = false;
        }
    }
}
