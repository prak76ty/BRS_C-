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

    public partial class WaitingList : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int t;
        int CN;
        int a;
        int b;
        int seats;
        int i;
        string RN;

        string BN;
        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(BookingNo.Text.Trim()))
                {
                    MessageBox.Show("Booking No is Empty..");
                }
                else
                {
                    DGV.Rows.Clear();
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Select * From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
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
                        DGV[7, i].Value = Convert.ToString(dr.GetValue(7));
                        DGV[8, i].Value = Convert.ToString(dr.GetValue(8));
                        DGV[9, i].Value = Convert.ToString(dr.GetValue(9));
                        i += 1;
                    }
                    dr.Close();
                    RNo.Enabled = true;
                    BusSerialNo.Enabled = true;
                    SeatCapacity.Text = "40";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Foundor Or " + ex.Message);
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                RNo.Enabled = false;
                BusSerialNo.Enabled = false;
            }
        }

        private void Ending_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DGV.Rows.Clear();
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * From APaymentPassenger Where BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "' and Not WaitingNo='" + "0" + "'", con);
                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    DGV.Rows.Add();
                    DGV[0, i].Value = Convert.ToString(dr.GetValue(0));
                    DGV[1, i].Value = Convert.ToString(dr.GetValue(1));
                    DGV[2, i].Value = Convert.ToString(dr.GetValue(2));
                    DGV[3, i].Value = Convert.ToString(dr.GetValue(3));
                    DGV[4, i].Value = Convert.ToString(dr.GetValue(4));
                    DGV[5, i].Value = Convert.ToString(dr.GetValue(5));
                    DGV[6, i].Value = Convert.ToString(dr.GetValue(6));
                    DGV[7, i].Value = Convert.ToString(dr.GetValue(7));
                    DGV[8, i].Value = Convert.ToString(dr.GetValue(8));
                    DGV[9, i].Value = Convert.ToString(dr.GetValue(9));
                    i += 1;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Foundor or " + ex.Message);
            }
        }
        private void RadioButton1_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            SA();
        }

        private void RadioButton2_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            SA();
        }

        private void Proceed_Click(System.Object sender, System.EventArgs e)
		{
			try {
				CN = Convert.ToInt32(BookingNo.Text);
				if (string.IsNullOrEmpty(BookingNo.Text.Trim())) {
					MessageBox.Show("Plz.. Enter Booking No..");
				} else if (RadioButton1.Checked == false & RadioButton2.Checked == false) {
					MessageBox.Show("Plz.. Select Seat Section..");
				} else {
					DialogResult res = MessageBox.Show("Do U Want To Allocate Seat To Waiting Booking?", "Allocate Seat?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (res == DialogResult.Yes) {
						RN = RNo.Text;
						BN = BusSerialNo.Text;
						con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
						con.Open();
						cmd = new SqlCommand("Update APaymentPassenger Set RouteBus='" + cmbstartpoint.Text + " To " + cmbdestination.Text + " " + BusNumber.Text + "',CurrentDate='" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "',ArrivalTime='" + Strings.Format(Arrivaltime.Value, "hh:mm:ss tt") + "'Where BookingNo=" + BookingNo.Text + "", con);
						cmd.ExecuteNonQuery();
						//this.Hide();
                        if (BusReservation.Text == "1x1" & RadioButton1.Checked == true)
                        {
                            SeatSelectionLower SSL = new SeatSelectionLower("AB_UN", CN, RN, BN);
                            this.Close();
                            SSL.Show();
                            SSL.BringToFront();
                        }
                        if (BusReservation.Text == "1x1" & RadioButton2.Checked == true)
                        {
                            SeatSelectionUpper SSU = new SeatSelectionUpper("AB_UN", CN, RN, BN);
                            this.Close();
                            SSU.Show();
                            SSU.BringToFront();
                        }
                        if (BusReservation.Text == "2x1" & RadioButton1.Checked == true)
                        {
                            SeatSelectionLower21 SSL1 = new SeatSelectionLower21("AB_UN", CN, RN, BN);
                            this.Close();
                            SSL1.Show();
                            SSL1.BringToFront();
                        }
                        if (BusReservation.Text == "2x1" & RadioButton2.Checked == true)
                        {
                            SeatSelectionUpper21 SSU1 = new SeatSelectionUpper21("AB_UN", CN, RN, BN);
                            this.Close();
                            SSU1.Show();
                            SSU1.BringToFront();
                        }
                        if (BusReservation.Text == "2x2" & RadioButton1.Checked == true)
                        {
                            SeatSelectionLower22 SSL2 = new SeatSelectionLower22("AB_UN", CN, RN, BN);
                            this.Close();
                            SSL2.Show();
                            SSL2.BringToFront();
                        }
                        if (BusReservation.Text == "2x2" & RadioButton2.Checked == true)
                        {
                            SeatSelectionUpper21 SSU2 = new SeatSelectionUpper21("AB_UN", CN, RN, BN);
                            this.Close();
                            SSU2.Show();
                            SSU2.BringToFront();
                        }
                        //this.Close();
					}
				}
			} catch (Exception ex) {
                MessageBox.Show("Nothing Selected.. Plz Select Correct Booking No.. Or " + ex.Message);
			}
		}

        private void Button4_Click(System.Object sender, System.EventArgs e)
        {
            DGV.Rows.Clear();
            SeatCapacity.Clear();
            BookingNo.Clear();
            SC2.Clear();
            SeatAvailability.Clear();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RNo.Text = "Select";
            BusSerialNo.Text = "Select";
        }

        private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			//Try
			DialogResult res = MessageBox.Show("Do U Want To Cancel Waiting Booking?", "Cancel Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (res == DialogResult.Yes) {
				if (string.IsNullOrEmpty(BookingNo.Text.Trim())) {
					MessageBox.Show("Give Booking No..");
				} else {
					string CN2 = null;
					con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
					con.Open();
					cmd = new SqlCommand("Select max(CancellationNo) From Cancellation", con);
					dr = cmd.ExecuteReader();
					dr.Read();
					if ((!object.ReferenceEquals(dr[0], DBNull.Value))) {
						t = Convert.ToInt32(dr[0]) + 1;
					} else {
						t = 1;
					}
					CN2 = t.ToString();
					dr.Close();
					cmd = new SqlCommand("Select * From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
					dr = cmd.ExecuteReader();
					dr.Read();
					string a1 = null;
					string a2 = null;
					string a3 = null;
					string a4 = null;
					string a5 = null;
					string a6 = null;
					string a7 = null;
					a1 = dr.GetValue(0).ToString();
                    a2 = dr.GetValue(1).ToString();
                    a3 = dr.GetValue(2).ToString();
                    a4 = dr.GetValue(6).ToString();
                    a5 = dr.GetValue(7).ToString();
                    a6 = dr.GetValue(8).ToString();
                    a7 = dr.GetValue(9).ToString();
					dr.Close();
					cmd = new SqlCommand("Insert Into Cancellation Values(" + CN2 + ",'" + a1 + "','" + a2 + "','" + a3 + "','" + DateAndTime.Today + " " + DateAndTime.TimeOfDay + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7 + "','" + Strings.Format(Arrivaltime.Value, "hh:MM:ss tt") + "')", con);
					cmd.ExecuteNonQuery();
					cmd = new SqlCommand("Delete From APassengerDetails Where BookingNo=" + BookingNo.Text + "", con);
					cmd.ExecuteNonQuery();
					cmd = new SqlCommand("Delete From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Done");
					con.Close();
					DGV.Rows.Clear();
					SeatCapacity.Clear();
					BookingNo.Clear();
					SC2.Clear();
					SeatAvailability.Clear();
					RadioButton1.Checked = false;
					RadioButton2.Checked = false;
				}
			} else {
				MessageBox.Show("Not Cancelled");
			}
			//Catch ex As Exception
			//    MsgBox("Nothing Selected..!")
			//End Try
		}

        private void WaitingList_Load(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Distinct(Rno) From Route", con);
            dr = cmd.ExecuteReader();
            RNo.Items.Clear();
            while (dr.Read())
            {
                RNo.Items.Add(Convert.ToString(dr.GetValue(0)));
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
        }

        private void RNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Arrivaltime,Departuretime,Startingpoint,Destination From Route Where Rno=" + RNo.SelectedItem + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Arrivaltime.Text = Convert.ToString(dr.GetValue(0));
            Departuretime.Text = Convert.ToString(dr.GetValue(1));
            cmbstartpoint.Text = Convert.ToString(dr.GetValue(2));
            cmbdestination.Text = Convert.ToString(dr.GetValue(3));
            dr.Close();
            con.Close();
            SA();
        }

        private void BusSerialNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(RNo.Text.Trim()))
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
                con.Close();
                RadioButton1.Enabled = true;
                RadioButton2.Enabled = true;
                SA();
            }
        }
        public void SA()
        {
            if (RadioButton1.Checked == true)
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate=" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability.Text = dr[0].ToString();
                Label16.Text = "Seat Booked From   20   Seats";
                dr.Close();
                SC2.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (BookingDate.Value == DateAndTime.Today)
                {
                    cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate=" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "", con);
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                SeatAvailability.Text = dr[0].ToString();
                Label16.Text = "Seat Booked From   20   Seats";
                dr.Close();
                con.Close();
                SC2.Text = Convert.ToString(Convert.ToInt32(SeatCapacity.Text) / 2);
            }
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "L" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "L" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            if (BookingDate.Value == DateAndTime.Today)
            {
                cmd = new SqlCommand("Select count(SeatNo) From PassengerDetails where SeatType='" + "U" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select count(SeatNo) From APassengerDetails where SeatType='" + "U" + "' and RouteNo='" + RNo.Text + "' and BusSno='" + BusSerialNo.Text + "' and BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            b = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            con.Close();
            seats = a + b;
            if (Convert.ToInt32(SeatCapacity.Text) == seats)
            {
                Proceed.Enabled = false;
            }
            else
            {
                Proceed.Enabled = true;
            }
            
        }
        public WaitingList()
        {
            Load += WaitingList_Load;
            InitializeComponent();
        }
    }
}
