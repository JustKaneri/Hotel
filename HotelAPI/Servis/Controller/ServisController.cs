using HotelAPI.Autohrization;
using HotelAPI.Servis.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Servis.Controller
{
    public class ServisController
    {
        private CurrentUser User;

        private HttpClient Client;

        public ServisController(CurrentUser user)
        {
            User = user;
        }

        public async Task<List<ServisInfo>> GetServis()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Servis/GetServis";

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

            return JsonConvert.DeserializeObject<List<ServisInfo>>(result);
        }

        public async Task<string> AddServisInRegestry(int idReg, int idServ,int count)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Servis/ServisInRegestry?id_reg={idReg}&id_servis={idServ}&count={count}";

            HttpResponseMessage Message;

            try
            {

                Message = await Client.PostAsync(url,null);
            }
            catch
            {
                return "Not Conect";
            }

            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            return "OK";
        }
    }
}
