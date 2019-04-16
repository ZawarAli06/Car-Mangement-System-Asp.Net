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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void changeinfobtn_Click(object sender, EventArgs e)
        {
            
                OleDbConnection connect = new OleDbConnection(" Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb");
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "Update Admin SET [Password] = '" + passtxt.Text + "' where Username ='" + outxt.Text +"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated.");

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void upadmintxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

