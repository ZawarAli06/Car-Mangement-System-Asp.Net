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
    public partial class Member_Cancel_Reservation : Form
    {

        Search reserve = new Search();
        Search verify = new Search();
        Reservation delreservation = new Reservation();
        public Member_Cancel_Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delreservation.getluxRegNumber(Convert.ToInt32(textBox1.Text));

            OleDbDataReader reader = verify.connect3(Convert.ToInt32(textBox1.Text));
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
        }

        private void Member_Cancel_Reservation_Load(object sender, EventArgs e)
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


    }
}

