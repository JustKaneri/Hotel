using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Statistic.Model
{
    public class StatisticInfo
    {
        public int CountPeople { get; set; }
        public double Prible { get; set; }
        public double Rashod { get; set; }
        public List<int> Session { get; set; }
        public List<double> LstPrible { get; set; }
        public List<double> LStRashod { get; set; }
    }
}
