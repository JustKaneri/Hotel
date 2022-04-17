using HotelAPI.Users.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Client.Model
{
    public class ClientInfo: ClientHalfInfo
    {
        public string PasportS { get; set; }
        public string PasportN { get; set; }
        public string Phone { get; set; }
        public ClientHistory History { get; set; }
    }
}
