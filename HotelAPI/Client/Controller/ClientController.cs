using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Autohrization;
using HotelAPI.Client.Model;
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

        /// <summary>
        /// Получить подробную информацию о клиенте
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<ClientInfo> GetClientInfo(int Id)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Client/GetClientInfo?Id={Id}";

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

            return JsonConvert.DeserializeObject<ClientInfo>(result);
        }

        /// <summary>
        /// Редактирование клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public async Task<string> UpdateClient(ClientInfo client)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string json = JsonConvert.SerializeObject(client);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = Properties.Resources.Url + $"api/Client/UpdateClient?id={client.Id}";

            HttpResponseMessage Message;

            try
            {

                Message = await Client.PutAsync(url,content);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("NoContent"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return "OK";
        }

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public async Task<string> AddClient(ClientInfo client)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string json = JsonConvert.SerializeObject(client);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = Properties.Resources.Url + $"api/Client/UpdateClient?id={client.Id}";

            HttpResponseMessage Message;

            try
            {

                Message = await Client.PutAsync(url, content);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("NoContent"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return "OK";
        }
    }
}
