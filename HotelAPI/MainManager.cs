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

namespace HotelAPI
{
    public class MainManager
    {
        public CurrentUser User { get; set;}

        public Authorization GetAutohrization(string login, string password)
        {
            return new Authorization(login,password);
        }

        public AlertsControllers GetAlertsControllers()
        {
            return new AlertsControllers(User);
        }

        public RoomController GetRoomController()
        {
            return new RoomController(User);
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
    }
}
