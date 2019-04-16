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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Admin ad = new Add_Admin();
            ad.Username1 = addmintxt.Text;
            ad.Password = newadminpastxt.Text;
                
            try

            {

                OleDbConnection connect = new OleDbConnection(" Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb");
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "Insert into Admin (Username ,[Password]) values ('" + ad.Username1 + "','" + ad.Password + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("New Admin Is Added.");


            }

            catch
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
