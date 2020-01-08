﻿using System;
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

        public static bool login(String username, String password)
        {
            SlaDataSet dataSet = new SlaDataSet();

            SlaDataSetTableAdapters.SLA_USERSTableAdapter listLogin = new SlaDataSetTableAdapters.SLA_USERSTableAdapter();
            listLogin.Fill(dataSet.SLA_USERS);
            SlaDataSet.SLA_USERSRow user = listLogin.GetData().Where(u => u.USR_NAME.Equals(username)).First();

           if (user != null && user.USR_PASSWORD.Equals(password)){
                actual_user = user;
                return true;
           }

            return false;
        }


        public static bool userExist(String email, String username)
        {
            SlaDataSet dataSet = new SlaDataSet();

            SlaDataSetTableAdapters.SLA_USERSTableAdapter listLogin = new SlaDataSetTableAdapters.SLA_USERSTableAdapter();
            listLogin.Fill(dataSet.SLA_USERS);
            SlaDataSet.SLA_USERSRow user = listLogin.GetData().Where(u => u.USR_NAME.Equals(username) || u.USR_EMAIL.Equals(email) ).First();
            
            if(user != null)
            {
                return true;
            }

            return false;

        }

        public static bool isArtist()
        {
            if (actual_user != null && actual_user.USR_TYPE == 2)
            {
                return true;
            }
            return false;
        }
    }
}
