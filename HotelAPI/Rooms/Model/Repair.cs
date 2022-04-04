using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Rooms.Model
{
    public class Repair
    {
        public int Id_Room { get; set; }

        public DateTime DtStart { get; set; }
        
        public DateTime DtFinish { get; set; }

        public Double Price { get; set; }
    }
}
