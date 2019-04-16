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
    public partial class Form9 : Form
    {
        AddCar addcar = new AddCar();
        public Form9()
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

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void addcarbtn_Click(object sender, EventArgs e)
        {
              
                addcar.Carname = carnametxt.Text;
                addcar.Carcom = carcomtxt.Text;
                addcar.Carmod = carmodeltxt.Text;
                addcar.Carcol = carcolourtxt.Text;
                addcar.Carrent = int.Parse(carrenttxt.Text);


           

            try
            {
                OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Ammar\Desktop\Car Rental Project\Car Rental Project\bin\Debug\Car Rental Database.accdb");
                Conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "Insert into Car (CarName,CarCompany,CarModel,CarColour,CarRent) values('" + addcar.Carname + "','" + addcar.Carcom + "','" + addcar.Carmod + "','" + addcar.Carcol + "','" + addcar.Carrent + "')";
                cmd.ExecuteNonQuery();


                MessageBox.Show("Car Added.");
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
            }

        }


    }
}
    
