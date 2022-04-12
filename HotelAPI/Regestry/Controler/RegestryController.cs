using HotelAPI.Autohrization;
using HotelAPI.Regestry.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Regestry.Controler
{
    public class RegestryController
    {
        private HttpClient Client;
        private CurrentUser User;

        public RegestryController(CurrentUser user)
        {
            User = user;
        }

        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="reg"></param>
        /// <returns></returns>
        public async Task<string> Registration(Regestration reg)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Regestration/Reg";
            
            string Json = JsonConvert.SerializeObject(reg);

            StringContent content = new StringContent(Json, Encoding.UTF8, "application/json");

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PostAsync(url, content);
            }
            catch
            {
                return "error";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return "error";

            string result = await Message.Content.ReadAsStringAsync();

            reg = JsonConvert.DeserializeObject<Regestration>(result);

            return reg.ToString();
        }

        /// <summary>
        /// Продление проживания.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<string> ExtendReg(int Id,DateTime date)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/ContinieReg?id={Id}&DateFinish={date}";

            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await Client.PutAsync(url, null);
            }
            catch
            {
                return "Not Conect";
            }

            if (!httpResponse.StatusCode.ToString().Equals("OK"))
                return "Not Connect";


            return "OK";
        }

        /// <summary>
        /// Cнятие с регистрации
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<string> DeRegistration(int Id)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/DeReg?id={Id}";

            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await Client.PutAsync(url, null);
            }
            catch
            {
                return "Not Conect";
            }

            if (!httpResponse.StatusCode.ToString().Equals("OK"))
                return "Not Connect";


            return "OK";
        }
    }
}
