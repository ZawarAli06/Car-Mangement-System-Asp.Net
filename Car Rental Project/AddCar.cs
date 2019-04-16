using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    class AddCar
    {
        
        private string carname1;

        public string Carname
        {
            get { return carname1; }
           set { carname1 = value; }
        }

        private string carcom;

       public string Carcom
        {
           get { return carcom; }
            set { carcom = value; }
        }

        private string carmod;

        public string Carmod
        {
            get { return carmod; }
            set { carmod = value; }
        }

        private string carcol;

        public string Carcol
        {
            get { return carcol; }
           set { carcol = value; }
        }

        private int carrent;

        public int Carrent
        {
            get { return carrent; }
            set { carrent = value; }
        }

    }
}
