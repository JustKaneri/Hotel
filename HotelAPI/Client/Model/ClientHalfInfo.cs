using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Users.Model
{
    public class ClientHalfInfo
    {
        public int Id { get; set; }
        public string Fam { get; set; }
        public string Name { get; set; }
        public string Othc { get; set; }
        public DateTime? DateBorn { get; set; }
    }
}
