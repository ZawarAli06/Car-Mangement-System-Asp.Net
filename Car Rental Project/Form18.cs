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
    public partial class Form18 : Form
    {
        Search search = new Search();
        public Form18()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search.setReg(Convert.ToInt32(textBox2.Text));
            search.connect();
            OleDbDataReader reader = search.connect();
            if (reader.Read())
            {
                MessageBox.Show("Registration Number  :  " + reader[0].ToString() + "\tCustomer Name  :   " + reader[1].ToString() + "\n NIC #   :       " + reader[2].ToString() + "      Contact Number   :    " + reader[3].ToString() + "\nAddress    :     " + reader[4].ToString() + "     License #  :     " + reader[5].ToString() + "       City   :    " + reader[6].ToString() + "      State   :     " + reader[7].ToString()   + "\nCar Name  :    " + reader[9].ToString() + "      Car Rented For Days   :     " + reader[8].ToString()    +   "Total Bill   :     " + reader[10].ToString() + " Rupees    " + "\n    Rented With Driver  ?   " + reader[11].ToString(), "Registration Details");
            }
            else
            {
                MessageBox.Show("No Such Registration Found, Please Type your correct Registration Key Again");
            }
            
        }
    }
}
