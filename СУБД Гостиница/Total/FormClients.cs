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

namespace СУБД_Гостиница
{
    public partial class FormClients : Form
    {
        private MainManager Manager;
        private ClientController clientController;
        private List<ClientHalfInfo> clients;

        public FormClients(MainManager manager)
        {
            InitializeComponent();
            Manager = manager;
            clientController = Manager.GetClientController();
        }

        private async void FormClients_Load(object sender, EventArgs e)
        {
            clients = await clientController.GetClient();
            if(clients == null)
            {
                return;
            }

            try
            {
                FillDgvClient();
                CmxFind.SelectedIndex = 0;
            }
            catch
            {
                return;
            }
        }

        private void FillDgvClient()
        {
            foreach (var item in clients)
            {
                string fio = item.Fam + " " + item.Name.Substring(0, 1) + "." + item.Othc.Substring(0, 1) + ".";
                string age = item.DateBorn == null ? "Неизвестен" :(DateTime.Now.Year - ((DateTime)item.DateBorn).Year).ToString();
                DgvClients.Rows.Add(fio,age);
            }
        }

        private void BtnFind_MouseEnter(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousEnter;
            BtnFind.ForeColor = Colors.ButtonForeSelect;
            BtnFind.Image = Properties.Resources.MiniSearhW;
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousLeave;
            BtnFind.ForeColor = Colors.ButtonForeNoSelect;
            BtnFind.Image = Properties.Resources.MiniSearhB;
        }

        private void DgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = clients[e.RowIndex].Id;
            FormInfoClients formInfoClients = new FormInfoClients(Manager,id);
            formInfoClients.ShowDialog();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int index = -1;

            switch (CmxFind.SelectedIndex)
            {
                case 0:
                    index = clients.IndexOf(clients.Where(cl => cl.Fam.ToLower().StartsWith(TbxFind.Text.ToLower())).FirstOrDefault());
                    break;
                case 1:
                    index = clients.IndexOf(clients.Where(cl => cl.Name.ToLower().StartsWith(TbxFind.Text.ToLower())).FirstOrDefault());
                    break;
                case 2:
                    index = clients.IndexOf(clients.Where(cl => cl.Othc.ToLower().StartsWith(TbxFind.Text.ToLower())).FirstOrDefault());
                    break;
            }

            if(index == -1)
            {
                MessageBox.Show("Клиент не найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DgvClients.CurrentCell = DgvClients.Rows[index].Cells[0];
            DgvClients.Rows[index].Selected = true;
        }
    }
}
