using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Car_Rental_Project
{
    class Bill
    {
       
        int day;
        Members mem = new Members();
        string car,driver;
        string path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
        public static int total;
      
        int temp;
        int driverCharges = 1200;
        public Bill()
        {

        }
        public Bill(int _days,string _car)
        {
            day = _days;
            car = _car;
        }
        public void getDays(int _days)
        {
            day = _days;
        }
        public void getCar(string _carName)
        {
            car = _carName;
        }
        public void getDriver(string _driver)
        {
            driver = _driver;
        }
        public int billCalculator()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from Car where CarName =('" + car +"')";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
           while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
           if (driver == "With Driver")
           {
               total = (temp * day) + (driverCharges * day);
           }
           else if (driver == "Without Driver")
           {
               total = (temp * day);
           }
            
            return total;
        }
      
        public int billCalculatorWithDriver(ComboBox a)
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from Car where CarName =('" + car + "')";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
            total = (temp * day) + (driverCharges * day);
            return total;
        }
        public int luxbillCalculatorWithDriver(ComboBox a)
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from LuxuryCars where CarName =('" + car + "')";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
            total = (temp * day) + (driverCharges * day);
            return total;
        }

        public int billCalculatorWithoutDriver()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from Car where CarName ='" + car + "'";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
            total = (temp * day);
            return total;
        }
        public int luxbillCalculatorWithoutDriver()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from LuxuryCars where CarName ='" + car + "'";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
            total = (temp * day);
            return total;
        }
        public int billCalculatorWithDriverMembers()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from Car where CarName ='" + car + "'";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
           string check= mem.getMembershipType();
           if (check == "Platinum")
           {
               total = (temp * day) + (driverCharges * day);
               total = total / 2;
               return total;
           }
           else if (check == "Gold")
           {
               total = (temp * day) + (driverCharges * day);
               total = total / 100 * 25;
               return total;
           }
           else
           {
               total = (temp * day) + (driverCharges * day);
               total = total / 100 * 18;
               return total;
           }
            
        }
        public int billCalculatorWithoutDriverMembers()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string billQuery = "Select CarRent from Car where CarName ='" + car + "'";
            OleDbCommand cmd = new OleDbCommand(billQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = Convert.ToInt32(reader[0]);
            }
            string check = mem.getMembershipType();
            if (check == "Platinum")
            {
                total = (temp * day);
                total = total / 2;
                return total;
            }
            else if (check == "Gold")
            {
                total = (temp * day);
                total = total / 100 * 25;
                return total;
            }
            else
            {
                total = (temp * day);
                total = total / 100 * 18;
                return total;
            }

        }
    }
}
