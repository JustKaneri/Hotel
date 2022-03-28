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
        private CurrentUser User;
        private AlertsControllers controllers;

        public FormAlert(CurrentUser user)
        {
            InitializeComponent();
            User = user;
        }

        private async void FormAlert_Load(object sender, EventArgs e)
        {
            controllers = new AlertsControllers(User);
            List<Alert> alerts = await controllers.GetAlertsAsync();

            if(alerts == null)
            {
                throw new Exception("Сервер не доступен");
            }

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.Date , item.TextAlert);
            }
        }

        private void RbxRoom_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.Room);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.Date, item.TextAlert);
            }
        }

        private void RbxClient_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.Client);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.Date, item.TextAlert);
            }
        }

        private void RbxAll_CheckedChanged(object sender, EventArgs e)
        {
            List<Alert> alerts = controllers.SortAlert(AlertsControllers.TypeAlerts.All);

            DgvAlert.Rows.Clear();

            foreach (var item in alerts)
            {
                DgvAlert.Rows.Add(item.DateAlert.Date, item.TextAlert);
            }
        }
    }
}
