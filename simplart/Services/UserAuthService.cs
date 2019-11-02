using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplart.Services
{
    class UserAuthService
    {
        public static string Username = "";

        public static bool isArtist()
        {
            if (Username.Equals("artiste"))
            {
                return true;
            }
            return false;
        }
    }
}
