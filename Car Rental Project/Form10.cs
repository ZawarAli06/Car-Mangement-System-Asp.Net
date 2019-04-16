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
    public partial class Form10 : Form
    {
        Cars car = new Cars();
        DeleteCar delCar = new DeleteCar();
        public Form10()
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

        private void delcarbtn_Click(object sender, EventArgs e)
        {
            DeleteCar del = new DeleteCar();
            del.Carmodel = comboBox1.Text;
            try
            {
                OleDbConnection connect = new OleDbConnection(" Provider = Microsoft.ACE.oledb.12.0;data source=C:\\Users\\Ammar\\Desktop\\Car Rental Project\\Car Rental Project\\bin\\Debug\\Car Rental Database.accdb");
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "delete from Car where CarName = ('" + del.Carmodel + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Executed");

            }

            catch
            {
                MessageBox.Show("Unvalid Input.");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = car.carList();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["CarName"].ToString());
            }
        }



        }



       
    }

