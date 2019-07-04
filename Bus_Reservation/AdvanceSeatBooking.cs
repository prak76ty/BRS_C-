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

    public partial class AdvanceSeatBooking : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int t;
        int a;
        int b;
        int seats;
        int c;
        int d;
        int k;
        int l;

        string new22;
        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void AB_Click(System.Object sender, System.EventArgs e)
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
                New2.Text = "AB_UN";
                dr.Close();
                cmd = new SqlCommand("Insert Into APaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" + BookingNo.Text + ",'" + cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text + "','" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "','" + "0" + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + Strings.Format(Arrivaltime.Value, "hh:mm:ss tt") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success... Next...");
                con.Close();
                if (RadioButton1.Checked == true)
                {
                    new22 = "L";
                }
                if (RadioButton2.Checked == true)
                {
                    new22 = "U";
                }
                Master.getinfoA(Rno.Text,BusSerialNo.Text,SeatCapacity.Text,BusReservation.Text);
                Booking_And_Passenger ABPassenger = new Booking_And_Passenger("AB_UN", new22, "0");
                this.Close();
                ABPassenger.Show();
            }
        }

        private void btnclear_Click(System.Object sender, System.EventArgs e)
        {
            Rno.Text = "Select";
            cmbstartpoint.Text = "Select";
            cmbdestination.Text = "Select";
            BusSerialNo.Text = "Select";
            BusNumber.Text = "Select";
            BusType.Text = "Select";
            BusReservation.Text = "Select";
            Arrivaltime.Value = Convert.ToDateTime(DateAndTime.TimeOfDay);
            Departuretime.Value = Convert.ToDateTime(DateAndTime.TimeOfDay);
            SeatCapacity.Clear();
            S1.Clear();
            S2.Clear();
            SeatAvailability2.Clear();
            SC3.Clear();
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
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                a = Convert.ToInt32(dr.GetValue(0));
                dr.Close();
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                b = Convert.ToInt32(dr.GetValue(0));
                dr.Close();
                con.Close();
                seats = a + b;
                if (Convert.ToInt32(SeatCapacity.Text) == seats)
                {
                    //WaitingList.Enabled = True;
                    AB.Enabled = false;
                }
                else
                {
                    //WaitingList.Enabled = False;
                    AB.Enabled = true;
                }
                SA();
            }
        }

        private void Rno_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Arrivaltime,Departuretime,Startingpoint,Destination From Route Where Rno=" + Rno.SelectedItem + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Arrivaltime.Text = Convert.ToString(dr.GetValue(0));
            Departuretime.Text = Convert.ToString(dr.GetValue(1));
            cmbstartpoint.Text = Convert.ToString(dr.GetValue(2));
            cmbdestination.Text = Convert.ToString(dr.GetValue(3));
            dr.Close();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            b = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            con.Close();
            seats = a + b;
            if (Convert.ToInt32(SeatCapacity.Text) == seats)
            {
                // WaitingList.Enabled = True
                AB.Enabled = false;
            }
            else
            {
                // WaitingList.Enabled = False
                AB.Enabled = true;
            }
            SA();
            con.Close();
            S1.Text = cmbstartpoint.Text;
            S2.Text = cmbdestination.Text;
        }

        private void AdvanceSeatBooking_Load(System.Object sender, System.EventArgs e)
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
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability2.Text = Convert.ToString(dr[0]);
                Label19.Text = "Seat Booked From   20   Seats";
                dr.Close();
                SC3.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability2.Text = Convert.ToString(dr[0]);
                Label19.Text = "Seat Booked From   20   Seats";
                dr.Close();
                con.Close();
                SC3.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
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
                cmd = new SqlCommand("Insert Into APaymentPassenger(BookingNo,RouteBus,BookingDate,WaitingNo,CurrentDate,ArrivalTime) Values(" + BookingNo.Text + ",'" + cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text + "','" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "','" + WNo.Text + "','" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "','" + Strings.Format(Arrivaltime.Value, "hh:mm:ss tt") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success... Next");
                con.Close();
                this.Close();
                Booking_And_Passenger ABPassenger = new Booking_And_Passenger("AB_UN", "L/U", "WL");
                ABPassenger.Show();
             
            }
        }

        private void BookingDate_ValueChanged(System.Object sender, System.EventArgs e)
        {
            SA();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + Rno.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            b = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            con.Close();
            seats = a + b;
            if (Convert.ToInt32(SeatCapacity.Text) == seats)
            {
                // WaitingList.Enabled = True
                AB.Enabled = false;
            }
            else
            {
                // WaitingList.Enabled = False
                AB.Enabled = true;
            }
        }
        public AdvanceSeatBooking()
        {
            Load += AdvanceSeatBooking_Load;
            InitializeComponent();
        }
    }
}
