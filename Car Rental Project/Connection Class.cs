using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    public class Connection_Class
    {
        public OleDbConnection _con;
        public Connection_Class()
       {
           string path = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb";
            OleDbConnection con = new OleDbConnection(path);
            con.Open();
            _con = con;
            
       }
        
        
    }
}
