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
    public partial class AdvanceBookingCancellation : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int t;
        int PK;
        int FAD;
        int ADA;
        int Z;
        string Rno;
        string BNo2;
        string SType;
        string Sr;
        string Pname;
        string Pgender;
        string Page;
        string l;
        string m;
        string n;
        string o;
        private void BNo_Click(System.Object sender, System.EventArgs e)
        {
            clearall();
            try
            {
                if (string.IsNullOrEmpty(BNo.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter Correct Booking No");
                }
                else
                {
                    info();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found Or " + ex.Message);
            }
        }
        private void BName_Click(System.Object sender, System.EventArgs e)
        {
            clearall();
            try
            {
                if (string.IsNullOrEmpty(BookedName1.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter Correct Booking No");
                }
                else
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Select * From APaymentPassenger Where PassengerName='" + BookedName1.Text + "' and BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    BookingNo.Text = Convert.ToString(dr.GetValue(0));
                    BookingNo1.Text = Convert.ToString(dr.GetValue(0));
                    dr.Close();
                    info();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found Or " + ex.Message);
            }
        }
        private void Button4_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(System.Object sender, System.EventArgs e)
        {
            BookingNo1.Clear();
            ST1.Text = "";
            SeatNo1.Clear();
            BookedName1.Clear();
            BookingNo.Clear();
            S1.Clear();
            S2.Clear();
            BBName.Clear();
            PaymentBy.Text = "";
            Bcontact.Clear();
            BNumber2.Clear();
            BReservation.Clear();
            clearall();
        }
        public void info()
        {
            PK = 4;
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select * From APaymentPassenger Where BookingNo=" + BookingNo1.Text + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            BookingNo.Text = Convert.ToString(dr.GetValue(0));
            BDate.Value = Convert.ToDateTime(dr.GetValue(2));
            BBName.Text = Convert.ToString(dr.GetValue(6));
            BookedName1.Text = Convert.ToString(dr.GetValue(6));
            Bcontact.Text = Convert.ToString(dr.GetValue(8));
            //BTime.Text = Convert.ToString(dr.GetValue(14));
            dr.Close();

            cmd = new SqlCommand("Select * From APassengerDetails Where BookingNo=" + BookingNo1.Text + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Rno = Convert.ToString(dr.GetValue(1));
            BNo2 = Convert.ToString(dr.GetValue(2));
            PaymentBy.Text = Convert.ToString(dr.GetValue(10));
            dr.Close();
            cmd = new SqlCommand("Select * From Route Where Rno=" + Rno + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            S1.Text = Convert.ToString(dr.GetValue(4));
            S2.Text = Convert.ToString(dr.GetValue(5));
            dr.Close();
            cmd = new SqlCommand("Select * From Bus Where BusSno=" + BNo2 + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            BNumber2.Text = Convert.ToString(dr.GetValue(1));
            BReservation.Text = Convert.ToString(dr.GetValue(4));
            dr.Close();

            checkvisibility();
            CheckSeats();
            con.Close();
        }
        public void CheckSeats()
        {
            string check = null;
            string SeatType = null;
            SeatType = "L";
            if (SeatType == "L")
            {
                check = "1";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox1.Enabled = true;
                    CheckBox1.Checked = true;
                }
                dr.Close();
                check = "2";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox2.Enabled = true;
                    CheckBox2.Checked = true;
                }
                dr.Close();
                check = "3";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox3.Enabled = true;
                    CheckBox3.Checked = true;
                }
                dr.Close();
                check = "4";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox4.Enabled = true;
                    CheckBox4.Checked = true;
                }
                dr.Close();
                check = "5";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox5.Enabled = true;
                    CheckBox5.Checked = true;
                }
                dr.Close();
                check = "6";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox6.Enabled = true;
                    CheckBox6.Checked = true;
                }
                dr.Close();
                check = "7";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox7.Enabled = true;
                    CheckBox7.Checked = true;
                }
                dr.Close();
                check = "8";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox8.Enabled = true;
                    CheckBox8.Checked = true;
                }
                dr.Close();
                check = "9";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox9.Enabled = true;
                    CheckBox9.Checked = true;
                }
                dr.Close();
                check = "10";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox10.Enabled = true;
                    CheckBox10.Checked = true;
                }
                dr.Close();
                check = "11";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox11.Enabled = true;
                    CheckBox11.Checked = true;
                }
                dr.Close();
                check = "12";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox12.Enabled = true;
                    CheckBox12.Checked = true;
                }
                dr.Close();
                check = "13";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox13.Enabled = true;
                    CheckBox13.Checked = true;
                }
                dr.Close();
                check = "14";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox14.Enabled = true;
                    CheckBox14.Checked = true;
                }
                dr.Close();
                check = "15";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox15.Enabled = true;
                    CheckBox15.Checked = true;
                }
                dr.Close();
                check = "16";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox16.Enabled = true;
                    CheckBox16.Checked = true;
                }
                dr.Close();
                check = "17";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox17.Enabled = true;
                    CheckBox17.Checked = true;
                }
                dr.Close();
                check = "18";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox18.Enabled = true;
                    CheckBox18.Checked = true;
                }
                dr.Close();
                check = "19";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox19.Enabled = true;
                    CheckBox19.Checked = true;
                }
                dr.Close();
                check = "20";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox20.Enabled = true;
                    CheckBox20.Checked = true;
                }
                dr.Close();
                check = "21";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox21.Enabled = true;
                    CheckBox21.Checked = true;
                }
                dr.Close();
                check = "22";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox22.Enabled = true;
                    CheckBox22.Checked = true;
                }
                dr.Close();
                check = "23";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox23.Enabled = true;
                    CheckBox23.Checked = true;
                }
                dr.Close();
                check = "24";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox24.Enabled = true;
                    CheckBox24.Checked = true;
                }
                dr.Close();
                check = "25";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox25.Enabled = true;
                    CheckBox25.Checked = true;
                }
                dr.Close();
                check = "26";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox26.Enabled = true;
                    CheckBox26.Checked = true;
                }
                dr.Close();
                check = "27";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox27.Enabled = true;
                    CheckBox27.Checked = true;
                }
                dr.Close();
                check = "28";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox28.Enabled = true;
                    CheckBox28.Checked = true;
                }
                dr.Close();
                check = "29";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox29.Enabled = true;
                    CheckBox29.Checked = true;
                }
                dr.Close();
                check = "30";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox30.Enabled = true;
                    CheckBox30.Checked = true;
                }
                dr.Close();
                check = "31";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox31.Enabled = true;
                    CheckBox31.Checked = true;
                }
                dr.Close();
                check = "32";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox32.Enabled = true;
                    CheckBox32.Checked = true;
                }
                dr.Close();
                check = "33";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox33.Enabled = true;
                    CheckBox33.Checked = true;
                }
                dr.Close();
                check = "34";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox34.Enabled = true;
                    CheckBox34.Checked = true;
                }
                dr.Close();
                check = "35";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox35.Enabled = true;
                    CheckBox35.Checked = true;
                }
                dr.Close();
                check = "36";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox36.Enabled = true;
                    CheckBox36.Checked = true;
                }
                dr.Close();
                check = "37";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox37.Enabled = true;
                    CheckBox37.Checked = true;
                }
                dr.Close();
                check = "38";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox38.Enabled = true;
                    CheckBox38.Checked = true;
                }
                dr.Close();
                check = "39";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox39.Enabled = true;
                    CheckBox39.Checked = true;
                }
                dr.Close();
                check = "40";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox40.Enabled = true;
                    CheckBox40.Checked = true;
                }
                dr.Close();
            }
            SeatType = "U";
            if (SeatType == "U")
            {
                check = "1";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox80.Enabled = true;
                    CheckBox80.Checked = true;
                }
                dr.Close();
                check = "2";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox79.Enabled = true;
                    CheckBox79.Checked = true;
                }
                dr.Close();
                check = "3";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox78.Enabled = true;
                    CheckBox78.Checked = true;
                }
                dr.Close();
                check = "4";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox77.Enabled = true;
                    CheckBox77.Checked = true;
                }
                dr.Close();
                check = "5";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox76.Enabled = true;
                    CheckBox76.Checked = true;
                }
                dr.Close();
                check = "6";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox75.Enabled = true;
                    CheckBox75.Checked = true;
                }
                dr.Close();
                check = "7";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox74.Enabled = true;
                    CheckBox74.Checked = true;
                }
                dr.Close();
                check = "8";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox73.Enabled = true;
                    CheckBox73.Checked = true;
                }
                dr.Close();
                check = "9";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox72.Enabled = true;
                    CheckBox72.Checked = true;
                }
                dr.Close();
                check = "10";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox71.Enabled = true;
                    CheckBox71.Checked = true;
                }
                dr.Close();
                check = "11";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox70.Enabled = true;
                    CheckBox70.Checked = true;
                }
                dr.Close();
                check = "12";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox69.Enabled = true;
                    CheckBox69.Checked = true;
                }
                dr.Close();
                check = "13";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox68.Enabled = true;
                    CheckBox68.Checked = true;
                }
                dr.Close();
                check = "14";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox67.Enabled = true;
                    CheckBox67.Checked = true;
                }
                dr.Close();
                check = "15";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox66.Enabled = true;
                    CheckBox66.Checked = true;
                }
                dr.Close();
                check = "16";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox65.Enabled = true;
                    CheckBox65.Checked = true;
                }
                dr.Close();
                check = "17";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox64.Enabled = true;
                    CheckBox64.Checked = true;
                }
                dr.Close();
                check = "18";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox63.Enabled = true;
                    CheckBox63.Checked = true;
                }
                dr.Close();
                check = "19";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox62.Enabled = true;
                    CheckBox62.Checked = true;
                }
                dr.Close();
                check = "20";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox61.Enabled = true;
                    CheckBox61.Checked = true;
                }
                dr.Close();
                check = "21";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox60.Enabled = true;
                    CheckBox60.Checked = true;
                }
                dr.Close();
                check = "22";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox59.Enabled = true;
                    CheckBox59.Checked = true;
                }
                dr.Close();
                check = "23";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox58.Enabled = true;
                    CheckBox58.Checked = true;
                }
                dr.Close();
                check = "24";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox57.Enabled = true;
                    CheckBox57.Checked = true;
                }
                dr.Close();
                check = "25";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox56.Enabled = true;
                    CheckBox56.Checked = true;
                }
                dr.Close();
                check = "26";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox55.Enabled = true;
                    CheckBox55.Checked = true;
                }
                dr.Close();
                check = "27";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox54.Enabled = true;
                    CheckBox54.Checked = true;
                }
                dr.Close();
                check = "28";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox53.Enabled = true;
                    CheckBox53.Checked = true;
                }
                dr.Close();
                check = "29";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox52.Enabled = true;
                    CheckBox52.Checked = true;
                }
                dr.Close();
                check = "30";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox51.Enabled = true;
                    CheckBox51.Checked = true;
                }
                dr.Close();
                check = "31";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox50.Enabled = true;
                    CheckBox50.Checked = true;
                }
                dr.Close();
                check = "32";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox49.Enabled = true;
                    CheckBox49.Checked = true;
                }
                dr.Close();
                check = "33";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox48.Enabled = true;
                    CheckBox48.Checked = true;
                }
                dr.Close();
                check = "34";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox47.Enabled = true;
                    CheckBox47.Checked = true;
                }
                dr.Close();
                check = "35";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox46.Enabled = true;
                    CheckBox46.Checked = true;
                }
                dr.Close();
                check = "36";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox45.Enabled = true;
                    CheckBox45.Checked = true;
                }
                dr.Close();
                check = "37";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox44.Enabled = true;
                    CheckBox44.Checked = true;
                }
                dr.Close();
                check = "38";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox43.Enabled = true;
                    CheckBox43.Checked = true;
                }
                dr.Close();
                check = "39";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox42.Enabled = true;
                    CheckBox42.Checked = true;
                }
                dr.Close();
                check = "40";
                cmd = new SqlCommand("Select BookingNo,BDate,SeatNo,SeatType From APassengerDetails where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SeatType + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    CheckBox41.Enabled = true;
                    CheckBox41.Checked = true;
                }
                dr.Close();
            }
        }
        public void clearall()
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;
            CheckBox8.Checked = false;
            CheckBox9.Checked = false;
            CheckBox10.Checked = false;
            CheckBox11.Checked = false;
            CheckBox12.Checked = false;
            CheckBox13.Checked = false;
            CheckBox14.Checked = false;
            CheckBox15.Checked = false;
            CheckBox16.Checked = false;
            CheckBox17.Checked = false;
            CheckBox18.Checked = false;
            CheckBox19.Checked = false;
            CheckBox20.Checked = false;
            CheckBox21.Checked = false;
            CheckBox22.Checked = false;
            CheckBox23.Checked = false;
            CheckBox24.Checked = false;
            CheckBox25.Checked = false;
            CheckBox26.Checked = false;
            CheckBox27.Checked = false;
            CheckBox28.Checked = false;
            CheckBox29.Checked = false;
            CheckBox30.Checked = false;
            CheckBox31.Checked = false;
            CheckBox32.Checked = false;
            CheckBox33.Checked = false;
            CheckBox34.Checked = false;
            CheckBox35.Checked = false;
            CheckBox36.Checked = false;
            CheckBox37.Checked = false;
            CheckBox38.Checked = false;
            CheckBox39.Checked = false;
            CheckBox40.Checked = false;
            CheckBox41.Checked = false;
            CheckBox42.Checked = false;
            CheckBox43.Checked = false;
            CheckBox44.Checked = false;
            CheckBox45.Checked = false;
            CheckBox46.Checked = false;
            CheckBox47.Checked = false;
            CheckBox48.Checked = false;
            CheckBox49.Checked = false;
            CheckBox50.Checked = false;
            CheckBox51.Checked = false;
            CheckBox52.Checked = false;
            CheckBox53.Checked = false;
            CheckBox54.Checked = false;
            CheckBox55.Checked = false;
            CheckBox56.Checked = false;
            CheckBox57.Checked = false;
            CheckBox58.Checked = false;
            CheckBox59.Checked = false;
            CheckBox60.Checked = false;
            CheckBox61.Checked = false;
            CheckBox62.Checked = false;
            CheckBox63.Checked = false;
            CheckBox64.Checked = false;
            CheckBox65.Checked = false;
            CheckBox66.Checked = false;
            CheckBox67.Checked = false;
            CheckBox68.Checked = false;
            CheckBox69.Checked = false;
            CheckBox70.Checked = false;
            CheckBox71.Checked = false;
            CheckBox72.Checked = false;
            CheckBox73.Checked = false;
            CheckBox74.Checked = false;
            CheckBox75.Checked = false;
            CheckBox76.Checked = false;
            CheckBox77.Checked = false;
            CheckBox78.Checked = false;
            CheckBox79.Checked = false;
            CheckBox80.Checked = false;
            CheckBox1.Enabled = false;
            CheckBox2.Enabled = false;
            CheckBox3.Enabled = false;
            CheckBox4.Enabled = false;
            CheckBox5.Enabled = false;
            CheckBox6.Enabled = false;
            CheckBox7.Enabled = false;
            CheckBox8.Enabled = false;
            CheckBox9.Enabled = false;
            CheckBox10.Enabled = false;
            CheckBox11.Enabled = false;
            CheckBox12.Enabled = false;
            CheckBox13.Enabled = false;
            CheckBox14.Enabled = false;
            CheckBox15.Enabled = false;
            CheckBox16.Enabled = false;
            CheckBox17.Enabled = false;
            CheckBox18.Enabled = false;
            CheckBox19.Enabled = false;
            CheckBox20.Enabled = false;
            CheckBox21.Enabled = false;
            CheckBox22.Enabled = false;
            CheckBox23.Enabled = false;
            CheckBox24.Enabled = false;
            CheckBox25.Enabled = false;
            CheckBox26.Enabled = false;
            CheckBox27.Enabled = false;
            CheckBox28.Enabled = false;
            CheckBox29.Enabled = false;
            CheckBox30.Enabled = false;
            CheckBox31.Enabled = false;
            CheckBox32.Enabled = false;
            CheckBox33.Enabled = false;
            CheckBox34.Enabled = false;
            CheckBox35.Enabled = false;
            CheckBox36.Enabled = false;
            CheckBox37.Enabled = false;
            CheckBox38.Enabled = false;
            CheckBox39.Enabled = false;
            CheckBox40.Enabled = false;
            CheckBox41.Enabled = false;
            CheckBox42.Enabled = false;
            CheckBox43.Enabled = false;
            CheckBox44.Enabled = false;
            CheckBox45.Enabled = false;
            CheckBox46.Enabled = false;
            CheckBox47.Enabled = false;
            CheckBox48.Enabled = false;
            CheckBox49.Enabled = false;
            CheckBox50.Enabled = false;
            CheckBox51.Enabled = false;
            CheckBox52.Enabled = false;
            CheckBox53.Enabled = false;
            CheckBox54.Enabled = false;
            CheckBox55.Enabled = false;
            CheckBox56.Enabled = false;
            CheckBox57.Enabled = false;
            CheckBox58.Enabled = false;
            CheckBox59.Enabled = false;
            CheckBox60.Enabled = false;
            CheckBox61.Enabled = false;
            CheckBox62.Enabled = false;
            CheckBox63.Enabled = false;
            CheckBox64.Enabled = false;
            CheckBox65.Enabled = false;
            CheckBox66.Enabled = false;
            CheckBox67.Enabled = false;
            CheckBox68.Enabled = false;
            CheckBox69.Enabled = false;
            CheckBox70.Enabled = false;
            CheckBox71.Enabled = false;
            CheckBox72.Enabled = false;
            CheckBox73.Enabled = false;
            CheckBox74.Enabled = false;
            CheckBox75.Enabled = false;
            CheckBox76.Enabled = false;
            CheckBox77.Enabled = false;
            CheckBox78.Enabled = false;
            CheckBox79.Enabled = false;
            CheckBox80.Enabled = false;
        }

        private void CB_Click(System.Object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(BookingNo1.Text.Trim())) {
				MessageBox.Show("Plz.. Enter Booking No..");
			} else if (string.IsNullOrEmpty(BookedName1.Text.Trim())) {
				MessageBox.Show("Plz.. Enter Booked By Name..");
			} else if (string.IsNullOrEmpty(CCharges.Text.Trim())) {
				MessageBox.Show("Plz.. Enter Cancellation Charges..");
			} else {
				Z = 0;
				DialogResult res = MessageBox.Show("Do U Want To Cancel Booking?", "Cancel Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (res == DialogResult.Yes) {
					if (CheckBox1.Checked == true) {
						InsertDB(1);
					}
					if (CheckBox2.Checked == true) {
						InsertDB(2);
					}
					if (CheckBox3.Checked == true) {
						InsertDB(3);
					}
					if (CheckBox4.Checked == true) {
						InsertDB(4);
					}
					if (CheckBox5.Checked == true) {
						InsertDB(5);
					}
					if (CheckBox6.Checked == true) {
						InsertDB(6);
					}
					if (CheckBox7.Checked == true) {
						InsertDB(7);
					}
					if (CheckBox8.Checked == true) {
						InsertDB(8);
					}
					if (CheckBox9.Checked == true) {
						InsertDB(9);
					}
					if (CheckBox10.Checked == true) {
						InsertDB(10);
					}
					if (CheckBox11.Checked == true) {
						InsertDB(11);
					}
					if (CheckBox12.Checked == true) {
						InsertDB(12);
					}
					if (CheckBox13.Checked == true) {
						InsertDB(13);
					}
					if (CheckBox14.Checked == true) {
						InsertDB(14);
					}
					if (CheckBox15.Checked == true) {
						InsertDB(15);
					}
					if (CheckBox16.Checked == true) {
						InsertDB(16);
					}
					if (CheckBox17.Checked == true) {
						InsertDB(17);
					}
					if (CheckBox18.Checked == true) {
						InsertDB(18);
					}
					if (CheckBox19.Checked == true) {
						InsertDB(19);
					}
					if (CheckBox20.Checked == true) {
						InsertDB(20);
					}
					if (CheckBox21.Checked == true) {
						InsertDB(21);
					}
					if (CheckBox22.Checked == true) {
						InsertDB(22);
					}
					if (CheckBox23.Checked == true) {
						InsertDB(23);
					}
					if (CheckBox24.Checked == true) {
						InsertDB(24);
					}
					if (CheckBox25.Checked == true) {
						InsertDB(25);
					}
					if (CheckBox26.Checked == true) {
						InsertDB(26);
					}
					if (CheckBox27.Checked == true) {
						InsertDB(27);
					}
					if (CheckBox28.Checked == true) {
						InsertDB(28);
					}
					if (CheckBox29.Checked == true) {
						InsertDB(29);
					}
					if (CheckBox30.Checked == true) {
						InsertDB(30);
					}
					if (CheckBox31.Checked == true) {
						InsertDB(31);
					}
					if (CheckBox32.Checked == true) {
						InsertDB(32);
					}
					if (CheckBox33.Checked == true) {
						InsertDB(33);
					}
					if (CheckBox34.Checked == true) {
						InsertDB(34);
					}
					if (CheckBox35.Checked == true) {
						InsertDB(35);
					}
					if (CheckBox36.Checked == true) {
						InsertDB(36);
					}
					if (CheckBox37.Checked == true) {
						InsertDB(37);
					}
					if (CheckBox38.Checked == true) {
						InsertDB(38);
					}
					if (CheckBox39.Checked == true) {
						InsertDB(39);
					}
					if (CheckBox40.Checked == true) {
						InsertDB(40);
					}
					if (CheckBox41.Checked == true) {
						InsertDB(40);
					}
					if (CheckBox42.Checked == true) {
						InsertDB(39);
					}
					if (CheckBox43.Checked == true) {
						InsertDB(38);
					}
					if (CheckBox44.Checked == true) {
						InsertDB(37);
					}
					if (CheckBox45.Checked == true) {
						InsertDB(36);
					}
					if (CheckBox46.Checked == true) {
						InsertDB(35);
					}
					if (CheckBox47.Checked == true) {
						InsertDB(34);
					}
					if (CheckBox48.Checked == true) {
						InsertDB(33);
					}
					if (CheckBox49.Checked == true) {
						InsertDB(32);
					}
					if (CheckBox50.Checked == true) {
						InsertDB(31);
					}
					if (CheckBox51.Checked == true) {
						InsertDB(30);
					}
					if (CheckBox52.Checked == true) {
						InsertDB(29);
					}
					if (CheckBox53.Checked == true) {
						InsertDB(28);
					}
					if (CheckBox54.Checked == true) {
						InsertDB(27);
					}
					if (CheckBox55.Checked == true) {
						InsertDB(26);
					}
					if (CheckBox56.Checked == true) {
						InsertDB(25);
					}
					if (CheckBox57.Checked == true) {
						InsertDB(24);
					}
					if (CheckBox58.Checked == true) {
						InsertDB(23);
					}
					if (CheckBox59.Checked == true) {
						InsertDB(22);
					}
					if (CheckBox60.Checked == true) {
						InsertDB(21);
					}
					if (CheckBox61.Checked == true) {
						InsertDB(20);
					}
					if (CheckBox62.Checked == true) {
						InsertDB(19);
					}
					if (CheckBox63.Checked == true) {
						InsertDB(18);
					}
					if (CheckBox64.Checked == true) {
						InsertDB(17);
					}
					if (CheckBox65.Checked == true) {
						InsertDB(16);
					}
					if (CheckBox66.Checked == true) {
						InsertDB(15);
					}
					if (CheckBox67.Checked == true) {
						InsertDB(14);
					}
					if (CheckBox68.Checked == true) {
						InsertDB(13);
					}
					if (CheckBox69.Checked == true) {
						InsertDB(12);
					}
					if (CheckBox70.Checked == true) {
						InsertDB(11);
					}
					if (CheckBox71.Checked == true) {
						InsertDB(10);
					}
					if (CheckBox72.Checked == true) {
						InsertDB(9);
					}
					if (CheckBox73.Checked == true) {
						InsertDB(8);
					}
					if (CheckBox74.Checked == true) {
						InsertDB(7);
					}
					if (CheckBox75.Checked == true) {
						InsertDB(6);
					}
					if (CheckBox76.Checked == true) {
						InsertDB(5);
					}
					if (CheckBox77.Checked == true) {
						InsertDB(4);
					}
					if (CheckBox78.Checked == true) {
						InsertDB(3);
					}
					if (CheckBox79.Checked == true) {
						InsertDB(2);
					}
					if (CheckBox80.Checked == true) {
						InsertDB(1);
					}
					try {
						string BNO1 = null;
						con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
						con.Open();
						cmd = new SqlCommand("Select * From APassengerDetails Where BookingNo=" + BookingNo1.Text + " and BDate='" + Strings.Format(BDate.Value, "dd/MM/yyyy") + "'", con);
						dr = cmd.ExecuteReader();
						dr.Read();
						BNO1 = Convert.ToString(dr.GetValue(0));
						dr.Close();
						con.Close();
						if (Z != 0) {
							MessageBox.Show("Booked Seat Cancelled");
						} else {
							MessageBox.Show("No Seat Cancelled");
						}
					} catch (Exception ex) {
						con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
						con.Open();
						cmd = new SqlCommand("Delete From APaymentPassenger Where BookingNo=" + BookingNo1.Text + "", con);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Full Booking Cancelled");
                        string a = ex.ToString();
						con.Close();
					}
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
					CNumber.Text = t.ToString();
					dr.Close();
					con.Close();
					BookingNo1.Clear();
					ST1.Text = "";
					SeatNo1.Clear();
					BookedName1.Clear();
					BookingNo.Clear();
					S1.Clear();
					S2.Clear();
					BBName.Clear();
					PaymentBy.Text = "";
					Bcontact.Clear();
					BNumber2.Clear();
					BReservation.Clear();
					clearall();
				} else {
					MessageBox.Show("No Booking Cancelled");
				}
			}
		}
        public void checkvisibility()
        {
            if (BReservation.Text == "2x1")
            {
                CheckBox21.Visible = true;
                CheckBox22.Visible = true;
                CheckBox23.Visible = true;
                CheckBox24.Visible = true;
                CheckBox25.Visible = true;
                CheckBox26.Visible = true;
                CheckBox27.Visible = true;
                CheckBox28.Visible = true;
                CheckBox29.Visible = true;
                CheckBox30.Visible = true;
                CheckBox51.Visible = true;
                CheckBox52.Visible = true;
                CheckBox53.Visible = true;
                CheckBox54.Visible = true;
                CheckBox55.Visible = true;
                CheckBox56.Visible = true;
                CheckBox57.Visible = true;
                CheckBox58.Visible = true;
                CheckBox59.Visible = true;
                CheckBox60.Visible = true;
            }
            if (BReservation.Text == "2x2")
            {
                CheckBox21.Visible = true;
                CheckBox22.Visible = true;
                CheckBox23.Visible = true;
                CheckBox24.Visible = true;
                CheckBox25.Visible = true;
                CheckBox26.Visible = true;
                CheckBox27.Visible = true;
                CheckBox28.Visible = true;
                CheckBox29.Visible = true;
                CheckBox30.Visible = true;
                CheckBox51.Visible = true;
                CheckBox52.Visible = true;
                CheckBox53.Visible = true;
                CheckBox54.Visible = true;
                CheckBox55.Visible = true;
                CheckBox56.Visible = true;
                CheckBox57.Visible = true;
                CheckBox58.Visible = true;
                CheckBox59.Visible = true;
                CheckBox60.Visible = true;
                CheckBox31.Visible = true;
                CheckBox32.Visible = true;
                CheckBox33.Visible = true;
                CheckBox34.Visible = true;
                CheckBox35.Visible = true;
                CheckBox36.Visible = true;
                CheckBox37.Visible = true;
                CheckBox38.Visible = true;
                CheckBox39.Visible = true;
                CheckBox40.Visible = true;
                CheckBox41.Visible = true;
                CheckBox42.Visible = true;
                CheckBox43.Visible = true;
                CheckBox44.Visible = true;
                CheckBox45.Visible = true;
                CheckBox46.Visible = true;
                CheckBox47.Visible = true;
                CheckBox48.Visible = true;
                CheckBox49.Visible = true;
                CheckBox50.Visible = true;
            }
        }
        public void InsertDB(int SN)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select * From APassengerDetails Where BookingNo=" + BookingNo1.Text + " and SeatNo='" + SN + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Rno = Convert.ToString(dr.GetValue(1));
            BNo2 = Convert.ToString(dr.GetValue(2));
            Sr = Convert.ToString(dr.GetValue(3));
            Pname = Convert.ToString(dr.GetValue(4));
            Pgender = Convert.ToString(dr.GetValue(5));
            Page = Convert.ToString(dr.GetValue(6));
            SType = Convert.ToString(dr.GetValue(8));
            FAD = Convert.ToInt32(dr.GetValue(9));
            dr.Close();
            ADA = FAD - Convert.ToInt32(CCharges.Text);
            SB(PK);
            cmd = new SqlCommand("Insert Into CancellationPassenger Values(" + CNumber.Text + ",'" + BookingNo.Text + "','" + Rno + "','" + BNo2 + "','" + Sr + "','" + Pname + "','" + Pgender + "','" + Page + "','" + SN + "','" + SType + "','" + FAD + "','" + CCharges.Text + "','" + ADA + "','" + BDate.Value + "','" + PaymentBy.Text + "')", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Delete From APassengerDetails Where BookingNo=" + BookingNo.Text + " and SEATNO='" + SN + "' and SeatType='" + SType + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Z = Z + 1;
        }
        public void SB(int x)
        {
            if (x == 4)
            {
                cmd = new SqlCommand("Select * From APaymentPassenger Where BookingNo=" + BookingNo1.Text + "", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                l = Convert.ToString(dr.GetValue(1));
                m = Convert.ToString(dr.GetValue(7));
                n = Convert.ToString(dr.GetValue(9));
                o = Convert.ToString(dr.GetValue(10));
                dr.Close();
                cmd = new SqlCommand("Insert Into Cancellation Values(" + CNumber.Text + ",'" + BookingNo.Text + "','" + l + "','" + BDate.Value + "','" + Strings.Format(CancDate.Value, "dd/MM/yyyy hh:mm:ss tt") + "','" + BBName.Text + "','" + m + "','" + Bcontact.Text + "','" + n + "','" + o + "')", con);
                cmd.ExecuteNonQuery();
                PK += 1;
            }
        }
        public AdvanceBookingCancellation()
        {
            Load += AdvanceBookingCancellation_Load;
            InitializeComponent();
        }

        private void AdvanceBookingCancellation_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select max(CancellationNo) From Cancellation", con);
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
            CNumber.Text = t.ToString();
            dr.Close();
        }

        private void BookingDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
