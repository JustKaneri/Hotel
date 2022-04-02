using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Rooms.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public int IdTypeRoom { get; set; }
        public string TypeRoom { get; set; }
        public double Money { get; set; }
        public int CountPerson { get; set; }

        public List<Equpment> Equpments { get; set; }
    }
}
