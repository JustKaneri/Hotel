﻿using HotelAPI.Autohrization;
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

        public async Task<RegestryInfo> GetRegestryInfo(int id_Room)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/GetInfo?id_room={id_Room}";

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

            return JsonConvert.DeserializeObject<RegestryInfo>(result);
        }

        public async Task<RegestryInfo> GetRegestryOldInfo(int id_Reg)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/GetOldInfo?Id_Reg={id_Reg}";

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

            return JsonConvert.DeserializeObject<RegestryInfo>(result);
        }

        /// <summary>
        /// Получить дату окончания проживания в гостинице
        /// </summary>
        /// <param name="id_Room"></param>
        /// <returns></returns>
        public async Task<string> GetFinsihDateRegestry(int id_Room)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/GetFinishDateRegestry?id_room={id_Room}";
            
            HttpResponseMessage Message;

            try
            {
                Message = await Client.GetAsync(url);
            }
            catch
            {
                return "Not Conect";
            }

            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return result.ToString();
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
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            string result = await Message.Content.ReadAsStringAsync();

            return result.ToString();
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

            string url = Properties.Resources.Url + $"api/Regestration/ContinieReg?id={Id}&dtFinish={date.Date + new TimeSpan(10,0,0)}";

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
                return "Not Conect";


            return "OK";
        }

        /// <summary>
        /// Cнятие с регистрации
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<string> DeRegistration(int Id, DateTime dtFinish)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/DeReg?id={Id}&DtFinish={dtFinish}";

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

        public async Task<string> DeleteRegistration(int Id_Reg)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Regestration/DeleteReg?id_Reg={Id_Reg}";

            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await Client.DeleteAsync(url);
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
