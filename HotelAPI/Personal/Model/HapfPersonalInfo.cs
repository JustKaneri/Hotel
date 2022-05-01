using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Personal.Model
{
    public class HapfPersonalInfo
    {
        public int Id { get;  set; }
        public string Fam { get;  set; }
        public string Name { get;  set; }
        public string Othc { get;  set; }
        public DateTime? DateBorn { get;  set; }
        public int IdPost { get;  set; }
        public Posts PostPersonal { get;  set; }
    }
}
