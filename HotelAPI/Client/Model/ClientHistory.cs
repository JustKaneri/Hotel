using System;
using System.Collections.Generic;

namespace HotelAPI.Client.Model
{
    public class ClientHistory
    {
        public List<DateTime> DateStart { get; set; }
        public List<DateTime> DateFinish { get; set; }
        public List<string> NameNomer { get; set; }
    }
}