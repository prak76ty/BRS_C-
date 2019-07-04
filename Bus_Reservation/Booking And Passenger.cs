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

    public partial class Booking_And_Passenger : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int t;
        int f;
        string checkm;
        string stype;
        string BR;
        string RNO;
        string BNO;
        string Scapacity;

        string WL;
        public Booking_And_Passenger(System.Object msgreceived, System.Object seattype, System.Object WN)
            : base()
        {
            Load += Booking_And_Passenger_Load;
            InitializeComponent();
            checkm = msgreceived.ToString();
            stype = seattype.ToString();
            WL = WN.ToString();
        }
        private void Booking_And_Passenger_Load(System.Object sender, System.EventArgs e)
        {
            if (WL == "WL")
            {
                WLF.Enabled = true;
                Insert.Enabled = false;
            }
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            if (checkm == "NA")
            {
                cmd = new SqlCommand("Select max(BookingNo) From PaymentPassenger", con);
            }
            else
            {
                cmd = new SqlCommand("Select max(BookingNo) From APaymentPassenger", con);
            }
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
            BookingNo.Text = t.ToString();
            if (BookingNo.Text != "1")
            {
                BookingNo.Text = Convert.ToString(Convert.ToInt32(BookingNo.Text) - 1);
            }
            dr.Close();
            if (checkm == "AB_UN")
            {
                cmd = new SqlCommand("Select BookingDate From APaymentPassenger Where BookingNo=" + BookingNo.Text + "", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                BookingDate.Value = Convert.ToDateTime(dr.GetValue(0));
                dr.Close();
                Button22.Enabled = false;
                Button1.Enabled = false;
            }
            con.Close();
            if (checkm == "NA")
            {

                RNO = Master.s1;
                BNO = Master.s2;
                Scapacity = Master.s3;
                BR = Master.s4;

            }
            else
            {
                RNO = Master.a1;
                BNO = Master.a2;
                Scapacity = Master.a3;
                BR = Master.a4;
            }
        }

        private void btnpassengerfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PassengerNo.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter Valid Passenger No");
                }
                else
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Select * From Passenger Where Pno=" + PassengerNo.Text + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    PassengerNo.Text = Convert.ToString(dr.GetValue(0));
                    PassengerName.Text = Convert.ToString(dr.GetValue(1));
                    PassengerAddress.Text = Convert.ToString(dr.GetValue(2));
                    PassengerCity.Text = Convert.ToString(dr.GetValue(3));
                    PassengerContact.Text = Convert.ToString(dr.GetValue(4));
                    dr.Close();
                    con.Close();
                    f = 1;
                    btnsave.Enabled = true;
                    btndelete.Enabled = true;
                    PassengerNo.Enabled = true;
                    PassengerName.Enabled = true;
                    PassengerAddress.Enabled = true;
                    PassengerCity.Enabled = true;
                    PassengerContact.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found Or " + ex.Message);
            }
        }

        private void btnnew_Click(System.Object sender, System.EventArgs e)
        {
            clear();
            PassengerNo.Enabled = true;
            PassengerName.Enabled = true;
            PassengerAddress.Enabled = true;
            PassengerCity.Enabled = true;
            PassengerContact.Enabled = true;
            PassengerName.Focus();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select max(Pno) From Passenger", con);
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
            PassengerNo.Text = t.ToString();
            dr.Close();
            con.Close();
            btnsave.Enabled = true;
            btnpassengerfind.Enabled = false;
            btnnew.Enabled = false;
            f = 5;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            PassengerSU();
            btnsave.Enabled = false;
            btnpassengerfind.Enabled = true;
            btnnew.Enabled = true;
            btndelete.Enabled = false;
        }

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (res == DialogResult.Yes) {
				con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
				con.Open();
				cmd = new SqlCommand("Delete From Passenger Where Pno=" + PassengerNo.Text + "", con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Record Deleted !");
				clear();
				btnsave.Enabled = false;
				btnnew.Enabled = true;
				btnpassengerfind.Enabled = true;
				con.Close();
			}
		}
        public void clear()
        {
            PassengerNo.Clear();
            PassengerName.Clear();
            PassengerAddress.Clear();
            PassengerCity.Clear();
            PassengerContact.Clear();
            PassengerNo.Enabled = true;
            PassengerName.Enabled = false;
            PassengerAddress.Enabled = false;
            PassengerCity.Enabled = false;
            PassengerContact.Enabled = false;
        }
        private void PassengerName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void PassengerContact_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (Strings.Asc(e.KeyChar) != 13 && Strings.Asc(e.KeyChar) != 8 && !Information.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void PassengerCity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void Insert_Click(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(PassengerNo.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Passenger No..");
            }
            else
            {
               
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (checkm == "NA")
                {
                    cmd = new SqlCommand("Update PaymentPassenger Set BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "',PassengerNo='" + PassengerNo.Text + "',PassengerName='" + PassengerName.Text + "',PassengerCity='" + PassengerCity.Text + "',PassengerContact='" + PassengerContact.Text + "',PassengerAddress='" + PassengerAddress.Text + "'Where BookingNo=" + BookingNo.Text + "", con);
                }
                else
                {
                    cmd = new SqlCommand("Update APaymentPassenger Set BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "',PassengerNo='" + PassengerNo.Text + "',PassengerName='" + PassengerName.Text + "',PassengerCity='" + PassengerCity.Text + "',PassengerContact='" + PassengerContact.Text + "',PassengerAddress='" + PassengerAddress.Text + "'Where BookingNo=" + BookingNo.Text + "", con);
                }
                cmd.ExecuteNonQuery();
                con.Close();
                PassengerSU();
                MessageBox.Show("Success... Next");
                if (checkm == "NA")
                {
                    Seat_Booking_Details s1 = new Seat_Booking_Details("NA", BookingNo.Text);
                    this.Close();
                    s1.Show();
                    s1.BringToFront();
                }
                else
                {
                    if (BR == "1x1" & stype == "L")
                    {
                        SeatSelectionLower SSL = new SeatSelectionLower("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSL.Show();
                    }
                    if (BR == "1x1" & stype == "U")
                    {
                        SeatSelectionUpper SSU = new SeatSelectionUpper("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSU.Show();
                    }
                    if (BR == "2x1" & stype == "L")
                    {
                        SeatSelectionLower21 SSL1 = new SeatSelectionLower21("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSL1.Show();
                    }
                    if (BR == "2x1" & stype == "U")
                    {
                        SeatSelectionUpper21 SSU1 = new SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSU1.Show();
                    }
                    if (BR == "2x2" & stype == "L")
                    {
                        SeatSelectionLower22 SSL2 = new SeatSelectionLower22("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSL2.Show();
                    }
                    if (BR == "2x2" & stype == "U")
                    {
                        SeatSelectionUpper21 SSU2 = new SeatSelectionUpper21("AB_UN", BookingNo.Text, RNO, BNO);
                        this.Close();
                        SSU2.Show();
                    }
                }
            }
        }

        private void Button22_Click(System.Object sender, System.EventArgs e)
        {
            if (checkm == "NA")
            {
                SeatSelectionLower SSL0 = new SeatSelectionLower("NA", BookingNo.Text, RNO, BNO);
                this.Close();
                SSL0.BringToFront();
                SSL0.Show();
            }
            else
            {
                SeatSelectionLower SSL0 = new SeatSelectionLower("AB_UN", BookingNo.Text, RNO, BNO);
                this.Close();
                SSL0.BringToFront();
                SSL0.Show();
            }

        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            if (checkm == "NA")
            {
                SeatSelectionUpper SSL1 = new SeatSelectionUpper("NA", BookingNo.Text, RNO, BNO);
                this.Close();
                SSL1.BringToFront();
                SSL1.Show();
            }
            else
            {
                SeatSelectionUpper SSL1 = new SeatSelectionUpper("AB_UN", BookingNo.Text, RNO, BNO);
                this.Close();
                SSL1.BringToFront();
                SSL1.Show();
            }
        }

        private void WLF_Click(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(PassengerNo.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Passenger No..");
            }
            else
            {
                //if (checkm == "NA")
                //{
                //    RNO = SeatBooking.Rno.Text;
                //    BNO = SeatBooking.BusSerialNo.Text;
                //    Scapacity = SeatBooking.SeatCapacity.Text;
                //    BR = SeatBooking.BusReservation.Text;
                //}
                //else
                //{
                //    RNO = My.MyProject.Forms.AdvanceSeatBooking.Rno.Text;
                //    BNO = My.MyProject.Forms.AdvanceSeatBooking.BusSerialNo.Text;
                //    Scapacity = My.MyProject.Forms.AdvanceSeatBooking.SeatCapacity.Text;
                //    BR = My.MyProject.Forms.AdvanceSeatBooking.BusReservation.Text;
                //}
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update APaymentPassenger Set BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "',PassengerNo='" + PassengerNo.Text + "',PassengerName='" + PassengerName.Text + "',PassengerCity='" + PassengerCity.Text + "',PassengerContact='" + PassengerContact.Text + "',PassengerAddress='" + PassengerAddress.Text + "'Where BookingNo=" + BookingNo.Text + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
                PassengerSU();
                MessageBox.Show("Finished...");
                this.Close();
               // SeatBooking.Close();
               // My.MyProject.Forms.AdvanceSeatBooking.Close();
            }
        }
        public void PassengerSU()
        {
            if (f == 5)
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Insert Into Passenger Values(" + PassengerNo.Text + ",'" + PassengerName.Text + "','" + PassengerAddress.Text + "','" + PassengerCity.Text + "','" + PassengerContact.Text + "')", con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Success... Next !");
                con.Close();
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Update Passenger Set Pname='" + PassengerName.Text + "',Paddress='" + PassengerAddress.Text + "',Pcity='" + PassengerCity.Text + "',Pcontact='" + PassengerContact.Text + "' Where Pno=" + PassengerNo.Text + "", con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Record is Updated !");
            }
        }
    }
}
