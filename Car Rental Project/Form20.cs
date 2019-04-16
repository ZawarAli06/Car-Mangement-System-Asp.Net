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
    public partial class Form20 : Form
    {
        History bybill = new History();
        public Form20()
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

        private void Form20_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1000);
            comboBox1.Items.Add(2000);
            comboBox1.Items.Add(5000);
            comboBox1.Items.Add(10000);
            comboBox1.Items.Add(15000);
            comboBox1.Items.Add(30000);
            comboBox1.Items.Add(50000);
            comboBox1.Items.Add(100000);
            comboBox2.Items.Add(2000);
            comboBox2.Items.Add(4000);
            comboBox2.Items.Add(10000);
            comboBox2.Items.Add(20000);
            comboBox2.Items.Add(25000);
            comboBox2.Items.Add(50000);
            comboBox2.Items.Add(100000);
            comboBox2.Items.Add(1000000);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataReader reader = bybill.searchByBill(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text));
            if (reader.Read())
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Registration"].ToString(), reader["CName"].ToString(), reader["CNIC"].ToString(), reader["Contact"].ToString(), reader["Address"].ToString(), reader["LicenseNumber"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["Days"].ToString(), reader["Cars"].ToString(), reader["TotalBill"].ToString(), reader["Driver"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No Records Found for your criteria");
            }
        }
    }
}
