using HotelAPI.Autohrization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotelAPI.PhotoNomer.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace HotelAPI.PhotoNomer.Controller
{
    public class PhotoNomerController
    {
        private CurrentUser User;
        private HttpClient Client;

        public PhotoNomerController(CurrentUser user)
        {
            User = user;
        }

        /// <summary>
        /// Получить фото номера
        /// </summary>
        /// <param name="id_Room"></param>
        /// <returns></returns>
        public async Task<List<PhotoNomers>> GetPhotoNomers(int id_Room)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/PhotoNomer/GetPhotos?id_Room={id_Room}";

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

            List<Model.PhotoNomers> photoNomers = JsonConvert.DeserializeObject<List<Model.PhotoNomers>>(result);

            foreach (var item in photoNomers)
            {
                item.PhotoPath = Properties.Resources.Url.Remove(Properties.Resources.Url.Length - 1) + item.PhotoPath;
            }

            return photoNomers;
        }


        /// <summary>
        /// Добавление фото
        /// </summary>
        /// <param name="id_Room"></param>
        /// <param name="photo"></param>
        /// <param name="newPhotoName"></param>
        /// <param name="oldPhotoName"></param>
        /// <returns></returns>
        public async Task<int> AddPhoto(int id_Room, byte[] photo, string oldPhotoName)
        {
            var formContent = new MultipartFormDataContent
            {
                  {new StreamContent(new MemoryStream(photo)),"data",oldPhotoName}
            };

            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/PhotoNomer/AddPhoto?id_Room={id_Room}";

            HttpResponseMessage Message;

            try
            {
                Message = await Client.PostAsync(url,formContent);
            }
            catch
            {
                return -1;
            }

            if (!Message.StatusCode.ToString().Equals("OK"))
                return -1;

            string id = await Message.Content.ReadAsStringAsync();

            return int.Parse(id);
        }

        /// <summary>
        /// Удаление фото
        /// </summary>
        /// <param name="id_Photo"></param>
        /// <returns></returns>
        public async Task<string> DeletePhoto(int id_Photo)
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Authorization", User.Token);

            string url = Properties.Resources.Url + $"api/PhotoNomer/Delete?id={id_Photo}";

            HttpResponseMessage Message;

            try
            {
                Message = await Client.DeleteAsync(url);
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
