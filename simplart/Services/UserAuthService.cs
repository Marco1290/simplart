using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplart.Services
{
    class UserAuthService
    {
        public static string username = "";

        public static bool isArtist()
        {
            if (username.Equals("artiste"))
            {
                return true;
            }
            return false;
        }
    }
}
