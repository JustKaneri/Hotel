using HotelAPI;
using HotelAPI.Client.Controller;
using HotelAPI.Users.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Total
{
    public partial class FormSelectClient : Form
    {
        private MainManager Manager;
        private ClientController clientController;
        private List<ClientHalfInfo> clients;

        public int CurrentId { get; private set; } = -1;

        public FormSelectClient(MainManager manager)
        {
            InitializeComponent();

            Manager = manager;
            clientController = Manager.GetClientController();
        }

        private async void FormSelectClient_Load(object sender, EventArgs e)
        {
            clients = await clientController.GetClient();
            if (clients == null)
            {
                Close();
                return;
            }
            FillDgvClient();
        }

        private void FillDgvClient()
        {
            foreach (var item in clients)
            {
                string fio = item.Fam + " " + item.Name + " " + item.Othc;
                LstClients.Items.Add(fio);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindClient(object sender, EventArgs e)
        {
            try
            {
                ClientHalfInfo client = clients.Where(cl => cl.Fam.StartsWith(TbxFam.Text))
                                               .Where(cl => cl.Name.StartsWith(TbxName.Text))
                                               .Where(cl => cl.Othc.StartsWith(TbxOtch.Text))
                                               .First();

                if(client == null)
                {
                    CurrentId = -1;
                    MessageBox.Show("Клиент с таким ФИО не найден в базе данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CurrentId = client.Id;

                LstClients.SelectedIndex = clients.IndexOf(client);
            }
            catch
            {
                
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CurrentId = -1;
            LstClients.SelectedIndex = -1;
            TbxFam.Clear();
            TbxName.Clear();
            TbxOtch.Clear();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(LstClients.SelectedIndex != -1)
            {
                CurrentId = clients[LstClients.SelectedIndex].Id;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Выберите клиента","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
