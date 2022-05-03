using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotelAPI.Autohrization.Controller;
using HotelAPI.Autohrization;

using HotelAPI.Alerts;
using HotelAPI.Alerts.Controllers;
using System.Net.Http;
using HotelAPI.Rooms.Controller;
using HotelAPI.Regestry.Controler;
using HotelAPI.Client.Controller;
using HotelAPI.Servis.Controller;
using HotelAPI.TypeNomer.Controller;
using HotelAPI.PhotoNomer.Controller;
using HotelAPI.Personal.Controller;
using HotelAPI.Statistic.Contoller;

namespace HotelAPI
{
    public class MainManager
    {
        public CurrentUser User { get; set;}

        public StatisticController GetStatisticController()
        {
            return new StatisticController(User);
        }

        public Authorization GetAutohrization(string login, string password)
        {
            return new Authorization(login,password);
        }

        public PersonalController GetPersonalController()
        {
            return new PersonalController(User);
        }

        public PhotoNomerController GetPhotoNomerController()
        {
            return new PhotoNomerController(User);
        }

        public AlertsControllers GetAlertsControllers()
        {
            return new AlertsControllers(User);
        }

        public RoomController GetRoomController()
        {
            return new RoomController(User);
        }

        public RegestryController GetRegestryController()
        {
            return new RegestryController(User);
        }
        
        public ClientController GetClientController()
        {
            return new ClientController(User);
        }

        public ServisController GetServisController()
        {
            return new ServisController(User); 
        }

        public TypeNomerController GetTypeNomerController()
        {
            return new TypeNomerController(User);
        }

        public async Task<string> GetConect()
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(2);
            HttpResponseMessage message;

            try
            {
                message = await client.GetAsync(Properties.Resources.Url + "api/Conect/GetConect");
            }
            catch 
            {
                return "Not conect";
            }


            if (!message.StatusCode.ToString().Equals("OK"))
                return "Not conect";

            return "OK";
        }

        public async Task<string> PasswordVerification(string password)
        {
            HttpClient Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Authorization/PasswordVerification?password={password}";

            try
            {
                HttpResponseMessage httpResponse = await Client.GetAsync(url);

                string result = await httpResponse.Content.ReadAsStringAsync();

                if(!result.Contains("OK"))
                    return "Not Corect Password";
             

            }
            catch
            {
                return "Not Corect Password";
            }


            return "OK";
        }
    }
}
