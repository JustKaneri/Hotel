using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Rooms.Model
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public Nullable<System.DateTime> DateFinish { get; set; }
        public float Price { get; set; }
        public int IdRoom { get; set; }
    }
}
