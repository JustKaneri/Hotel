using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Servis.Model
{
    public class ServisInfo
    {
        public int Id_Servis { get; set; }
        public int Id_Equpmnet { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
