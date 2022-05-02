using HotelAPI;
using HotelAPI.Client.Controller;
using HotelAPI.Client.Model;
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
    public partial class FormInfoClients : Form
    {
        private MainManager Manager;
        private ClientController clientController;
        private int Id_Client;

        private ClientInfo Client;

        public FormInfoClients(MainManager manager, int id)
        {
            InitializeComponent();

            Manager = manager;

            Id_Client = id;

            clientController = Manager.GetClientController();
        }

        private async void FormInfoClients_Load(object sender, EventArgs e)
        {
            Client = await clientController.GetClientInfo(Id_Client);

            if (Client == null)
            {
                MessageBox.Show("Нет соединения с сервером", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FillData();

                for (int i = 0; i < Client.History.DateStart.Count; i++)
                {
                    DgvHistory.Rows.Add(Client.History.NameNomer[i], Client.History.DateStart[i].ToShortDateString(), Client.History.DateFinish[i].ToShortDateString());
                }
            }
            catch
            {
                return;
            }

            
        }

        private void FillData()
        {
            TbxFam.Text = Client.Fam;
            TbxName.Text = Client.Name;
            TbxOtch.Text = Client.Othc;
            TbxPasportN.Text = Client.PasportN;
            TbxPasportS.Text = Client.PasportS;
            TbxPhone.Text = Client.Phone;

        }

        private  void FormInfoClients_Shown(object sender, EventArgs e)
        {
            
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if(BtnEdit.Text == "Редактировать")
            {
                BtnEdit.Text = "Сохранить";
                BtnCancel.Visible = true;
                DeBlockTbx(true);
            }
            else
            {
                try
                {
                    CheckData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Client.Fam = TbxFam.Text;
                Client.Name= TbxName.Text;
                Client.Othc = TbxOtch.Text;
                Client.PasportN = TbxPasportN.Text ;
                Client.PasportS = TbxPasportS.Text;
                Client.Phone = TbxPhone.Text;

                string result = await clientController.UpdateClient(Client);

                if(result != "OK")
                {
                    MessageBox.Show("Не удалось сохранить", "Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    FillData();
                    BtnCancel_Click(null, null);
                }

                MessageBox.Show("Изменения успешно сохранены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckData()
        {
            if (string.IsNullOrWhiteSpace(TbxFam.Text))
                throw new Exception("Введите фамилию");

            if (string.IsNullOrWhiteSpace(TbxName.Text))
                throw new Exception("Введите имя");

            if (string.IsNullOrWhiteSpace(TbxPasportN.Text))
                throw new Exception("Введите номер паспорта");

            if (string.IsNullOrWhiteSpace(TbxPasportS.Text))
                throw new Exception("Введите серию паспорта");

            int tmp = 0;

            if (TbxPasportN.Text.Length < 6)
                throw new Exception("Не корректное значение номера паспорта");

            if (TbxPasportS.Text.Length < 4)
                throw new Exception("Не корректное значение серии паспорта");

            if (!int.TryParse(TbxPasportN.Text,out tmp))
                throw new Exception("Не корректное значение номера паспорта");

            if (!int.TryParse(TbxPasportS.Text, out tmp))
                throw new Exception("Не корректное значение серии паспорта");

            string phone = TbxPhone.Text;

            phone = phone.Replace(" ", "");

            if(phone.Length < 11)
                throw new Exception("Не корректный номер");
        }

        private void DeBlockTbx(bool status)
        {
            TbxFam.ReadOnly = !status;
            TbxName.ReadOnly = !status;
            TbxOtch.ReadOnly = !status;
            TbxPasportN.ReadOnly = !status;
            TbxPasportS.ReadOnly = !status;
            TbxPhone.Enabled = status;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FillData();
            BtnEdit.Text = "Редактировать";
            BtnCancel.Visible = false;
            DeBlockTbx(false);
        }
    }
}
