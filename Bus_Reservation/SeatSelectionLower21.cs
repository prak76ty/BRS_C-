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

    public partial class SeatSelectionLower21 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int i;
        int k;
        public string checkm;
        public string ST;
        public string PN;
        public string PassengerN;
        public string Pcity;
        public string Pcontact;
        public string BR;
        public string BNO4;
        public string RN;
        public string BN0;
        public SeatSelectionLower21(System.Object msgreceived, System.Object BN, System.Object R, System.Object B)
            : base()
        {
            Load += SeatSelectionLower21_Load;
            InitializeComponent();
            checkm = msgreceived.ToString();
            BNO4 = BN.ToString();
            RN = R.ToString();
            BN0 = B.ToString();
        }
        private void CheckBox1_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK1();
            }
        }
        private void CheckBox2_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK2();
            }
        }
        private void CheckBox3_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK3();
            }
        }
        private void CheckBox4_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK4();
            }
        }
        private void CheckBox5_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK5();
            }
        }
        private void CheckBox6_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK6();
            }
        }
        private void CheckBox7_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK7();
            }
        }
        private void CheckBox8_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK8();
            }
        }
        private void CheckBox9_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK9();
            }
        }
        private void CheckBox10_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK10();
            }
        }
        private void CheckBox11_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK11();
            }
        }
        private void CheckBox12_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK12();
            }
        }
        private void CheckBox13_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK13();
            }
        }
        private void CheckBox14_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK14();
            }
        }
        private void CheckBox15_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK15();
            }
        }
        private void CheckBox16_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK16();
            }
        }
        private void CheckBox17_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK17();
            }
        }
        private void CheckBox18_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK18();
            }
        }
        private void CheckBox19_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK19();
            }
        }
        private void CheckBox20_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK20();
            }
        }
        private void CheckBox21_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK21();
            }
        }
        private void CheckBox22_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK22();
            }
        }
        private void CheckBox23_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK23();
            }
        }
        private void CheckBox24_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK24();
            }
        }
        private void CheckBox25_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK25();
            }
        }
        private void CheckBox26_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK26();
            }
        }
        private void CheckBox27_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK27();
            }
        }
        private void CheckBox28_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK28();
            }
        }
        private void CheckBox29_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK29();
            }
        }
        private void CheckBox30_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 | i == 9 | i == 10 | i == 11 | i == 12 | i == 13 | i == 14 | i == 15 | i == 16 | i == 17 | i == 18 | i == 19)
            {
                CHK30();
            }
        }
        private void Button22_Click(System.Object sender, System.EventArgs e)
        {
            if (checkm == "NA")
            {
                SeatSelectionUpper21 SSU0 = new SeatSelectionUpper21("NA", BookingNo.Text, RNO.Text, BNO.Text);
                this.Close();
                SSU0.BringToFront();
                SSU0.Show();
            }
            else
            {
                SeatSelectionUpper21 SSU1 = new SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO.Text, BNO.Text);
                this.Close();
                SSU1.BringToFront();
                SSU1.Show();
            }
        }
        private void SeatSelectionLower21_Load(System.Object sender, System.EventArgs e)
        {
            PaymentBy.Text = "Select";
            if (checkm == "NA")
            {
                BookingNo.Text = BNO4;
            }
            else
            {
                BookingNo.Text = BNO4;
            }
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            if (checkm == "NA")
            {
                RNO.Text = RN;
                BNO.Text = BN0;
            }
            else
            {
                cmd = new SqlCommand("Select BookingDate From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                DateTimePicker1.Value = Convert.ToDateTime(dr.GetValue(0));
                RNO.Text = RN;
                BNO.Text = BN0;
                dr.Close();
            }
            cmd = new SqlCommand("Select SeatCapacity From Bus Where BusSno=" + BN0 + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            SCapacity.Text = Convert.ToString(dr.GetValue(0));
            dr.Close();
            if (DateTimePicker1.Value == DateAndTime.Today & checkm == "AB_UN" & BNO4 != "SB")
            {
                checkm = "NA";
                k = 95;
            }
            string check = null;
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            check = "1";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox1.Enabled = false;
                CheckBox1.BringToFront();
                CheckBox1.BackColor = Color.Red;
                CheckBox1.Text = "01 Booked";
            }
            dr.Close();
            check = "2";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox2.Enabled = false;
                CheckBox2.BringToFront();
                CheckBox2.BackColor = Color.Red;
                CheckBox2.Text = "02 Booked";
            }
            dr.Close();
            check = "3";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox3.Enabled = false;
                CheckBox3.BringToFront();
                CheckBox3.BackColor = Color.Red;
                CheckBox3.Text = "03 Booked";
            }
            dr.Close();
            check = "4";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox4.Enabled = false;
                CheckBox4.BringToFront();
                CheckBox4.BackColor = Color.Red;
                CheckBox4.Text = "04 Booked";
            }
            dr.Close();
            check = "5";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox5.Enabled = false;
                CheckBox5.BringToFront();
                CheckBox5.BackColor = Color.Red;
                CheckBox5.Text = "05 Booked";
            }
            dr.Close();
            check = "6";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox6.Enabled = false;
                CheckBox6.BringToFront();
                CheckBox6.BackColor = Color.Red;
                CheckBox6.Text = "06 Booked";
            }
            dr.Close();
            check = "7";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox7.Enabled = false;
                CheckBox7.BringToFront();
                CheckBox7.BackColor = Color.Red;
                CheckBox7.Text = "07 Booked";
            }
            dr.Close();
            check = "8";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox8.Enabled = false;
                CheckBox8.BringToFront();
                CheckBox8.BackColor = Color.Red;
                CheckBox8.Text = "08 Booked";
            }
            dr.Close();
            check = "9";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox9.Enabled = false;
                CheckBox9.BringToFront();
                CheckBox9.BackColor = Color.Red;
                CheckBox9.Text = "09 Booked";
            }
            dr.Close();
            check = "10";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox10.Enabled = false;
                CheckBox10.BringToFront();
                CheckBox10.BackColor = Color.Red;
                CheckBox10.Text = "10 Booked";
            }
            dr.Close();
            check = "11";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox11.Enabled = false;
                CheckBox11.BringToFront();
                CheckBox11.BackColor = Color.Red;
                CheckBox11.Text = "11 Booked";
            }
            dr.Close();
            check = "12";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox12.Enabled = false;
                CheckBox12.BringToFront();
                CheckBox12.BackColor = Color.Red;
                CheckBox12.Text = "12 Booked";
            }
            dr.Close();
            check = "13";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox13.Enabled = false;
                CheckBox13.BringToFront();
                CheckBox13.BackColor = Color.Red;
                CheckBox13.Text = "13 Booked";
            }
            dr.Close();
            check = "14";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox14.Enabled = false;
                CheckBox14.BringToFront();
                CheckBox14.BackColor = Color.Red;
                CheckBox14.Text = "14 Booked";
            }
            dr.Close();
            check = "15";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox15.Enabled = false;
                CheckBox15.BringToFront();
                CheckBox15.BackColor = Color.Red;
                CheckBox15.Text = "15 Booked";
            }
            dr.Close();
            check = "16";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox16.Enabled = false;
                CheckBox16.BringToFront();
                CheckBox16.BackColor = Color.Red;
                CheckBox16.Text = "16 Booked";
            }
            dr.Close();
            check = "17";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox17.Enabled = false;
                CheckBox17.BringToFront();
                CheckBox17.BackColor = Color.Red;
                CheckBox17.Text = "17 Booked";
            }
            dr.Close();
            check = "18";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox18.Enabled = false;
                CheckBox18.BringToFront();
                CheckBox18.BackColor = Color.Red;
                CheckBox18.Text = "18 Booked";
            }
            dr.Close();
            check = "19";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox19.Enabled = false;
                CheckBox19.BringToFront();
                CheckBox19.BackColor = Color.Red;
                CheckBox19.Text = "19 Booked";
            }
            dr.Close();
            check = "20";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox20.Enabled = false;
                CheckBox20.BringToFront();
                CheckBox20.BackColor = Color.Red;
                CheckBox20.Text = "20 Booked";
            }
            dr.Close();
            check = "21";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox21.Enabled = false;
                CheckBox21.BringToFront();
                CheckBox21.BackColor = Color.Red;
                CheckBox21.Text = "21 Booked";
            }
            dr.Close();
            check = "22";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox22.Enabled = false;
                CheckBox22.BringToFront();
                CheckBox22.BackColor = Color.Red;
                CheckBox22.Text = "22 Booked";
            }
            dr.Close();
            check = "23";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox23.Enabled = false;
                CheckBox23.BringToFront();
                CheckBox23.BackColor = Color.Red;
                CheckBox23.Text = "23 Booked";
            }
            dr.Close();
            check = "24";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox24.Enabled = false;
                CheckBox24.BringToFront();
                CheckBox24.BackColor = Color.Red;
                CheckBox24.Text = "24 Booked";
            }
            dr.Close();
            check = "25";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox25.Enabled = false;
                CheckBox25.BringToFront();
                CheckBox25.BackColor = Color.Red;
                CheckBox25.Text = "25 Booked";
            }
            dr.Close();
            check = "26";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox26.Enabled = false;
                CheckBox26.BringToFront();
                CheckBox26.BackColor = Color.Red;
                CheckBox26.Text = "26 Booked";
            }
            dr.Close();
            check = "27";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox27.Enabled = false;
                CheckBox27.BringToFront();
                CheckBox27.BackColor = Color.Red;
                CheckBox27.Text = "27 Booked";
            }
            dr.Close();
            check = "28";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox28.Enabled = false;
                CheckBox28.BringToFront();
                CheckBox28.BackColor = Color.Red;
                CheckBox28.Text = "28 Booked";
            }
            dr.Close();
            check = "29";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox29.Enabled = false;
                CheckBox29.BringToFront();
                CheckBox29.BackColor = Color.Red;
                CheckBox29.Text = "29 Booked";
            }
            dr.Close();
            check = "30";
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select SeatNo,SeatType,BusSno,RouteNo From PassengerDetails where SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            else
            {
                cmd = new SqlCommand("Select BDate,SeatNo,SeatType,BusSno,RouteNo From APassengerDetails where BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' and SeatNo='" + check + "' and SeatType='" + SType.Text + "' and BusSno='" + BNO.Text + "' and RouteNo='" + RNO.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                CheckBox30.Enabled = false;
                CheckBox30.BringToFront();
                CheckBox30.BackColor = Color.Red;
                CheckBox30.Text = "30 Booked";
            }
            dr.Close();
            con.Close();
            if (k == 95)
            {
                checkm = "AB_UN";
            }
        }
        private void Insert_Click(System.Object sender, System.EventArgs e)
        {
            if (PaymentBy.Text == "Select")
            {
                MessageBox.Show("Plz.. Select Payment Method");
            }
            else
            {
                if (PaymentBy.Text == "Cash")
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();

                    cmd = new SqlCommand("Select FareAmt From Route Where Rno=" + RNO.Text + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    FareAmount.Text = Convert.ToString(dr.GetValue(0));
                    dr.Close();
                    con.Close();
                    if (CheckBox1.Checked == true)
                    {
                        SeatNo.Text = "1";
                        InsertDB();
                    }
                    if (CheckBox2.Checked == true)
                    {
                        SeatNo.Text = "2";
                        InsertDB();
                    }
                    if (CheckBox3.Checked == true)
                    {
                        SeatNo.Text = "3";
                        InsertDB();
                    }
                    if (CheckBox4.Checked == true)
                    {
                        SeatNo.Text = "4";
                        InsertDB();
                    }
                    if (CheckBox5.Checked == true)
                    {
                        SeatNo.Text = "5";
                        InsertDB();
                    }
                    if (CheckBox6.Checked == true)
                    {
                        SeatNo.Text = "6";
                        InsertDB();
                    }
                    if (CheckBox7.Checked == true)
                    {
                        SeatNo.Text = "7";
                        InsertDB();
                    }
                    if (CheckBox8.Checked == true)
                    {
                        SeatNo.Text = "8";
                        InsertDB();
                    }
                    if (CheckBox9.Checked == true)
                    {
                        SeatNo.Text = "9";
                        InsertDB();
                    }
                    if (CheckBox10.Checked == true)
                    {
                        SeatNo.Text = "10";
                        InsertDB();
                    }
                    if (CheckBox11.Checked == true)
                    {
                        SeatNo.Text = "11";
                        InsertDB();
                    }
                    if (CheckBox12.Checked == true)
                    {
                        SeatNo.Text = "12";
                        InsertDB();
                    }
                    if (CheckBox13.Checked == true)
                    {
                        SeatNo.Text = "13";
                        InsertDB();
                    }
                    if (CheckBox14.Checked == true)
                    {
                        SeatNo.Text = "14";
                        InsertDB();
                    }
                    if (CheckBox15.Checked == true)
                    {
                        SeatNo.Text = "15";
                        InsertDB();
                    }
                    if (CheckBox16.Checked == true)
                    {
                        SeatNo.Text = "16";
                        InsertDB();
                    }
                    if (CheckBox17.Checked == true)
                    {
                        SeatNo.Text = "17";
                        InsertDB();
                    }
                    if (CheckBox18.Checked == true)
                    {
                        SeatNo.Text = "18";
                        InsertDB();
                    }
                    if (CheckBox19.Checked == true)
                    {
                        SeatNo.Text = "19";
                        InsertDB();
                    }
                    if (CheckBox20.Checked == true)
                    {
                        SeatNo.Text = "20";
                        InsertDB();
                    }
                    if (CheckBox21.Checked == true)
                    {
                        SeatNo.Text = "21";
                        InsertDB();
                    }
                    if (CheckBox22.Checked == true)
                    {
                        SeatNo.Text = "22";
                        InsertDB();
                    }
                    if (CheckBox23.Checked == true)
                    {
                        SeatNo.Text = "23";
                        InsertDB();
                    }
                    if (CheckBox24.Checked == true)
                    {
                        SeatNo.Text = "24";
                        InsertDB();
                    }
                    if (CheckBox25.Checked == true)
                    {
                        SeatNo.Text = "25";
                        InsertDB();
                    }
                    if (CheckBox26.Checked == true)
                    {
                        SeatNo.Text = "26";
                        InsertDB();
                    }
                    if (CheckBox27.Checked == true)
                    {
                        SeatNo.Text = "27";
                        InsertDB();
                    }
                    if (CheckBox28.Checked == true)
                    {
                        SeatNo.Text = "28";
                        InsertDB();
                    }
                    if (CheckBox29.Checked == true)
                    {
                        SeatNo.Text = "29";
                        InsertDB();
                    }
                    if (CheckBox30.Checked == true)
                    {
                        SeatNo.Text = "30";
                        InsertDB();
                    }
                }
                else if (PaymentBy.Text == "Cash Later")
                {
                    FareAmount.Text = "0";
                    if (CheckBox1.Checked == true)
                    {
                        SeatNo.Text = "1";
                        InsertDB();
                    }
                    if (CheckBox2.Checked == true)
                    {
                        SeatNo.Text = "2";
                        InsertDB();
                    }
                    if (CheckBox3.Checked == true)
                    {
                        SeatNo.Text = "3";
                        InsertDB();
                    }
                    if (CheckBox4.Checked == true)
                    {
                        SeatNo.Text = "4";
                        InsertDB();
                    }
                    if (CheckBox5.Checked == true)
                    {
                        SeatNo.Text = "5";
                        InsertDB();
                    }
                    if (CheckBox6.Checked == true)
                    {
                        SeatNo.Text = "6";
                        InsertDB();
                    }
                    if (CheckBox7.Checked == true)
                    {
                        SeatNo.Text = "7";
                        InsertDB();
                    }
                    if (CheckBox8.Checked == true)
                    {
                        SeatNo.Text = "8";
                        InsertDB();
                    }
                    if (CheckBox9.Checked == true)
                    {
                        SeatNo.Text = "9";
                        InsertDB();
                    }
                    if (CheckBox10.Checked == true)
                    {
                        SeatNo.Text = "10";
                        InsertDB();
                    }
                    if (CheckBox11.Checked == true)
                    {
                        SeatNo.Text = "11";
                        InsertDB();
                    }
                    if (CheckBox12.Checked == true)
                    {
                        SeatNo.Text = "12";
                        InsertDB();
                    }
                    if (CheckBox13.Checked == true)
                    {
                        SeatNo.Text = "13";
                        InsertDB();
                    }
                    if (CheckBox14.Checked == true)
                    {
                        SeatNo.Text = "14";
                        InsertDB();
                    }
                    if (CheckBox15.Checked == true)
                    {
                        SeatNo.Text = "15";
                        InsertDB();
                    }
                    if (CheckBox16.Checked == true)
                    {
                        SeatNo.Text = "16";
                        InsertDB();
                    }
                    if (CheckBox17.Checked == true)
                    {
                        SeatNo.Text = "17";
                        InsertDB();
                    }
                    if (CheckBox18.Checked == true)
                    {
                        SeatNo.Text = "18";
                        InsertDB();
                    }
                    if (CheckBox19.Checked == true)
                    {
                        SeatNo.Text = "19";
                        InsertDB();
                    }
                    if (CheckBox20.Checked == true)
                    {
                        SeatNo.Text = "20";
                        InsertDB();
                    }
                    if (CheckBox21.Checked == true)
                    {
                        SeatNo.Text = "21";
                        InsertDB();
                    }
                    if (CheckBox22.Checked == true)
                    {
                        SeatNo.Text = "22";
                        InsertDB();
                    }
                    if (CheckBox23.Checked == true)
                    {
                        SeatNo.Text = "23";
                        InsertDB();
                    }
                    if (CheckBox24.Checked == true)
                    {
                        SeatNo.Text = "24";
                        InsertDB();
                    }
                    if (CheckBox25.Checked == true)
                    {
                        SeatNo.Text = "25";
                        InsertDB();
                    }
                    if (CheckBox26.Checked == true)
                    {
                        SeatNo.Text = "26";
                        InsertDB();
                    }
                    if (CheckBox27.Checked == true)
                    {
                        SeatNo.Text = "27";
                        InsertDB();
                    }
                    if (CheckBox28.Checked == true)
                    {
                        SeatNo.Text = "28";
                        InsertDB();
                    }
                    if (CheckBox29.Checked == true)
                    {
                        SeatNo.Text = "29";
                        InsertDB();
                    }
                    if (CheckBox30.Checked == true)
                    {
                        SeatNo.Text = "30";
                        InsertDB();
                    }
                }
                else if (PaymentBy.Text == "Some Cash")
                {
                    if (CheckBox1.Checked == true)
                    {
                        SeatNo.Text = "1";
                        FareAmount.Text = Convert.ToString(TextBox1.Text);
                        InsertDB();
                    }
                    if (CheckBox2.Checked == true)
                    {
                        SeatNo.Text = "2";
                        FareAmount.Text = Convert.ToString(TextBox2.Text);
                        InsertDB();
                    }
                    if (CheckBox3.Checked == true)
                    {
                        SeatNo.Text = "3";
                        FareAmount.Text = Convert.ToString(TextBox3.Text);
                        InsertDB();
                    }
                    if (CheckBox4.Checked == true)
                    {
                        SeatNo.Text = "4";
                        FareAmount.Text = Convert.ToString(TextBox4.Text);
                        InsertDB();
                    }
                    if (CheckBox5.Checked == true)
                    {
                        SeatNo.Text = "5";
                        FareAmount.Text = Convert.ToString(TextBox5.Text);
                        InsertDB();
                    }
                    if (CheckBox6.Checked == true)
                    {
                        SeatNo.Text = "6";
                        FareAmount.Text = Convert.ToString(TextBox6.Text);
                        InsertDB();
                    }
                    if (CheckBox7.Checked == true)
                    {
                        SeatNo.Text = "7";
                        FareAmount.Text = Convert.ToString(TextBox7.Text);
                        InsertDB();
                    }
                    if (CheckBox8.Checked == true)
                    {
                        SeatNo.Text = "8";
                        FareAmount.Text = Convert.ToString(TextBox8.Text);
                        InsertDB();
                    }
                    if (CheckBox9.Checked == true)
                    {
                        SeatNo.Text = "9";
                        FareAmount.Text = Convert.ToString(TextBox9.Text);
                        InsertDB();
                    }
                    if (CheckBox10.Checked == true)
                    {
                        SeatNo.Text = "10";
                        FareAmount.Text = Convert.ToString(TextBox10.Text);
                        InsertDB();
                    }
                    if (CheckBox11.Checked == true)
                    {
                        SeatNo.Text = "11";
                        FareAmount.Text = Convert.ToString(TextBox11.Text);
                        InsertDB();
                    }
                    if (CheckBox12.Checked == true)
                    {
                        SeatNo.Text = "12";
                        FareAmount.Text = Convert.ToString(TextBox12.Text);
                        InsertDB();
                    }
                    if (CheckBox13.Checked == true)
                    {
                        SeatNo.Text = "13";
                        FareAmount.Text = Convert.ToString(TextBox13.Text);
                        InsertDB();
                    }
                    if (CheckBox14.Checked == true)
                    {
                        SeatNo.Text = "14";
                        FareAmount.Text = Convert.ToString(TextBox14.Text);
                        InsertDB();
                    }
                    if (CheckBox15.Checked == true)
                    {
                        SeatNo.Text = "15";
                        FareAmount.Text = Convert.ToString(TextBox15.Text);
                        InsertDB();
                    }
                    if (CheckBox16.Checked == true)
                    {
                        SeatNo.Text = "16";
                        FareAmount.Text = Convert.ToString(TextBox16.Text);
                        InsertDB();
                    }
                    if (CheckBox17.Checked == true)
                    {
                        SeatNo.Text = "17";
                        FareAmount.Text = Convert.ToString(TextBox17.Text);
                        InsertDB();
                    }
                    if (CheckBox18.Checked == true)
                    {
                        SeatNo.Text = "18";
                        FareAmount.Text = Convert.ToString(TextBox18.Text);
                        InsertDB();
                    }
                    if (CheckBox19.Checked == true)
                    {
                        SeatNo.Text = "19";
                        FareAmount.Text = Convert.ToString(TextBox19.Text);
                        InsertDB();
                    }
                    if (CheckBox20.Checked == true)
                    {
                        SeatNo.Text = "20";
                        FareAmount.Text = Convert.ToString(TextBox20.Text);
                        InsertDB();
                    }
                    if (CheckBox21.Checked == true)
                    {
                        SeatNo.Text = "21";
                        FareAmount.Text = Convert.ToString(TextBox21.Text);
                        InsertDB();
                    }
                    if (CheckBox22.Checked == true)
                    {
                        SeatNo.Text = "22";
                        FareAmount.Text = Convert.ToString(TextBox22.Text);
                        InsertDB();
                    }
                    if (CheckBox23.Checked == true)
                    {
                        SeatNo.Text = "23";
                        FareAmount.Text = Convert.ToString(TextBox23.Text);
                        InsertDB();
                    }
                    if (CheckBox24.Checked == true)
                    {
                        SeatNo.Text = "24";
                        FareAmount.Text = Convert.ToString(TextBox24.Text);
                        InsertDB();
                    }
                    if (CheckBox25.Checked == true)
                    {
                        SeatNo.Text = "25";
                        FareAmount.Text = Convert.ToString(TextBox25.Text);
                        InsertDB();
                    }
                    if (CheckBox26.Checked == true)
                    {
                        SeatNo.Text = "26";
                        FareAmount.Text = Convert.ToString(TextBox26.Text);
                        InsertDB();
                    }
                    if (CheckBox27.Checked == true)
                    {
                        SeatNo.Text = "27";
                        FareAmount.Text = Convert.ToString(TextBox27.Text);
                        InsertDB();
                    }
                    if (CheckBox28.Checked == true)
                    {
                        SeatNo.Text = "28";
                        FareAmount.Text = Convert.ToString(TextBox28.Text);
                        InsertDB();
                    }
                    if (CheckBox29.Checked == true)
                    {
                        SeatNo.Text = "29";
                        FareAmount.Text = Convert.ToString(TextBox29.Text);
                        InsertDB();
                    }
                    if (CheckBox30.Checked == true)
                    {
                        SeatNo.Text = "30";
                        FareAmount.Text = Convert.ToString(TextBox30.Text);
                        InsertDB();
                    }
                }
                MessageBox.Show("DONE.. !!!");
                SeatNo.Text = "";
                if (checkm == "NA")
                {
                    Booking_And_Passenger a1 = new Booking_And_Passenger("NA", "NA", "0");
                    a1.Show();
                }
                else
                {
                    Seat_Booking_Details s1 = new Seat_Booking_Details("AB_UN", BNO4);
                    s1.Show();
                }
                this.Close();
            }
        }
        public void InsertDB()
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Update PassengerDetails Set RouteNo='" + RNO.Text + "',BusSno='" + BNO.Text + "',FareAmount='" + FareAmount.Text + "',Payment='" + PaymentBy.Text + "',BDate='" + Strings.Format(DateAndTime.Today, "dd/MM/yyyy") + "' where BookingNo=" + BookingNo.Text + "", con);
            }
            else
            {
                cmd = new SqlCommand("Update APassengerDetails Set RouteNo='" + RNO.Text + "',BusSno='" + BNO.Text + "',FareAmount='" + FareAmount.Text + "',Payment='" + PaymentBy.Text + "',BDate='" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "' where BookingNo=" + BookingNo.Text + "", con);
            }
            cmd.ExecuteNonQuery();
        }

        private void PaymentBy_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PaymentBy.Text == "Some Cash")
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox15.Visible = true;
                TextBox16.Visible = true;
                TextBox17.Visible = true;
                TextBox18.Visible = true;
                TextBox19.Visible = true;
                TextBox20.Visible = true;
                TextBox21.Visible = true;
                TextBox22.Visible = true;
                TextBox23.Visible = true;
                TextBox24.Visible = true;
                TextBox25.Visible = true;
                TextBox26.Visible = true;
                TextBox27.Visible = true;
                TextBox28.Visible = true;
                TextBox29.Visible = true;
                TextBox30.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
            }
            else if (PaymentBy.Text == "Cash")
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox10.Visible = false;
                TextBox11.Visible = false;
                TextBox12.Visible = false;
                TextBox13.Visible = false;
                TextBox14.Visible = false;
                TextBox15.Visible = false;
                TextBox16.Visible = false;
                TextBox17.Visible = false;
                TextBox18.Visible = false;
                TextBox19.Visible = false;
                TextBox20.Visible = false;
                TextBox21.Visible = false;
                TextBox22.Visible = false;
                TextBox23.Visible = false;
                TextBox24.Visible = false;
                TextBox25.Visible = false;
                TextBox26.Visible = false;
                TextBox27.Visible = false;
                TextBox28.Visible = false;
                TextBox29.Visible = false;
                TextBox30.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
                TextBox9.Visible = false;
            }
            else if (PaymentBy.Text == "Cash Later")
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox10.Visible = false;
                TextBox11.Visible = false;
                TextBox12.Visible = false;
                TextBox13.Visible = false;
                TextBox14.Visible = false;
                TextBox15.Visible = false;
                TextBox16.Visible = false;
                TextBox17.Visible = false;
                TextBox18.Visible = false;
                TextBox19.Visible = false;
                TextBox20.Visible = false;
                TextBox21.Visible = false;
                TextBox22.Visible = false;
                TextBox23.Visible = false;
                TextBox24.Visible = false;
                TextBox25.Visible = false;
                TextBox26.Visible = false;
                TextBox27.Visible = false;
                TextBox28.Visible = false;
                TextBox29.Visible = false;
                TextBox30.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
                TextBox9.Visible = false;
            }
        }

        private void InsertP_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PaymentBy.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Select Payment Option");
                }
                else if (string.IsNullOrEmpty(Convert.ToString(DGV.Rows[i].Cells[1].Value)))
                {
                    MessageBox.Show("Plz.. Type Passenger Name");
                }
                else if (string.IsNullOrEmpty(Convert.ToString(DGV.Rows[i].Cells[2].Value)))
                {
                    MessageBox.Show("Plz.. Select Passenger Gender");
                }
                else if (string.IsNullOrEmpty(Convert.ToString(DGV.Rows[i].Cells[3].Value)))
                {
                    MessageBox.Show("Plz.. Type Passenger Age");
                }
                else
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();
                    if (checkm == "NA")
                    {
                        cmd = new SqlCommand("Insert Into PassengerDetails(BookingNo,SrNo,PNAME,PGENDER,PassengerAGE,SeatNo,SeatType) Values(" + BookingNo.Text + ",'" + DGV.Rows[i].Cells[0].Value + "','" + DGV.Rows[i].Cells[1].Value + "','" + DGV.Rows[i].Cells[2].Value + "','" + DGV.Rows[i].Cells[3].Value + "','" + DGV.Rows[i].Cells[4].Value + "','" + SType.Text + "')", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("Insert Into APassengerDetails(BookingNo,SrNo,PNAME,PGENDER,PassengerAGE,SeatNo,SeatType) Values(" + BookingNo.Text + ",'" + DGV.Rows[i].Cells[0].Value + "','" + DGV.Rows[i].Cells[1].Value + "','" + DGV.Rows[i].Cells[2].Value + "','" + DGV.Rows[i].Cells[3].Value + "','" + DGV.Rows[i].Cells[4].Value + "','" + SType.Text + "')", con);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success...");
                    if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 1)
                    {
                        CheckBox1.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 2)
                    {
                        CheckBox2.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 3)
                    {
                        CheckBox3.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 4)
                    {
                        CheckBox4.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 5)
                    {
                        CheckBox5.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 6)
                    {
                        CheckBox6.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 7)
                    {
                        CheckBox7.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 8)
                    {
                        CheckBox8.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 9)
                    {
                        CheckBox9.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 10)
                    {
                        CheckBox10.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 11)
                    {
                        CheckBox11.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 12)
                    {
                        CheckBox12.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 13)
                    {
                        CheckBox13.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 14)
                    {
                        CheckBox14.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 15)
                    {
                        CheckBox15.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 16)
                    {
                        CheckBox16.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 17)
                    {
                        CheckBox17.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 18)
                    {
                        CheckBox18.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 19)
                    {
                        CheckBox19.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 20)
                    {
                        CheckBox20.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 21)
                    {
                        CheckBox21.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 22)
                    {
                        CheckBox22.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 23)
                    {
                        CheckBox23.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 24)
                    {
                        CheckBox24.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 25)
                    {
                        CheckBox25.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 26)
                    {
                        CheckBox26.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 27)
                    {
                        CheckBox27.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 28)
                    {
                        CheckBox28.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 29)
                    {
                        CheckBox29.Enabled = false;
                    }
                    else if ((Convert.ToInt32(DGV.Rows[i].Cells[4].Value)) == 30)
                    {
                        CheckBox30.Enabled = false;
                    }
                    i += 1;
                    Insert.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Passenger Insertion Failed Or " + ex.Message);
            }
        }
        public void CHK1()
        {
            if (CheckBox1.Checked == true)
            {
                CheckBox1.Text = "01 Booked";
                DGV[4, i].Value  = "1";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox1.Text = "01";
            }
        }
        public void CHK2()
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox2.Text = "02 Booked";
                DGV[4, i].Value  = "2";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox2.Text = "02";
            }
        }
        public void CHK3()
        {
            if (CheckBox3.Checked == true)
            {
                CheckBox3.Text = "03 Booked";
                DGV[4, i].Value  = "3";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox3.Text = "03";
            }
        }
        public void CHK4()
        {
            if (CheckBox4.Checked == true)
            {
                CheckBox4.Text = "04 Booked";
                DGV[4, i].Value  = "4";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox4.Text = "04";
            }
        }
        public void CHK5()
        {
            if (CheckBox5.Checked == true)
            {
                CheckBox5.Text = "05 Booked";
                DGV[4, i].Value  = "5";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox5.Text = "05";
            }
        }
        public void CHK6()
        {
            if (CheckBox6.Checked == true)
            {
                CheckBox6.Text = "06 Booked";
                DGV[4, i].Value  = "6";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox6.Text = "06";
            }
        }
        public void CHK7()
        {
            if (CheckBox7.Checked == true)
            {
                CheckBox7.Text = "07 Booked";
                DGV[4, i].Value  = "7";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox7.Text = "07";
            }
        }
        public void CHK8()
        {
            if (CheckBox8.Checked == true)
            {
                CheckBox8.Text = "08 Booked";
                DGV[4, i].Value  = "8";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox8.Text = "08";
            }
        }
        public void CHK9()
        {
            if (CheckBox9.Checked == true)
            {
                CheckBox9.Text = "09 Booked";
                DGV[4, i].Value  = "9";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox9.Text = "09";
            }
        }
        public void CHK10()
        {
            if (CheckBox10.Checked == true)
            {
                CheckBox10.Text = "10 Booked";
                DGV[4, i].Value  = "10";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox10.Text = "10";
            }
        }
        public void CHK11()
        {
            if (CheckBox11.Checked == true)
            {
                CheckBox11.Text = "11 Booked";
                DGV[4, i].Value  = "11";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox11.Text = "11";
            }
        }
        public void CHK12()
        {
            if (CheckBox12.Checked == true)
            {
                CheckBox12.Text = "12 Booked";
                DGV[4, i].Value  = "12";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox12.Text = "12";
            }
        }
        public void CHK13()
        {
            if (CheckBox13.Checked == true)
            {
                CheckBox13.Text = "13 Booked";
                DGV[4, i].Value  = "13";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox13.Text = "13";
            }
        }
        public void CHK14()
        {
            if (CheckBox14.Checked == true)
            {
                CheckBox14.Text = "14 Booked";
                DGV[4, i].Value  = "14";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox14.Text = "14";
            }
        }
        public void CHK15()
        {
            if (CheckBox15.Checked == true)
            {
                CheckBox15.Text = "15 Booked";
                DGV[4, i].Value  = "15";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox15.Text = "15";
            }
        }
        public void CHK16()
        {
            if (CheckBox16.Checked == true)
            {
                CheckBox16.Text = "16 Booked";
                DGV[0, i].Value  = i + 1;
                DGV[4, i].Value  = "16";

            }
            else
            {
                DGV[0, i].Value = "";
                DGV[4, i].Value = "";
                CheckBox16.Text = "16";
            }
        }
        public void CHK17()
        {
            if (CheckBox17.Checked == true)
            {
                CheckBox17.Text = "17 Booked";
                DGV[4, i].Value  = "17";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox17.Text = "17";
            }
        }
        public void CHK18()
        {
            if (CheckBox18.Checked == true)
            {
                CheckBox18.Text = "18 Booked";
                DGV[4, i].Value  = "18";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox18.Text = "18";
            }
        }
        public void CHK19()
        {
            if (CheckBox19.Checked == true)
            {
                CheckBox19.Text = "19 Booked";
                DGV[4, i].Value  = "19";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox19.Text = "19";
            }
        }
        public void CHK20()
        {
            if (CheckBox20.Checked == true)
            {
                CheckBox20.Text = "20 Booked";
                DGV[4, i].Value  = "20";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox20.Text = "20";
            }
        }
        public void CHK21()
        {
            if (CheckBox21.Checked == true)
            {
                CheckBox21.Text = "21 Booked";
                DGV[4, i].Value  = "21";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox21.Text = "21";
            }
        }
        public void CHK22()
        {
            if (CheckBox22.Checked == true)
            {
                CheckBox22.Text = "22 Booked";
                DGV[4, i].Value  = "22";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox22.Text = "22";
            }
        }
        public void CHK23()
        {
            if (CheckBox23.Checked == true)
            {
                CheckBox23.Text = "23 Booked";
                DGV[4, i].Value  = "23";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox23.Text = "23";
            }
        }
        public void CHK24()
        {
            if (CheckBox24.Checked == true)
            {
                CheckBox24.Text = "24 Booked";
                DGV[4, i].Value  = "24";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox24.Text = "24";
            }
        }
        public void CHK25()
        {
            if (CheckBox25.Checked == true)
            {
                CheckBox25.Text = "25 Booked";
                DGV[4, i].Value  = "25";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox25.Text = "25";
            }
        }
        public void CHK26()
        {
            if (CheckBox26.Checked == true)
            {
                CheckBox26.Text = "26 Booked";
                DGV[0, i].Value  = i + 1;
                DGV[4, i].Value  = "26";

            }
            else
            {
                DGV[0, i].Value = "";
                DGV[4, i].Value = "";
                CheckBox26.Text = "26";
            }
        }
        public void CHK27()
        {
            if (CheckBox27.Checked == true)
            {
                CheckBox27.Text = "27 Booked";
                DGV[4, i].Value  = "27";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox27.Text = "27";
            }
        }
        public void CHK28()
        {
            if (CheckBox28.Checked == true)
            {
                CheckBox28.Text = "28 Booked";
                DGV[4, i].Value  = "28";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox28.Text = "28";
            }
        }
        public void CHK29()
        {
            if (CheckBox29.Checked == true)
            {
                CheckBox29.Text = "29 Booked";
                DGV[4, i].Value  = "29";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox29.Text = "29";
            }
        }
        public void CHK30()
        {
            if (CheckBox30.Checked == true)
            {
                CheckBox30.Text = "30 Booked";
                DGV[4, i].Value  = "30";
                DGV[0, i].Value  = i + 1;
            }
            else
            {
                DGV[4, i].Value = "";
                DGV[0, i].Value = "";
                CheckBox30.Text = "30";
            }
        }

    }
}
