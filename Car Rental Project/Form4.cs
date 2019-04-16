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
    public partial class Form4 : Form 
    {

        Cars car = new Cars();
        Reservation reserve;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = car.carList();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["CarName"].ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                reserve = new Reservation(Cnametxt.Text, Cnicitxt.Text, (Convert.ToInt32(Cotacttxt.Text)), addresstxt.Text, cityttxt.Text, statetxt.Text, (Convert.ToInt32(daystxt.Text)), comboBox1.Text);
                reserve.getLicense(licensetxt.Text);
                Bill bill = new Bill(Convert.ToInt32(daystxt.Text), comboBox1.Text);
                bill.getDays(Convert.ToInt32(daystxt.Text));
                bill.getCar(comboBox1.Text);
                if (checkBox1.Checked)
                {
                    bill.billCalculatorWithDriver(comboBox1);
                    reserve.bookWithDriver();
                    reserve.check();
                    MessageBox.Show("Car Booked with Driver!");
                    MessageBox.Show("Your Total Bill including Driver charges is : " + bill.billCalculatorWithDriver(comboBox1));
                    OleDbDataReader reader = reserve.regKey();
                    while (reader.Read())
                    {
                        MessageBox.Show("Your Registration Key is " + reader["Registration"].ToString());
                    }
                }

                else
                {
                    {
                        bill.billCalculatorWithoutDriver();
                        reserve.check();
                        reserve.bookWithoutDriver();
                        MessageBox.Show("Car Booked without Driver!");
                        MessageBox.Show("Your Total Bill without Driver Charges is : " + bill.billCalculatorWithoutDriver());
                        OleDbDataReader reader = reserve.regKey();
                        while (reader.Read())
                        {
                            MessageBox.Show("Your Registration Key is " + reader["Registration"].ToString());
                        }

                    }
                }

            }
            catch
            {

                MessageBox.Show("Incorrect Input  Contact Number & Days should contain only Numerics");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                licensetxt.Enabled = false;
            }
            else
            {
                licensetxt.Enabled = true;
            }
        }
    }
}
