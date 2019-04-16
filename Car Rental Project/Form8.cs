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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adminform f1 = new Adminform();
            f1.Show();
            this.Hide();
        }

        

       

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void addNormalCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void cancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminform f1 = new Adminform();
            f1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void updateAdminPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void checkHistoryByCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void checkHistoryByBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();
        }

        private void addLuxuryCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Luxury_Car_Form luxcar = new Add_Luxury_Car_Form();
            luxcar.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void memberCancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luxury_Car_Delete_Reservation_Form f0 = new Luxury_Car_Delete_Reservation_Form();
            f0.Show();
            this.Hide();
        }
    }
}
