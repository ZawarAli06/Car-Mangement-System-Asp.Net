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
    public partial class Member_Check_Reservation : Form
    {
        Search search = new Search();
        public Member_Check_Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search.setmemReg(Convert.ToInt32(textBox1.Text));
            search.connect4();
            OleDbDataReader reader = search.connect4();
            if (reader.Read())
            {
                MessageBox.Show("MembershipID  :  " + reader[0].ToString() + "\tMemberName   :   " + reader[1].ToString() + "\n MemberCnic #   :       " + reader[2].ToString() + "      MemberContact   :    " + reader[3].ToString() + "\nMemberAddress    :     " + reader[4].ToString() + "     MemberCity #  :     " + reader[5].ToString() + "       MemberState   :    " + reader[6].ToString() + "     MemberLicense   :     " + reader[7].ToString() + "\nMembershipType  :    " + reader[8].ToString() + "      Years   :     " + reader[9].ToString() + "   Days  :   "+ reader[10].ToString() + "    Car    :  " + reader[11].ToString() + "\n    Rented With Driver  ?   " + reader[12].ToString()+ "\tTotal Bill   :     " + reader[13].ToString());
            }
            else
            {
                MessageBox.Show("No Such Registration Found, Please Type your correct Registration Key Again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
