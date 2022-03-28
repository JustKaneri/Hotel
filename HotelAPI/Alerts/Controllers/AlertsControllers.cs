using HotelAPI.Alerts.Models;
using HotelAPI.Autohrization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HotelAPI.Alerts.Controllers
{
    public class AlertsControllers
    {
        public CurrentUser User { get; set; }

        private List<Alert> AlertArray;

        public EventHandler NewAlert;

        private HttpClient Client;

        public enum TypeAlerts
        {
            All,
            Room,
            Client
        }

        public AlertsControllers(CurrentUser user)
        {
            User = user;
        }

        /// <summary>
        /// Получить список оповещений
        /// </summary>
        /// <returns></returns>
        public async Task<List<Alert>> GetAlertsAsync()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Alerts/GetAlerts";

            HttpResponseMessage Message = await Client.GetAsync(url);

            if (!Message.StatusCode.ToString().Equals("OK"))
                return null;

            string result = await Message.Content.ReadAsStringAsync();

            AlertArray = JsonConvert.DeserializeObject<List<Alert>>(result);

            return AlertArray;
        }

        /// <summary>
        /// Сортировка 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Alert> SortAlert(TypeAlerts type)
        {
            List<Alert> alerts = new List<Alert>();

            switch (type)
            {
                case TypeAlerts.All:
                    alerts = AlertArray;
                    break;
                case TypeAlerts.Room:
                    alerts = AlertArray.Where(al => al.TypeAlert == "Room").ToList();
                    break;
                case TypeAlerts.Client:
                    alerts = AlertArray.Where(al => al.TypeAlert == "Client").ToList();
                    break;
            }

            return alerts;
        }

        /// <summary>
        /// Создание нового оповещения
        /// </summary>
        /// <param name="alert"></param>
        public async void CreateAlert(Alert alert)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Alerts/CreateAlerts";

            string Json = JsonConvert.SerializeObject(alert);

            StringContent stringContent = new StringContent(Json, Encoding.UTF8, "application/json");

            HttpResponseMessage message = await Client.PostAsync(url,stringContent);

            if (!message.StatusCode.ToString().Equals("OK"))
                throw new Exception("Нет соединения с сервером");
        }
    }
}
