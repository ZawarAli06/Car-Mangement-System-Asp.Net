using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Car_Rental_Project
{
      
    public partial class Adminform : Form
    {

        Connection_Class obj = new Connection_Class();
        public Adminform()
        {

            InitializeComponent();
            
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Login_Class add = new Admin_Login_Class();
            add.Username1 = UsernameTxt.Text;
            add.Pass1 = PasswordTxt.Text;
            OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb");
            Conn.Open();

            string SelectQuery = "Select Username,Password From Admin where Username = ('" + add.Username1 + "','" + add.Pass1 +"')";
            OleDbCommand cmd = new OleDbCommand(SelectQuery,Conn);
            MessageBox.Show("Logged In.");
            Form8 f3 = new Form8();
            f3.Show();
            this.Hide();

           
        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
