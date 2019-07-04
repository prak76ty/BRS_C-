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
    public partial class RouteMaster : Form
    {
        private void btnexit_Click(System.Object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void RouteMaster_Load(System.Object sender, System.EventArgs e)
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
            Rno.Text = Master.Add("Rno", "Route");
            Master.R = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (Master.R == 0)
                {
                    if (cmbdestination.Text == "Select" | cmbstartpoint.Text == "Select")
                    {
                        MessageBox.Show("Select an Valid Starting Point OR Destination");
                    }
                    else if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Pachora" | cmbstartpoint.Text == "Pune" & cmbdestination.Text == "Pune" | cmbstartpoint.Text == "Mumbai" & cmbdestination.Text == "Mumbai" | cmbstartpoint.Text == "Surat" & cmbdestination.Text == "Surat")
                    {
                        MessageBox.Show("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!");
                    }
                    else if (string.IsNullOrEmpty(FAmount.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Enter Fare Amount..");
                    }
                    else if (string.IsNullOrEmpty(TTime.Text.Trim()) | string.IsNullOrEmpty(TDistance.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Generate Your Route");
                    }
                    else
                    {
                        //MessageBox.Show(Master.Save(1));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Insert Into Route Values(" +  Rno.Text + ",'" +  RouteName.Text + "','" + Strings.Format( Arrivaltime.Value, "hh:mm:ss tt") + "','" + Strings.Format( Departuretime.Value, "hh:mm:ss tt") + "','" +  cmbstartpoint.Text + "','" +  cmbdestination.Text + "','" +  FAmount.Text + "','" +  TTime.Text + "','" +  TDistance.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
                else
                {
                    if (cmbdestination.Text == "Select" | cmbstartpoint.Text == "Select")
                    {
                        MessageBox.Show("Select an Valid Starting Point OR Destination");
                    }
                    else if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Pachora" | cmbstartpoint.Text == "Pune" & cmbdestination.Text == "Pune" | cmbstartpoint.Text == "Mumbai" & cmbdestination.Text == "Mumbai" | cmbstartpoint.Text == "Surat" & cmbdestination.Text == "Surat")
                    {
                        MessageBox.Show("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!");
                    }
                    else if (string.IsNullOrEmpty(FAmount.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Enter Fare Amount..");
                    }
                    else if (string.IsNullOrEmpty(TTime.Text.Trim()) | string.IsNullOrEmpty(TDistance.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Generate Your Route");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Update(1));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Update Route Set Rname='" +  RouteName.Text + "',Arrivaltime='" + Strings.Format( Arrivaltime.Value, "hh:mm tt") + "',Departuretime='" + Strings.Format( Departuretime.Value, "hh:mm tt") + "',Startingpoint='" +  cmbstartpoint.Text + "',Destination='" +  cmbdestination.Text + "',FareAmt='" +  FAmount.Text + "',TotalTime='" +  TTime.Text + "',TotalDistance='" +  TDistance.Text + "' Where Rno=" +  Rno.Text + "", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry.. Something Went Wrong..! Or " + ex.Message);
            }
        }

        private void btnedit_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				FormControls("Save");
				Master.R = 1;
			}
		}

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("Rno", "Route", Rno.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                String id = "";
                id = Interaction.InputBox("Plz Enter Route No:","Title","1",200,200);
                Master.Find("Rno", "Route", id, 9);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                Rno.ReadOnly = true;
                RouteName.Enabled = false;
                Arrivaltime.Enabled = false;
                Departuretime.Enabled = false;
                cmbstartpoint.Enabled = false;
                cmbdestination.Enabled = false;
                FAmount.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found???? Or " + ex.Message);
            }
        }

        private void btngenerate_Click(System.Object sender, System.EventArgs e)
        {
            TimeSpan interval = new TimeSpan(7, 0, 0);
            TimeSpan interval2 = new TimeSpan(6, 30, 0);
            TimeSpan interval3 = new TimeSpan(6, 0, 0);
            if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Pune" | cmbstartpoint.Text == "Pune" & cmbdestination.Text == "Pachora")
            {
                TDistance.Text = "347km";
                TTime.Text = "07:00";
                Departuretime.Value = Arrivaltime.Value + interval;
            }
            else if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Mumbai" | cmbstartpoint.Text == "Mumbai" & cmbdestination.Text == "Pachora")
            {
                TDistance.Text = "325km";
                TTime.Text = "06:30";
                Departuretime.Value = Arrivaltime.Value + interval2;
            }
            else if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Surat" | cmbstartpoint.Text == "Surat" & cmbdestination.Text == "Pachora")
            {
                TDistance.Text = "305km";
                TTime.Text = "06:00";
                Departuretime.Value = Arrivaltime.Value + interval3;
            }
            else if (cmbstartpoint.Text == "Pachora" & cmbdestination.Text == "Pachora" | cmbstartpoint.Text == "Pune" & cmbdestination.Text == "Pune" | cmbstartpoint.Text == "Mumbai" & cmbdestination.Text == "Mumbai" | cmbstartpoint.Text == "Surat" & cmbdestination.Text == "Surat")
            {
                MessageBox.Show("!!!!!!!Starting Point and Destination is Same.. Select Again!!!!!!!");
            }
            else if (cmbdestination.Text == "Select" | cmbstartpoint.Text == "Select")
            {
                MessageBox.Show("Select an Valid Category");
            }
            else
            {
                MessageBox.Show("Route is Not Available");
            }
        }

        private void Rname_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Rno", "Route", Convert.ToString(Convert.ToInt32(Rno.Text) - 1), 9);
                MoveLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records..Or " + ex.Message);
            }
        }
        public void MoveLR()
        {
            Rno.Text = Master.FindMe[0];
            RouteName.Text = Master.FindMe[1];
            Arrivaltime.Text = Master.FindMe[2];
            Departuretime.Text = Master.FindMe[3];
            cmbstartpoint.Text = Master.FindMe[4];
            cmbdestination.Text = Master.FindMe[5];
            FAmount.Text = Master.FindMe[6];
            TTime.Text = Master.FindMe[7];
            TDistance.Text = Master.FindMe[8];
        }

        private void Right1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Rno", "Route", Convert.ToString(Convert.ToInt32(Rno.Text) + 1), 9);
                MoveLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records..Or " + ex.Message);
            }
        }
        public void FormControls(string CLR)
        {
            if (CLR == "CLR")
            {
                Rno.Clear();
                RouteName.Clear();
                FAmount.Clear();
                cmbdestination.Text = "Select";
                cmbstartpoint.Text = "Select";
                TTime.Clear();
                TDistance.Clear();
                Arrivaltime.Value = Convert.ToDateTime(DateTime.Now);
                Departuretime.Value = Convert.ToDateTime(DateTime.Now);
                Rno.Enabled = false;
                RouteName.Enabled = false;
                FAmount.Enabled = false;
                cmbdestination.Enabled = false;
                cmbstartpoint.Enabled = false;
                Arrivaltime.Enabled = false;
                Departuretime.Enabled = false;
                btnsave.Enabled = false;
                btnedit.Enabled = false;
                btndelete.Enabled = false;
                btnadd.Enabled = true;
                btnfind.Enabled = true;
                btngenerate.Enabled = false;
                Left1.Enabled = false;
                Right1.Enabled = false;
            }
            if (CLR == "Save")
            {
                RouteName.Enabled = true;
                FAmount.Enabled = true;
                cmbdestination.Enabled = true;
                cmbstartpoint.Enabled = true;
                Arrivaltime.Enabled = true;
                Departuretime.Enabled = false;
                RouteName.Focus();
                btnsave.Enabled = true;
                btnadd.Enabled = false;
                btnfind.Enabled = false;
                btndelete.Enabled = false;
                btnedit.Enabled = false;
                btngenerate.Enabled = true;
            }
        }
        public RouteMaster()
        {
            Load += RouteMaster_Load;
            InitializeComponent();
        }
    }
}
