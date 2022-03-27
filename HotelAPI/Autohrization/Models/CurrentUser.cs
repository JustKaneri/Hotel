using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Autohrization
{
    public class CurrentUser
    {
        public string Token { get; }

        public string RoleUser { get; }

        public CurrentUser(string token,string roleUser)
        {
            Token = token;
            RoleUser = roleUser;
        }
    }
}
