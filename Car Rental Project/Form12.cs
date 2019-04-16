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
    public partial class Form12 : Form
    {
        Reservation delReservation = new Reservation();
        Search reserve = new Search();
        Search verifyRegKey = new Search();
       
        public Form12()
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

        private void Form12_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = reserve.reservations();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Registration"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            delReservation.getRegNumber(Convert.ToInt32(comboBox1.Text));

            OleDbDataReader reader = verifyRegKey.connect2(Convert.ToInt32(comboBox1.Text));
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
