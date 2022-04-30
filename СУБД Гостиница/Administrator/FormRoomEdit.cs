using HotelAPI;
using HotelAPI.PhotoNomer.Controller;
using HotelAPI.PhotoNomer.Model;
using HotelAPI.Rooms.Controller;
using HotelAPI.Rooms.Model;
using HotelAPI.TypeNomer.Controller;
using HotelAPI.TypeNomer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace СУБД_Гостиница
{
    public partial class FormRoomEdit : Form
    {
        private MainManager Manager;
        private RoomController roomController;
        private TypeNomerController typeNomerController;
        private PhotoNomerController photoNomerController;
        private Room roomInfo;
        private int Id_Room;

        private List<PhotoNomers> photoNomers;
        private List<TypeNomers> typeNomers;

        public FormRoomEdit(MainManager manager,int id_room)
        {
            InitializeComponent();

            Manager = manager;

            roomController = Manager.GetRoomController();
            typeNomerController = Manager.GetTypeNomerController();
            photoNomerController = Manager.GetPhotoNomerController();
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

            photoNomers = await photoNomerController.GetPhotoNomers(Id_Room);

            FillImageList();
        }

        private void FillImageList()
        {
            ImgList.Images.Clear();
            LstPhoto.Items.Clear();

            foreach (var item in photoNomers)
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(item.PhotoPath);
                System.Net.WebResponse resp = request.GetResponse();
                Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();
                
                ImgList.Images.Add(bmp);
            }

            for (int i = 0; i < ImgList.Images.Count; i++)
            {
                LstPhoto.Items.Add((i + 1).ToString(), i);
            }
        }

        private void FillTypeNomer()
        {
            for (int i = 0; i < typeNomers.Count; i++)
            {
                CmbType.Items.Add(typeNomers[i].Name);
            }
        }

        private async void BtnAddImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image igm = null;

                try
                {
                    igm = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                }

                byte[] photo = new byte[0];

                using (var ms = new MemoryStream())
                {
                    igm.Save(ms, igm.RawFormat);
                    photo = ms.ToArray();
                }

                int res = await photoNomerController.AddPhoto(Id_Room, photo, Path.GetFileName(openFileDialog1.FileName));

                if(res == -1)
                {
                    MessageBox.Show("Не удалось добавить фото", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ImgList.Images.Add(igm);
                LstPhoto.Items.Add(ImgList.Images.Count.ToString(), ImgList.Images.Count - 1);
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
