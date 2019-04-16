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
    public partial class Luxury_Car_Delete_Reservation_Form : Form
    {
        Search reserve = new Search();
        Search verify = new Search();
        Reservation delreservation = new Reservation();
        public Luxury_Car_Delete_Reservation_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delreservation.getluxRegNumber(Convert.ToInt32(comboBox1.Text));

            OleDbDataReader reader = verify.connect3(Convert.ToInt32(comboBox1.Text));
            if (reader.Read())
            {
                if (MessageBox.Show("Are you sure you want to cancel the Reservation ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    delreservation.luxdelReservation();
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

        private void Luxury_Car_Delete_Reservation_Form_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = reserve.luxreservations();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["MembershipID"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }
    }
}
