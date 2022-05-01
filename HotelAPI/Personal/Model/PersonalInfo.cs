using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Personal.Model
{
    public class PersonalInfo:HapfPersonalInfo
    {
        public string INN { get;  set; }
        public string Polic { get;  set; }
        public string PasportN { get;  set; }
        public string PasportS { get;  set; }
        public string Login { get;  set; }
        public string Password { get;  set; }
    }
}
