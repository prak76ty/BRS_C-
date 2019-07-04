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

    public partial class CurrentSB : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int i;
        int j;
        private void Ending_Click_1(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                DGV.Rows.Clear();
                DGV2.Rows.Clear();
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (Strings.Format(DateAndTime.Today, "dd/MM/yyyy") == Strings.Format(BookingDate.Value, "dd/MM/yyyy"))
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

                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (Strings.Format(DateAndTime.Today, "dd/MM/yyyy") == Strings.Format(BookingDate.Value, "dd/MM/yyyy"))
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
                    i += 1;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Found or " + ex.Message);
            }
        }

        private void Button2_Click_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                DGV.Rows.Clear();
                DGV2.Rows.Clear();
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                if (Strings.Format(DateAndTime.Today, "dd/MM/yyyy") == Strings.Format(BookingDate.Value, "dd/MM/yyyy"))
                {
                    cmd = new SqlCommand("Select * From PaymentPassenger Where BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select * From APaymentPassenger Where BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
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
                if (Strings.Format(DateAndTime.Today, "dd/MM/yyyy") == Strings.Format(BookingDate.Value, "dd/MM/yyyy"))
                {
                    cmd = new SqlCommand("Select * From PassengerDetails Where BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select * From APassengerDetails Where BDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "'", con);
                }
                dr = cmd.ExecuteReader();
                j = 0;
                while (dr.Read())
                {
                    DGV2.Rows.Add();
                    DGV2[0, j].Value = Convert.ToString(dr.GetValue(0));
                    DGV2[1, j].Value = Convert.ToString(dr.GetValue(1));
                    DGV2[2, j].Value = Convert.ToString(dr.GetValue(2));
                    DGV2[3, j].Value = Convert.ToString(dr.GetValue(3));
                    DGV2[4, j].Value = Convert.ToString(dr.GetValue(4));
                    DGV2[5, j].Value = Convert.ToString(dr.GetValue(5));
                    DGV2[6, j].Value = Convert.ToString(dr.GetValue(6));
                    DGV2[7, j].Value = Convert.ToString(dr.GetValue(7));
                    DGV2[8, j].Value = Convert.ToString(dr.GetValue(8));
                    DGV2[9, j].Value = Convert.ToString(dr.GetValue(9));
                    DGV2[10, j].Value = Convert.ToString(dr.GetValue(10));
                    j += 1;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Found Or " + ex.Message);
            }

            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * From APaymentPassenger Where BookingDate='" + Strings.Format(BookingDate.Value, "dd/MM/yyyy") + "' and Not WaitingNo='" + "0" + "'", con);
                dr = cmd.ExecuteReader();
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
                MessageBox.Show("No Records Foundor Or " + ex.Message);
            }
        }
        public CurrentSB()
        {
            InitializeComponent();
        }

    }
}
