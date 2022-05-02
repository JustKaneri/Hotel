using HotelAPI.Autohrization;
using HotelAPI.Personal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Personal.Controller
{
    public class PersonalController
    {
        private CurrentUser User;
        private HttpClient Client;

        public PersonalController(CurrentUser user)
        {
            User = user;
        }

        /// <summary>
        /// Получить список персонала
        /// </summary>
        /// <returns></returns>
        public async Task<List<HapfPersonalInfo>> GetHalfPersonal()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Personal/GetPersonals";

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

            return JsonConvert.DeserializeObject<List<HapfPersonalInfo>>(result);
        }

        /// <summary>
        /// Получить полную информацию
        /// </summary>
        /// <param name="id_personal"></param>
        /// <returns></returns>
        public async Task<PersonalInfo> GetPersonalInfo(int id_personal)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Personal/GetPersonalInfo?Id={id_personal}";

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

            return JsonConvert.DeserializeObject<PersonalInfo>(result);
        }

        /// <summary>
        /// Добавление нового работника
        /// </summary>
        /// <param name="personal"></param>
        /// <returns></returns>
        public async Task<string> AddPersonal(PersonalInfo personal)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Client/AddPersonal";

            string json = JsonConvert.SerializeObject(personal);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PostAsync(url,content);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                  return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return "OK";
        }

        /// <summary>
        /// Добавление нового работника
        /// </summary>
        /// <param name="personal"></param>
        /// <returns></returns>
        public async Task<string> EditPersonal(PersonalInfo personal)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Personal/UpdatePersonal?id={personal.Id}";

            string json = JsonConvert.SerializeObject(personal);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PutAsync(url,content);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return "OK";
        }

        /// <summary>
        /// Удалить работника
        /// </summary>
        /// <param name="personal"></param>
        /// <returns></returns>
        public async Task<string> DismissalPersonal(int id)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Personal/Dismissal?id={id}";

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PutAsync(url,null);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return "OK";
        }

        /// <summary>
        /// Получить список должностей
        /// </summary>
        /// <returns></returns>
        public async Task<List<Post>> GetPosts()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Post/GetPost";

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

            return JsonConvert.DeserializeObject<List<Post>>(result);
        }
    }
}
