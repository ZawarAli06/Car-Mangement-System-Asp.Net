using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace Car_Rental_Project
{
    class Search
    {
        string path, searchQuery;
        int reg;
        int reg1;
        string [] result=new string[1000];
        public int setReg(int _reg)
        {
            reg = _reg;
            return reg;
        }
        
        public OleDbDataReader connect()
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Customer where Registration = " + reg;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public OleDbDataReader reservations()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string Query2 = "select * from Customer";
            OleDbCommand cmd = new OleDbCommand(Query2, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public OleDbDataReader memberships()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string Query2 = "select * from Member";
            OleDbCommand cmd = new OleDbCommand(Query2, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public OleDbDataReader connect2(int _reg)
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Customer where Registration = " + _reg;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public OleDbDataReader searchMember(string _membershipID)
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Member where MembershipID=" + _membershipID;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }

        public OleDbDataReader luxreservations()
        {
            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string Query2 = "select * from Member";
            OleDbCommand cmd = new OleDbCommand(Query2, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public OleDbDataReader connect3(int _reg)
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Member where MembershipID = " + _reg;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int setmemReg(int _reg1)
        {
            reg1 = _reg1;
            return reg1;
        }

        public OleDbDataReader connect4()
        {

            path = " Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            searchQuery = "select * from Member where MembershipID = " + reg1;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
