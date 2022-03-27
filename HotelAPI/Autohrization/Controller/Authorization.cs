using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using HotelAPI.Autohrization.Models;

namespace HotelAPI.Autohrization.Controller
{
    public class Authorization
    {
        private string Login;
        private string Password;

        private HttpClient Client;

        public CurrentUser User;

        public  Authorization(string login,string password)
        {
            Login = login;
            Password = password;
            
        }

        public async Task<CurrentUser> LogIn()
        {
            string token = await GetUser();

            if(token == null)
            {
                throw new Exception("Не верный логин или пароль");
            }

            string role = await GetRole(token);

            User = new CurrentUser(token, role);

            return User;
        }

        private async Task<string> GetRole(string token)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization",token);

            string url = Properties.Resources.Url + "api/Authorization/GetRole";

            HttpResponseMessage response = await Client.GetAsync(url);

            if (!response.StatusCode.ToString().Equals("OK"))
                return null;

            return await response.Content.ReadAsStringAsync();
        }

        private async Task<string> GetUser()
        {
            Client = new HttpClient();

            Dictionary<string,string> param = new Dictionary<string, string>();
            var url = Properties.Resources.Url + "token";
            param.Add("username", Login);
            param.Add("password", Password);
            param.Add("grant_type", "password");

            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response =  await Client.PostAsync(url, new FormUrlEncodedContent(param));

            if (!response.StatusCode.ToString().Equals("OK"))
                return null;

            string ResultResponse = await response.Content.ReadAsStringAsync();

            Token token = JsonConvert.DeserializeObject<Token>(ResultResponse);

            return token.token_type + " " + token.access_token;
        }
    }
}
