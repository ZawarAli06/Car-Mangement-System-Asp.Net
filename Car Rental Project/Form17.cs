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
    public partial class Form17 : Form
    {
        Reservation delReservation = new Reservation();
        Search verifyRegKey = new Search();
        public Form17()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            
            

                delReservation.getRegNumber(Convert.ToInt32(textBox2.Text));

                OleDbDataReader reader = verifyRegKey.connect2(Convert.ToInt32(textBox2.Text));
                if (reader.Read())
                {
                    if (MessageBox.Show("Are you sure you want to cancel the Reservation ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        delReservation.delReservation();
                        MessageBox.Show("Reservation Cancelled !");
                    }
                    else
                    {
                        MessageBox.Show("No Problem :)");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Registration Number/Key!, Please Try again", "Incorrect");
                }
            
             
        }
    }
}
