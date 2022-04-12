using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Regestry.Model
{
    public class Regestration
    {
        public int Id_Regestration { get; set; }
        public int Id_User { get; set; }
        public int Id_Client { get; set; }
        public int Id_Nomer { get; set; }
        public float FullPrice { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
