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
    public partial class RealMDI : Form
    {
        public int id;
        public string Uname;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        SqlDataReader dr;
        private void RealMDI_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void RealMDI_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void RealMDI_Load(System.Object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void Insert_Click_1(System.Object sender, System.EventArgs e)
		{
            DialogResult res = MessageBox.Show("Do U Want To LOG OFF?", "LOG OFF?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				Master.LR();
				Application.Exit();
			} else {
				this.Show();
			}
		}
        public void LoadData()
        {
            MDI m1 = new MDI();
           // this.Size = m1.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            id = Master.getme;
            if (id == 0)
            {
                id = 1;
            }
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select Fullname From Newuser where ID='" + id + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Label2.Text = Convert.ToString(dr.GetValue(0));
            dr.Close();
            Route.Text = Master.AddCount("Rno", "Route");
            Bus.Text = Master.AddCount("BusSno", "Bus");
            Passenger.Text = Master.AddCount("Pno", "Passenger");
            Driver.Text = Master.AddCount("Did", "Driver");
            Staff.Text = Master.AddCount("Sid", "Staff");
            Office.Text = Master.AddCount("Oid", "Office");
            Current.Text = Master.AddCount("BookingNo", "PaymentPassenger");
            Cancellation.Text = Master.AddCount("BookingNo", "Cancellation");
            Completed.Text = Master.AddCount("BookingNo", "CompletedPP");
            Advance.Text = Master.AddCount("BookingNo", "APaymentPassenger", "WaitingNo", "0");
            Waiting.Text = Master.AddCount("BookingNo", "APaymentPassenger", "Not WaitingNo", "0");
        }
        public RealMDI()
        {
            Load += RealMDI_Load;
            FormClosing += RealMDI_FormClosing;
            Click += RealMDI_Click;
            InitializeComponent();
        }

       
    }
}
