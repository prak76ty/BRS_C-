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
    public partial class DriverMaster : Form
    {
        public int D;
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
            DriverID.Text = Master.Add("Did", "Driver");
            D = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (D == 0)
                {
                    if (string.IsNullOrEmpty(DriverID.Text.Trim()) | string.IsNullOrEmpty(DriverName.Text.Trim()) | string.IsNullOrEmpty(DriverAddress.Text.Trim()) | string.IsNullOrEmpty(Drivercity.Text.Trim()) | string.IsNullOrEmpty(DriverAge.Text.Trim()) | string.IsNullOrEmpty(DriverContact.Text.Trim()) | string.IsNullOrEmpty(DriverLicense.Text.Trim()) | string.IsNullOrEmpty(DriverSalary.Text.Trim()) | string.IsNullOrEmpty(DriverQualification.Text.Trim()) | string.IsNullOrEmpty(DriverReference.Text.Trim()) | string.IsNullOrEmpty(DriverConctact2.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing..");
                    }
                    else
                    {
                        //MessageBox.Show(Master.Save(3));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Insert Into Driver Values(" + DriverID.Text + ",'" + DriverName.Text + "','" + DriverAddress.Text + "','" + Drivercity.Text + "','" + DriverAge.Text + "','" + DriverContact.Text + "','" + DriverLicense.Text + "','" + DateJoining.Value + "','" + DriverSalary.Text + "','" + DriverQualification.Text + "','" + DriverReference.Text + "','" + DriverConctact2.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(DriverID.Text.Trim()) | string.IsNullOrEmpty(DriverName.Text.Trim()) | string.IsNullOrEmpty(DriverAddress.Text.Trim()) | string.IsNullOrEmpty(Drivercity.Text.Trim()) | string.IsNullOrEmpty(DriverAge.Text.Trim()) | string.IsNullOrEmpty(DriverContact.Text.Trim()) | string.IsNullOrEmpty(DriverLicense.Text.Trim()) | string.IsNullOrEmpty(DriverSalary.Text.Trim()) | string.IsNullOrEmpty(DriverQualification.Text.Trim()) | string.IsNullOrEmpty(DriverReference.Text.Trim()) | string.IsNullOrEmpty(DriverConctact2.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing..");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Update(3));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Update Driver Set Dname='" +  DriverName.Text + "',Daddress='" +  DriverAddress.Text + "',Dcity='" +  Drivercity.Text + "',Dage='" +  DriverAge.Text + "',Dcontact='" +  DriverContact.Text + "',Dlicense='" +  DriverLicense.Text + "',Djoiningdate='" +  DateJoining.Value + "',Dsalary='" +  DriverSalary.Text + "',Dqualification='" +  DriverQualification.Text + "',Dreference='" +  DriverReference.Text + "',Dcontact2='" +  DriverConctact2.Text + "' Where Did=" +  DriverID.Text + "", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnedit_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Edit Record?", "UPdate Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				FormControls("Save");
				D = 1;
			}
		}

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("Did", "Driver", DriverID.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string id = "";
                id = Interaction.InputBox("Plz Enter Driver ID:","Title","1",200,200);
                Master.Find("Did", "Driver", id, 12);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                DriverID.ReadOnly = true;
                DriverName.Enabled = false;
                DriverAddress.Enabled = false;
                Drivercity.Enabled = false;
                DriverContact.Enabled = false;
                DriverAge.Enabled = false;
                DriverLicense.Enabled = false;
                DateJoining.Enabled = false;
                DriverSalary.Enabled = false;
                DriverQualification.Enabled = false;
                DriverReference.Enabled = false;
                DriverConctact2.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found Or " + ex.Message);
            }
        }

        private void DriverName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void DriverContact_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (Strings.Asc(e.KeyChar) != 13 && Strings.Asc(e.KeyChar) != 8 && !Information.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void DriverConctact2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (Strings.Asc(e.KeyChar) != 13 && Strings.Asc(e.KeyChar) != 8 && !Information.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void Drivercity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }
        public void MoveLR()
        {
            DriverID.Text = Master.FindMe[0];
            DriverName.Text = Master.FindMe[1];
            DriverAddress.Text = Master.FindMe[2];
            Drivercity.Text = Master.FindMe[3];
            DriverAge.Text = Master.FindMe[4];
            DriverContact.Text = Master.FindMe[5];
            DriverLicense.Text = Master.FindMe[6];
            DateJoining.Text = Master.FindMe[7];
            DriverSalary.Text = Master.FindMe[8];
            DriverQualification.Text = Master.FindMe[9];
            DriverReference.Text = Master.FindMe[10];
            DriverConctact2.Text = Master.FindMe[11];
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Did", "Driver", Convert.ToString(Convert.ToInt32(DriverID.Text) - 1), 12);
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
                Master.Find("Did", "Driver", Convert.ToString(Convert.ToInt32(DriverID.Text) + 1), 12);
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
                DriverID.Enabled = false;
                DriverName.Enabled = false;
                DriverAddress.Enabled = false;
                Drivercity.Enabled = false;
                DriverContact.Enabled = false;
                DriverAge.Enabled = false;
                DriverLicense.Enabled = false;
                DateJoining.Enabled = false;
                DriverSalary.Enabled = false;
                DriverQualification.Enabled = false;
                DriverReference.Enabled = false;
                DriverConctact2.Enabled = false;
                DriverID.Clear();
                DriverName.Clear();
                DriverAddress.Clear();
                Drivercity.Clear();
                DriverAge.Clear();
                DriverContact.Clear();
                DriverLicense.Clear();
                DriverSalary.Clear();
                DriverQualification.Clear();
                DriverReference.Clear();
                DriverConctact2.Clear();
                DateJoining.Value = DateTime.Now;
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
                DriverName.Enabled = true;
                DriverAddress.Enabled = true;
                Drivercity.Enabled = true;
                DriverContact.Enabled = true;
                DriverAge.Enabled = true;
                DriverLicense.Enabled = true;
                DateJoining.Enabled = true;
                DriverSalary.Enabled = true;
                DriverQualification.Enabled = true;
                DriverReference.Enabled = true;
                DriverConctact2.Enabled = true;
                btnsave.Enabled = true;
                btnadd.Enabled = false;
                btnfind.Enabled = false;
                btndelete.Enabled = false;
                btnedit.Enabled = false;
            }
        }
        public DriverMaster()
        {
            Load += PassengerMaster_Load;
            InitializeComponent();
        }

        private void DriverMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
