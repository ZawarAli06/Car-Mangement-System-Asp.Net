using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    class Add_Admin
    {
        private string username;

        public string Username1
        {
            get { return username; }
            set { username = value; }
        }
       

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
