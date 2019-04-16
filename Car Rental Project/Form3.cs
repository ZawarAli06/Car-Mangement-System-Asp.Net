using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void normalReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void checkReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            this.Hide();
        }

        private void cancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminform f1 = new Adminform();
            f1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void normalCarReservationForMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void luxuryCarReservationForMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void memberCancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Cancel_Reservation f0 = new Member_Cancel_Reservation();
            f0.Show();
            this.Hide();
        }

        private void memberCheckReservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Member_Check_Reservation f0 = new Member_Check_Reservation();
            f0.Show();
            this.Hide();
        }

        private void memerCancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Cancel_Reservation f0 = new Member_Cancel_Reservation();
            f0.Show();
            this.Hide();
        }
    }
}
