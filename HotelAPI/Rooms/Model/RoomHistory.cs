using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Rooms.Model
{
    public class RoomHistory
    {
        public List<DateTime> DateStart { get; set; }
        public List<DateTime> DateFinish { get; set; }
        public List<string> FIO { get; set; }
        public List<int> IdReg { get; set; }
    }
}
