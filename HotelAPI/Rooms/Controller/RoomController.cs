using HotelAPI.Autohrization;
using HotelAPI.Rooms.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Rooms.Controller
{
    public class RoomController
    {
        private CurrentUser User;

        public RoomController(CurrentUser user)
        {
            User = user;
        }

        public HttpClient Client { get; private set; }

        public async Task<List<Room>> GetRooms()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Rooms/GetRooms";

            HttpResponseMessage Message = await Client.GetAsync(url);

            if (!Message.StatusCode.ToString().Equals("OK"))
                return null;

            string result = await Message.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Room>>(result);
        }
    }
}
