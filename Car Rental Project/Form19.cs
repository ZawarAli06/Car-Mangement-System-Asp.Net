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
    public partial class Form19 : Form
    {
        Cars car = new Cars();
        History record = new History();
        public Form19()
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

        private void button1_Click(object sender, EventArgs e)
        {
           // try
            //{
                OleDbDataReader reader = record.searchByCarName(comboBox1.Text);
                while (reader.Read())
                {

                    
                    dataGridView1.Rows.Add(reader["Registration"].ToString(), reader["CName"].ToString(), reader["CNIC"].ToString(), reader["Contact"].ToString(), reader["Address"].ToString(), reader["LicenseNumber"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["Days"].ToString(), reader["Cars"].ToString(), reader["TotalBill"].ToString(), reader["Driver"].ToString());
                    
                }
           // }
           // catch
            //{
               // MessageBox.Show("Error");
            //}
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = car.carList();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["CarName"].ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
