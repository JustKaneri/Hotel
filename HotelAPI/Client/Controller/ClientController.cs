using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Autohrization;
using HotelAPI.Users.Model;
using Newtonsoft.Json;

namespace HotelAPI.Client.Controller
{
    public class ClientController
    {
        private CurrentUser User;
        private HttpClient Client;

        public ClientController(CurrentUser user)
        {
            User = user;
        }

        /// <summary>
        /// Получить список клиентов
        /// </summary>
        /// <returns></returns>
        public async Task<List<ClientHalfInfo>> GetClient()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Client/GetClients";

            HttpResponseMessage Message;

            try
            {

                Message = await Client.GetAsync(url);
            }
            catch
            {
                return null;
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return null;

            string result = await Message.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ClientHalfInfo>>(result);
        }
    }
}
