using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace Bus_Reservation
{
    public partial class CLEAR : Form
    {
        string GiveKey;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public CLEAR(string Key)
            : base()
        {
            Load += CLEAR_Load_1;
            InitializeComponent();
            GiveKey = Key;
        }

        private void CLEAR_Load_1(System.Object sender, System.EventArgs e)
        {
            if (GiveKey == "C")
            {
                Label1.Text = "Clearing Records Of Current Booking";
            }
            else if (GiveKey == "A")
            {
                Label1.Text = "Clearing Records Of Advance Booking";
            }
            else if (GiveKey == "Canc")
            {
                Label1.Text = "Clearing Records Of Cancellation Booking";
            }
            else if (GiveKey == "Comp")
            {
                Label1.Text = "Clearing Records Of Completed Booking";
            }
            else if (GiveKey == "MF")
            {
                Label1.Text = "Clearing Records Of Master Data";
            }
        }

        private void Button1_Click_1(System.Object sender, System.EventArgs e)
        {
            if (GiveKey == "C")
            {
                Master.clear("PassengerDetails", "PaymentPassenger");
                ProgressBar1.Value = 100;
                MessageBox.Show("Current Booking Cleared..!");
            }
            else if (GiveKey == "A")
            {
                Master.clear("APassengerDetails", "APaymentPassenger");
                ProgressBar1.Value = 100;
                MessageBox.Show("Advance Booking Cleared..!");
            }
            else if (GiveKey == "Canc")
            {
                Master.clear("CancellationPassenger", "Cancellation");
                ProgressBar1.Value = 100;
                MessageBox.Show("Cancellation Booking Cleared..!");
            }
            else if (GiveKey == "Comp")
            {
                Master.clear("CompletedPassenger", "CompletedPP");
                ProgressBar1.Value = 100;
                MessageBox.Show("Completed Booking Cleared..!");
            }
            else if (GiveKey == "MF")
            {
                Master.clear("Route", "Bus");
                ProgressBar1.Value = 33;
                Master.clear("Driver", "Staff");
                ProgressBar1.Value = 66;
                Master.clear("Passenger", "Office");
                ProgressBar1.Value = 100;
                MessageBox.Show("Master Data Cleared..!");
            }
            else if (GiveKey == "All")
            {
                Master.clear("PassengerDetails", "PaymentPassenger");
                ProgressBar1.Value = 25;
                Master.clear("APassengerDetails", "APaymentPassenger");
                ProgressBar1.Value = 50;
                Master.clear("CancellationPassenger", "Cancellation");
                ProgressBar1.Value = 75;
                Master.clear("CompletedPassenger", "CompletedPP");
                ProgressBar1.Value = 100;
                MessageBox.Show("All Booking Cleared..!");
            }
        }

        private void Button2_Click_1(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

  
    }
}
