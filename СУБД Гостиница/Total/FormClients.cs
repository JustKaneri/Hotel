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
            FillDgvClient();
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
            FormInfoClients formInfoClients = new FormInfoClients();
            formInfoClients.ShowDialog();
        }
    }
}
