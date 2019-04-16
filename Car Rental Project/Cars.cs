using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace Car_Rental_Project
{
    class Cars
    {
        string path, carsQuery, cName, carsDescriptionQuery;
        public OleDbDataReader carList()
        {
             path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
             carsQuery = "select * from Car";
            OleDbCommand cmd = new OleDbCommand(carsQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
            
        }
        public OleDbDataReader luxList()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            carsQuery = "select * from LuxuryCars";
            OleDbCommand cmd = new OleDbCommand(carsQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public string setCarName(string _cName)
        {
            cName = _cName;
            return cName;
        }
        public OleDbDataReader description()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
             carsDescriptionQuery = "select Cars.CarDescription From Car Where (((Car.[CarName])='" + cName + "'))";
            OleDbCommand cmd = new OleDbCommand(carsDescriptionQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
            
        }
        
    }
}
