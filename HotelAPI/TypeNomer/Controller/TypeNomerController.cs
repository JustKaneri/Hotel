using HotelAPI.Autohrization;
using HotelAPI.TypeNomer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.TypeNomer.Controller
{
    public  class TypeNomerController
    {
        private CurrentUser User;
        private HttpClient Client;

        public TypeNomerController(CurrentUser user)
        {
            User = user;
        }

        public async Task<List<TypeNomers>> GetTypeNomers()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/TypeNomer/GetType";

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

            string read = await Message.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<TypeNomers>>(read);
        }
    }
}
