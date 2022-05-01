using HotelAPI;
using HotelAPI.Alerts.Controllers;
using HotelAPI.Alerts.Models;
using HotelAPI.Autohrization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace СУБД_Гостиница
{
    public partial class FormAlert : Form
    {
        private MainManager Manager;
        private AlertsControllers controllers;
        private List<Alert> alerts;

        public FormAlert(MainManager manager)
        {
            InitializeComponent();
            Manager = manager;
            controllers = Manager.GetAlertsControllers();
        }

        private  async void FormAlert_Load(object sender, EventArgs e)
        {
            alerts = await controllers.GetAlertsAsync();
            

            if (alerts == null)
            {
                throw new Exception("Сервер не доступен");
            }

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.ToShortDateString() , item.TextAlert);
            }
        }

        private void RbxRoom_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.Room);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.ToShortDateString(), item.TextAlert);
            }
        }

        private void RbxClient_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.Client);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.ToShortDateString(), item.TextAlert);
            }
        }

        private void RbxAll_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.All);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.ToShortDateString(), item.TextAlert);
            }
        }
    }
}
