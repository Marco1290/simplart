using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplart.Services
{
    class UserAuthService
    {

        private static SlaDataSet.SLA_USERSRow actual_user;

        public static SlaDataSet.SLA_USERSRow login(String username, String password)
        {
            SlaDataSet dataSet = new SlaDataSet();

            SlaDataSetTableAdapters.SLA_USERSTableAdapter listLogin = new SlaDataSetTableAdapters.SLA_USERSTableAdapter();
            listLogin.Fill(dataSet.SLA_USERS);

            foreach (SlaDataSet.SLA_USERSRow user in listLogin.GetData())
            {
                if ((username.Equals(user.USR_EMAIL.Trim()) && password.Equals(user.USR_PASSWORD.Trim())))
                {
                    return user;
                }
            }
            return null;
        }

        public static bool isArtist()
        {
            if (actual_user != null && actual_user.USR_TYPE.Equals(2))
            {
                return true;
            }
            return false;
        }
    }
}
