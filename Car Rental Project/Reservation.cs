using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    public class Reservation
    {

        
        int total;
        string name, address, city, state, car, license, nic;
        int memberID;
        int days;
        int regNumber;
        int regNumber1;
        int contact;
        string insertQuery, regQuery, path, deleteQuery;
        public Reservation()
        {

        }
        public Reservation(string _name, string _nic, int _contact, string _address, string _city, string _state, int _days, string _car)
        {
            name = _name;
            nic = _nic;
            contact = _contact;
            address = _address;
            city = _city;
            state = _state;
            days = _days;
            car = _car;
        }
        public void setDetails(string _cName, int _contact, string _address, string _city, string _state, string _nic, int _days, string _car)
        {
            name = _cName;
            nic = _nic;
            contact = _contact;
            address = _address;
            city = _city;
            state = _state;
            days = _days;
            car = _car;
        }
        public string getCar()
        {
            return car;
        }
        public int getDays()
        {
            return days;

        }
        public string getLicense(string _license)
        {
            license = _license;
            return license;
        }
        public int getMemberID(int _memberID)
        {
            memberID = _memberID;
            return memberID;
        }


        public int check()
        {
            total = Bill.total;
            return total;
        }

        public void bookWithDriver()
        {
            path = @" Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            insertQuery = "Insert into Customer (CName,CNIC,Contact,Address,LicenseNumber,City,State,Days,Cars,TotalBill,Driver) Values('" + name + "','" + nic + "'," + contact + ",'" + address + "','" + license + "','" + city + "','" + state + "'," + days + ",'" + car + "'," + Bill.total + "," + true + ")"; //1448116888 is the default memID for non members.
            OleDbCommand cmd = new OleDbCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();
        }
        
        public void bookWithoutDriver()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            insertQuery = "Insert into Customer (CName,CNIC,Contact,Address,LicenseNumber,City,State,Days,Cars,TotalBill,Driver) Values(" + "'" + name + "','"  + nic + "'," + contact + ",'" + address + "','" + license + "','" + city + "','" + state + "'," + days + ",'" + car + "'," + total + "," + false + ")";
            OleDbCommand cmd = new OleDbCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();
        }
       
        public OleDbDataReader regKey()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            regQuery = "Select * from Customer where CName=('" + name + "')";
            OleDbCommand cmd = new OleDbCommand(regQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int getRegNumber(int _regNumber)
        {
            regNumber = _regNumber;
            return regNumber;
        }
        public void delReservation()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            deleteQuery = "delete from Customer where Registration = " + regNumber;
            OleDbCommand cmd = new OleDbCommand(deleteQuery, connect);
            cmd.ExecuteNonQuery();
        }


        public void memberwithdriver()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            insertQuery = "Insert Into Member(MembershipID,Days,Cars,Driver) values(" + memberID + "','" + days + "','" + car + "','" + true + "')";
            OleDbCommand cmd = new OleDbCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();
        }

        public void memberwithoutdriver()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            insertQuery = "Insert Into Member(MembershipID,Days,Cars,Driver) values(" + memberID + "','" + days + "','" + car + "','" + false + ")";
            OleDbCommand cmd = new OleDbCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();
        }

        public int getluxRegNumber(int _luxregNumber)
        {
            regNumber1 = _luxregNumber;
            return regNumber1;
        }
        public void luxdelReservation()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            deleteQuery = "delete from Member where MembershipID = " + regNumber1;
            OleDbCommand cmd = new OleDbCommand(deleteQuery, connect);
            cmd.ExecuteNonQuery();
        }


    }
}
