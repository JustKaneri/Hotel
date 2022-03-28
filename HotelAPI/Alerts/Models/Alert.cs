using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Alerts.Models
{
    public class Alert
    {
        public int Id_Alert { get; set; }
        public string TextAlert { get; set; }
        public string TypeAlert { get; set; }
        public DateTime DateAlert { get; set; }
    }
}
