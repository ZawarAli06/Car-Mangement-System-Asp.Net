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
    public partial class Form5 : Form
    {
        Members membership;
        Members mem = new Members();
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            membership = new Members(memcnametxt.Text, memlicensetxt.Text, memcnictxt.Text, memyeartxt.Text, (Convert.ToInt32(memcontacttxt.Text)), memcitytxt.Text, memstatetxt.Text, memaddresstxt.Text);
                    
                    
                  
                if (radioButton1.Checked)
                {
                    membership.getMembership("Silver");
                }
                else if (radioButton2.Checked)
                {
                    membership.getMembership("Gold");
                }
                else if (radioButton3.Checked)
                {
                    membership.getMembership("Platinum");
                }
                membership.addMember();
                MessageBox.Show("Added");
                OleDbDataReader reader = membership.memberID();
                while (reader.Read())
                {
                    MessageBox.Show("Your Membership ID is " + reader["MembershipID"].ToString(), "Membership ID");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
