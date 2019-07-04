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
    public partial class BusMaster : Form
    {
        public int f;
        private void btnexit_Click(System.Object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void PassengerMaster_Load(System.Object sender, System.EventArgs e)
        {
            FormControls("CLR");
        }

        private void btnmain_Click(System.Object sender, System.EventArgs e)
        {
            FormControls("CLR");
        }

        private void btnadd_Click(System.Object sender, System.EventArgs e)
        {
            FormControls("Save");
            BusSerialNo.Text = Master.Add("BusSno", "Bus");
            f = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            if (f == 0)
            {
                if (BusNumber.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Catagory");
                }
                else if (BusRoute.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Type");
                }
                else if (BusType.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Size");
                }
                else if (BusReservation.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Company");
                }
                else
                {
                   // MessageBox.Show(Master.Save(2));
                    SqlConnection con = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    con = new SqlConnection(Master.CS);
                    con.Open();
                    cmd = new SqlCommand("Insert Into Bus Values(" + BusSerialNo.Text + ",'" + BusNumber.Text + "','" + BusRoute.Text + "','" + BusType.Text + "','" + BusReservation.Text + "','" + SeatCapacity.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Success !");
                    FormControls("CLR");
                }
            }
            else
            {
                if (BusNumber.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Catagory");
                }
                else if (BusRoute.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Type");
                }
                else if (BusType.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Size");
                }
                else if (BusReservation.Text == "Select")
                {
                    MessageBox.Show("Select an Valid Company");
                }
                else
                {
                   // MessageBox.Show(Master.Update(2));
                    SqlConnection con = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    con = new SqlConnection(Master.CS);
                    con.Open();
                    cmd = new SqlCommand("Update Bus Set BusNo='" +  BusNumber.Text + "',Route='" +  BusRoute.Text + "',Type='" +  BusType.Text + "',Reservation='" +  BusReservation.Text + "',SeatCapacity='" +  SeatCapacity.Text + "' Where BusSno=" +  BusSerialNo.Text + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Success !");
                    FormControls("CLR");
                }
            }
        }

        private void btnedit_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				FormControls("Save");
				f = 1;
			}
		}

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("BusSno", "Bus", BusSerialNo.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string id = "";
                id = Interaction.InputBox("Plz Enter Bus Serial No:","Title","1",200,200);
                Master.Find("BusSno", "Bus", id, 6);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                BusSerialNo.ReadOnly = true;
                BusNumber.Enabled = false;
                BusRoute.Enabled = false;
                BusType.Enabled = false;
                BusReservation.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found Or " + ex.Message);
            }
        }
        private void BusReservation_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (BusReservation.Text == "1x1")
            {
                SeatCapacity.Text = "40";
            }
            if (BusReservation.Text == "2x1")
            {
                SeatCapacity.Text = "60";
            }
            if (BusReservation.Text == "2x2")
            {
                SeatCapacity.Text = "80";
            }
        }
        public void MoveLR()
        {
            BusSerialNo.Text = Master.FindMe[0];
            BusNumber.Text = Master.FindMe[1];
            BusRoute.Text = Master.FindMe[2];
            BusType.Text = Master.FindMe[3];
            BusReservation.Text = Master.FindMe[4];
            SeatCapacity.Text = Master.FindMe[5];
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("BusSno", "Bus", Convert.ToString(Convert.ToInt32(BusSerialNo.Text) - 1), 6);
                MoveLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records.. Or " + ex.Message);
            }
        }

        private void Right1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("BusSno", "Bus", Convert.ToString(Convert.ToInt32(BusSerialNo.Text) + 1), 6);
                MoveLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records.. Or " + ex.Message);
            }
        }
        public void FormControls(string CLR)
        {
            if (CLR == "CLR")
            {
                BusSerialNo.Clear();
                BusNumber.Text = "Select";
                BusRoute.Text = "Select";
                BusType.Text = "Select";
                BusReservation.Text = "Select";
                BusSerialNo.Enabled = false;
                BusNumber.Enabled = false;
                BusRoute.Enabled = false;
                BusType.Enabled = false;
                BusReservation.Enabled = false;
                SeatCapacity.Clear();
                btnsave.Enabled = false;
                btnedit.Enabled = false;
                btndelete.Enabled = false;
                btnadd.Enabled = true;
                btnfind.Enabled = true;
                Left1.Enabled = false;
                Right1.Enabled = false;
            }
            if (CLR == "Save")
            {
                btnsave.Enabled = true;
                btnadd.Enabled = false;
                btnfind.Enabled = false;
                btndelete.Enabled = false;
                btnedit.Enabled = false;
                BusNumber.Enabled = true;
                BusRoute.Enabled = true;
                BusType.Enabled = true;
                BusReservation.Enabled = true;
                BusNumber.Focus();
            }
        }
        public BusMaster()
        {
            Load += PassengerMaster_Load;
            InitializeComponent();
        }

        private void BusMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
