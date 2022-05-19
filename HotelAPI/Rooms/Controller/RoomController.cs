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

        /// <summary>
        /// Список номеров.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Room>> GetRooms()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Rooms/GetRooms?Date={DateTime.Now.ToString("dd.MM.yyyy")}";

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

            return JsonConvert.DeserializeObject<List<Room>>(result);
        }

        /// <summary>
        /// Отправить в ремонт
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repair"></param>
        /// <returns></returns>
        public async Task<string> Repair(int id,Repair repair)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + "api/Rooms/Repair";

            string Json = JsonConvert.SerializeObject(repair);

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

            return "OK";
        }

        /// <summary>
        /// Обновление информации о номере
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public async Task<string> RoomEdit(Room room)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Rooms/UpdateRoom?id={room.Id}";

            string Json = JsonConvert.SerializeObject(room);

            StringContent content = new StringContent(Json, Encoding.UTF8, "application/json");

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PutAsync(url, content);
            }
            catch
            {
                return "Not Conect";
            }


            if (!Message.StatusCode.ToString().Equals("OK"))
                return "Not Conect";

            return "OK";
        }


        /// <summary>
        /// Возврат с ремонта
        /// </summary>
        /// <param name="id"></param>
        public async Task<string> DeRepair(int Id,DateTime dtFinish)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Rooms/DeRepair?Id={Id}&dtFinish={dtFinish}";

            HttpResponseMessage httpResponse;

            try
            {
              httpResponse =  await Client.PutAsync(url, null);
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
        /// История номера
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<RoomHistory> GetHistoryRoom(int id)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Rooms/RoomHistrory?id={id}";

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

            return JsonConvert.DeserializeObject<RoomHistory>(result);
        }

        /// <summary>
        /// Подробная информация о номере
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public async Task<Room> GetRoomInfoAsync(int Id)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/Rooms/GetRoomInfo?Id={Id}&Date={DateTime.Now.ToString("dd.MM.yyyy")}";

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

            return JsonConvert.DeserializeObject<Room>(result);
        }
    }
}
