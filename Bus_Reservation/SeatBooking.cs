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

    public partial class SeatBooking : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int t;
        int seats;
        int a;
        int b;
        int c;
        int d;
        int k;
        int l;
        public void btnclear_Click(System.Object sender, System.EventArgs e)
        {
            Rno.Text = "Select";
            cmbstartpoint.Text = "";
            cmbdestination.Text = "";
            BusSerialNo.Text = "Select";
            BusNumber.Text = "Select";
            BusType.Text = "Select";
            BusReservation.Text = "Select";
            Arrivaltime.Value = Convert.ToDateTime(DateTime.Now);
            Departuretime.Value = Convert.ToDateTime(DateTime.Now);
            SeatCapacity.Clear();
            S1.Clear();
            S2.Clear();
            SeatAvailability.Clear();
            SC2.Clear();
        }

        public void SeatBooking_Load(System.Object sender, System.EventArgs e)
        {
            Rno.Text = "Select";
            cmbstartpoint.Text = "Select";
            cmbdestination.Text = "Select";
            BusSerialNo.Text = "Select";
            BusNumber.Text = "Select";
            BusType.Text = "Select";
            BusReservation.Text = "Select";
            SeatCapacity.Text = "40";
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Distinct(Rno) From Route", con);
            dr = cmd.ExecuteReader();
            Rno.Items.Clear();
            while (dr.Read())
            {
                Rno.Items.Add(Convert.ToString(dr.GetValue(0)));
            }
            dr.Close();
            con.Close();

            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Distinct(BusSno) From Bus", con);
            dr = cmd.ExecuteReader();
            BusSerialNo.Items.Clear();
            while (dr.Read())
            {
                BusSerialNo.Items.Add(Convert.ToString(dr.GetValue(0)));
            }
            dr.Close();
            con.Close();

            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select max(BookingNo) From PaymentPassenger", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if ((!object.ReferenceEquals(dr[0], DBNull.Value)))
            {
                t = Convert.ToInt32(dr[0]) + 1;
            }
            else
            {
                t = 1;
            }
            c = t;
            dr.Close();
            cmd = new SqlCommand("Select max(BookingNo) From APaymentPassenger", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if ((!object.ReferenceEquals(dr[0], DBNull.Value)))
            {
                t = Convert.ToInt32(dr[0]) + 1;
            }
            else
            {
                t = 1;
            }
            d = t;
            dr.Close();
            cmd = new SqlCommand("Select max(BookingNo) From Cancellation", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if ((!object.ReferenceEquals(dr[0], DBNull.Value)))
            {
                t = Convert.ToInt32(dr[0]) + 1;
            }
            else
            {
                t = 1;
            }
            k = t;
            dr.Close();
            cmd = new SqlCommand("Select max(BookingNo) From CompletedPP", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if ((!object.ReferenceEquals(dr[0], DBNull.Value)))
            {
                t = Convert.ToInt32(dr[0]) + 1;
            }
            else
            {
                t = 1;
            }
            l = t;
            dr.Close();
            if (c > d & c > k & c > l)
            {
                BookingNo.Text = c.ToString();
            }
            else if (d > c & d > k & d > l)
            {
                BookingNo.Text = d.ToString();
            }
            else if (k > c & k > d & k > l)
            {
                BookingNo.Text = k.ToString();
            }
            else if (l > c & l > d & l > k)
            {
                BookingNo.Text = l.ToString();
            }
            else
            {
                BookingNo.Text = "1";
            }
            dr.Close();
            con.Close();
        }

        private void Rno_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("Select Arrivaltime,Departuretime,Startingpoint,Destination From Route Where Rno=" + Rno.Text + "", con);
            dr = cmd.ExecuteReader();

            dr.Read();
            Arrivaltime.Text = Convert.ToString(dr.GetValue(0));
            Departuretime.Text = Convert.ToString(dr.GetValue(1));
            cmbstartpoint.Text = Convert.ToString(dr.GetValue(2));
            cmbdestination.Text = Convert.ToString(dr.GetValue(3));
            dr.Close();
            cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            b = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            seats = a + b;
            if (Convert.ToInt32(SeatCapacity.Text) == seats)
            {
               // WaitingList.Enabled = True
                Insert.Enabled = false;
            }
            else
            {
               // WaitingList.Enabled = False
                Insert.Enabled = true;
            }
            SA();
            con.Close();
            S1.Text = cmbstartpoint.Text;
            S2.Text = cmbdestination.Text;
        }

        public void Insert_Click(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Rno.Text.Trim()) | Rno.Text.Trim() == "Select")
            {
                MessageBox.Show("Plz.. Enter Correct Route No");
            }
            else if (string.IsNullOrEmpty(BusSerialNo.Text.Trim()) | BusSerialNo.Text.Trim() == "Select")
            {
                MessageBox.Show("Plz Enter Bus Serial No and Press Find");
            }
            else if (RadioButton1.Checked == false & RadioButton2.Checked == false)
            {
                MessageBox.Show("Plz.. Select Seat Type");

            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();

                cmd = new SqlCommand("Insert Into PaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" + BookingNo.Text + ",'" + cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + "0" + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + Strings.Format(Arrivaltime.Value, "hh:mm:ss tt") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success... Next...");
                con.Close();
                Master.getinfos(Rno.Text, BusSerialNo.Text, SeatCapacity.Text, BusReservation.Text);
                if (BusReservation.Text == "1x1" & RadioButton1.Checked == true)
                {              
                    SeatSelectionLower SSL0 = new SeatSelectionLower("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL0.Show();
                }
                if (BusReservation.Text == "1x1" & RadioButton2.Checked == true)
                {
                    SeatSelectionUpper SSL1 = new SeatSelectionUpper("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL1.Show();
                }
                if (BusReservation.Text == "2x1" & RadioButton1.Checked == true)
                {
                    SeatSelectionLower21 SSL3 = new SeatSelectionLower21("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL3.Show();
                }
                if (BusReservation.Text == "2x1" & RadioButton2.Checked == true)
                {
                    SeatSelectionUpper21 SSL4 = new SeatSelectionUpper21("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL4.Show();
                }
                if (BusReservation.Text == "2x2" & RadioButton1.Checked == true)
                {
                    SeatSelectionLower22 SSL5 = new SeatSelectionLower22("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL5.Show();
                }
                if (BusReservation.Text == "2x2" & RadioButton2.Checked == true)
                {
                    SeatSelectionUpper22 SSL6 = new SeatSelectionUpper22("NA", BookingNo.Text, Rno.Text, BusSerialNo.Text);
                    this.Close();
                    SSL6.Show();
                }
            }
        }

        private void BusSerialNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Rno.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Route No");
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();

                cmd = new SqlCommand("Select BusNo,Type,Reservation,SeatCapacity From Bus Where BusSno=" + BusSerialNo.SelectedItem + "", con);
                dr = cmd.ExecuteReader();

                dr.Read();
                BusNumber.Text = Convert.ToString(dr.GetValue(0));
                BusType.Text = Convert.ToString(dr.GetValue(1));
                BusReservation.Text = Convert.ToString(dr.GetValue(2));
                SeatCapacity.Text = Convert.ToString(dr.GetValue(3));
                dr.Close();
                RadioButton1.Enabled = true;
                RadioButton2.Enabled = true;
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                a = Convert.ToInt32(dr.GetValue(0));
                dr.Close();
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                b = Convert.ToInt32(dr.GetValue(0));
                dr.Close();
                seats = a + b;
                if (Convert.ToInt32(SeatCapacity.Text) == seats)
                {
                   // WaitingList.Enabled = True
                    Insert.Enabled = false;
                }
                else
                {
                  //  WaitingList.Enabled = False
                    Insert.Enabled = true;
                }
                SA();
            }
        }
        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void RadioButton1_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            SA();
        }
        private void RadioButton2_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            SA();
        }
        public void SA()
        {
            if (RadioButton1.Checked == true)
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability.Text = Convert.ToString(dr[0]);
                Label16.Text = "Seat Booked From   20   Seats";
                dr.Close();
                SC2.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability.Text = Convert.ToString(dr[0]);
                Label16.Text = "Seat Booked From   20   Seats";
                dr.Close();
                con.Close();
                SC2.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
            }
        }

        private void WaitingList_Click(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Rno.Text.Trim()) | Rno.Text.Trim() == "Select")
            {
                MessageBox.Show("Plz.. Enter Correct Route No");
            }
            else if (string.IsNullOrEmpty(BusSerialNo.Text.Trim()) | BusSerialNo.Text.Trim() == "Select")
            {
                MessageBox.Show("Plz Enter Bus Serial No and Press Find");
            }
            else if (RadioButton1.Checked == false & RadioButton2.Checked == false)
            {
                MessageBox.Show("Plz.. Select Seat Type");
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select max(WaitingNo) From APaymentPassenger", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if ((!object.ReferenceEquals(dr[0], DBNull.Value)))
                {
                    t = Convert.ToInt32(dr[0]) + 1;
                }
                else
                {
                    t = 1;
                }
                WNo.Text = t.ToString();
                dr.Close();
                cmd = new SqlCommand("Insert Into APaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" + BookingNo.Text + ",'" + cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + WNo.Text + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + Strings.Format(Arrivaltime.Value, "hh:mm:ss tt") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success... Next");
                con.Close();
                this.Close();
                Booking_And_Passenger ABPassenger = new Booking_And_Passenger("AB_UN", "L/U", "WL");
                ABPassenger.Show();
            }
        }
        public SeatBooking()
        {
            Load += SeatBooking_Load;
            InitializeComponent();
        }

    }
}
