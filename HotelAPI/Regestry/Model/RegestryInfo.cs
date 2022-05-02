using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Regestry.Model
{
    public class RegestryInfo
    {
        public string Fam { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string Phohe { get; set; }
        public DateTime DtmStart { get; set; }
        public DateTime DtmEnd { get; set; }
        public string Price { get; set; }
        public List<string> NameServis { get; set; }
        public List<int> CountServis { get; set; }
        public List<string> PriceServis { get; set; }
    }
}
