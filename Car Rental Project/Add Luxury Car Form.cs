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

    public partial class Add_Luxury_Car_Form : Form
    {
        Add_Luxury_Car_Class luxcar = new Add_Luxury_Car_Class();
        Connection_Class con = new Connection_Class();
        public Add_Luxury_Car_Form()
        {
            InitializeComponent();
        }

        private void Luxcaraddbtn_Click(object sender, EventArgs e)
        {
            luxcar.Luxcarname = luxcarname.Text;
            luxcar.Luxcarcompany = luxcarcom.Text;
            luxcar.Luxcarcolour = luxcarcol.Text;
            luxcar.Luxcarrent = luxcarrent.Text;

            try
            {
                OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb");
                Conn.Open();
                OleDbCommand cmd = new OleDbCommand();
              


                MessageBox.Show("Luxury Car Added.");
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

    } 
}
