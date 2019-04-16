using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace Car_Rental_Project
{
    class History
    {
        string path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
        string searchQuery;
        
        public OleDbDataReader searchByCarName(string _carName)
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Customer where (((Customer.Cars)= '" + _carName + "'))";
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public OleDbDataReader searchByBill(int _range1, int _range2)
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "SELECT * FROM Customer WHERE (((Customer.TotalBill) >" +  _range1 + " And (Customer.TotalBill)<" + _range2 + "))";
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
