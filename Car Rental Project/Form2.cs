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
    public partial class Form2 : Form
    {
        Bill calculator = new Bill();
        Cars car = new Cars();
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            int id = Convert.ToInt32(textBox1.Text);
            calculator.getDays(Convert.ToInt32(textBox2.Text));
            calculator.getCar(comboBox1.Text);
            if (checkBox1.Checked)
            {
                calculator.luxbillCalculatorWithDriver(comboBox1);
                OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb");
                total = Bill.total;
                Conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "Update  Member Set Days= '" + textBox2.Text + "',Car='" + comboBox1.Text + "',Driver = " + true + ", TotalBill = " + total + " Where MembershipID = " + id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Luxury Car Booked With Driver.");
                
                MessageBox.Show(total.ToString());
                Conn.Close();
            }
            else
            {
                calculator.luxbillCalculatorWithoutDriver();
                OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb");
                Conn.Open();
                total = Bill.total;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "Update  Member Set Days= '" + textBox2.Text + "',Car='" + comboBox1.Text + "',Driver = " + false + ",TotalBill=" + total + " Where MembershipID = " + id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Luxury Car Booked Without Driver.");
                
                MessageBox.Show(total.ToString());
                Conn.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = car.luxList();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["CarName"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

    }
}
