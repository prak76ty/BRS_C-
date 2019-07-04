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
    public partial class Seat_Booking_Details : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int i;
        int BNO4;
        string checkm;
        public Seat_Booking_Details(System.Object msgreceived, System.Object BN)
            : base()
        {
            InitializeComponent();
            checkm = msgreceived.ToString();
            BNO4 = Convert.ToInt32(BN);
        }

        private void Seat_Booking_Details_Load(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            BookingNo.Text = BNO4.ToString();
            BookingNo.Text = BNO4.ToString();
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select * From PaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
            }
            else
            {
                cmd = new SqlCommand("Select * From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
            }
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                DGV.Rows.Add();
                DGV[0, i].Value = Convert.ToString(dr.GetValue(0));
                DGV[1, i].Value = Convert.ToString(dr.GetValue(1));
                DGV[2, i].Value = Convert.ToString(dr.GetValue(2));
                BookingDate.Value = Convert.ToDateTime(dr.GetValue(2));
                DGV[3, i].Value = Convert.ToString(dr.GetValue(3));
                DGV[4, i].Value = Convert.ToString(dr.GetValue(4));
                DGV[5, i].Value = Convert.ToString(dr.GetValue(5));
                DGV[6, i].Value = Convert.ToString(dr.GetValue(6));
                PN.Text = Convert.ToString(dr.GetValue(6));
                DGV[7, i].Value = Convert.ToString(dr.GetValue(7));
                DGV[8, i].Value = Convert.ToString(dr.GetValue(8));
                DGV[9, i].Value = Convert.ToString(dr.GetValue(9));
                i += 1;
            }
            dr.Close();
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select * From PassengerDetails Where BookingNo=" + BookingNo.Text + "", con);
            }
            else
            {
                cmd = new SqlCommand("Select * From APassengerDetails Where BookingNo=" + BookingNo.Text + "", con);
            }
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                DGV2.Rows.Add();
                DGV2[0, i].Value = Convert.ToString(dr.GetValue(0));
                DGV2[1, i].Value = Convert.ToString(dr.GetValue(1));
                DGV2[2, i].Value = Convert.ToString(dr.GetValue(2));
                DGV2[3, i].Value = Convert.ToString(dr.GetValue(3));
                DGV2[4, i].Value = Convert.ToString(dr.GetValue(4));
                DGV2[5, i].Value = Convert.ToString(dr.GetValue(5));
                DGV2[6, i].Value = Convert.ToString(dr.GetValue(6));
                DGV2[7, i].Value = Convert.ToString(dr.GetValue(7));
                DGV2[8, i].Value = Convert.ToString(dr.GetValue(8));
                DGV2[9, i].Value = Convert.ToString(dr.GetValue(9));
                DGV2[10, i].Value = Convert.ToString(dr.GetValue(10));
                PaymentBy.Text = Convert.ToString(dr.GetValue(10));
                i += 1;
            }
            dr.Close();
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Update PaymentPassenger Set WaitingNo=" + "0" + " Where BookingNo=" + BookingNo.Text + "", con);
            }
            else
            {
                cmd = new SqlCommand("Update APaymentPassenger Set WaitingNo=" + "0" + " Where BookingNo=" + BookingNo.Text + "", con);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            Master.Completed();
        }

        private void Ending_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                //SeatBooking.Close();
                this.Close();
                //My.MyProject.Forms.AdvanceSeatBooking.Close();
                Master.Completed();
                //WaitingList.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong..! Manually Close Application.. Or " + ex.Message);
            }
        }
    }
}
