using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Car_Rental_Project
{
    class Members
    {
        
        string cName,cLicense,cNIC,membershipType,validity,address,city,state,insertQuery;
        int contact;
        string temp;
        string path = @" Provider = Microsoft.ACE.oledb.12.0; data source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb";
        public Members(string _cName, string _cLicense, string _cNIC, string _validity, int _contact,string _city,string _state,string _address)
        {
            cName = _cName;
          
            cLicense = _cLicense;
            cNIC = _cNIC;
            city = _city;
            state = _state;
            address = _address;
            validity = _validity;
            contact = _contact;
        }
        public Members()
        {

        }
        public void getMembership(string _membership)
        {
            membershipType = _membership;
        }
        public void addMember()
        {
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            insertQuery = "Insert into Member(MemberName,MemberCnic,MemberContact,MemberAddress,MemberCity,MemberState,MemberLicense,MembershipType,Years) Values('" + cName + "','"  + cNIC + "'," +contact + ",'" + address + "','" + city + "','" + state + "','" + cLicense + "','" + membershipType + "','" + validity +"')";
            OleDbCommand cmd = new OleDbCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();
        }
        public void memberType(string membershipID)
        {
            path = @" Provider = Microsoft.ACE.oledb.12.0;data source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
            string searchQuery = "select MembershipType from Member where MembershipID=" + membershipID;
            OleDbCommand cmd = new OleDbCommand(searchQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader["MembershipType"].ToString();
            }
        }
        public string getMembershipType()
        {
            return temp;
        }
        public OleDbDataReader memberID()
        {
            path = @" Provider = Microsoft.ACE.oledb.12.0;data source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb";
            OleDbConnection connect = new OleDbConnection(path);
            connect.Open();
           string idQuery = "Select * from Member where MemberName=" + "'" + cName +"'";
            OleDbCommand cmd = new OleDbCommand(idQuery, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

       
    }
}
