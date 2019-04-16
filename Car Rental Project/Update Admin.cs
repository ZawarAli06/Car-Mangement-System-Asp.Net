using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    class Update_Admin
    {
        private string newuser;

        public string Newuser
        {
            get { return newuser; }
            set { newuser = value; }
        }

        private string newpass;

        public string Newpass
        {
            get { return newpass; }
            set { newpass = value; }
        }

        private string u1;

        public string U1
        {
            get { return u1; }
            set { u1 = value; }
        }

        private string p1;

        public string P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }
}
