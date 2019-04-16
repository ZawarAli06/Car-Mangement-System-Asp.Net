using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    class GetCars
    {
        string path, carQuery;
        public void cars()
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            carQuery = "select * CarModel from Cars";
            OleDbCommand cmd = new OleDbCommand(carQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                
            }
        }
    }

}
