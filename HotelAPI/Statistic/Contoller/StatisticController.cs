using HotelAPI.Autohrization;
using HotelAPI.Statistic.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Statistic.Contoller
{
    public class StatisticController
    {
        private CurrentUser User;
        private HttpClient Client;

        public StatisticController(CurrentUser user)
        {
            User = user;
        }

        public async Task<StatisticInfo> GetStatisticInfo()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Statistic/GetStatistisc";

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

            return JsonConvert.DeserializeObject<StatisticInfo>(result);
        }
    }
}
