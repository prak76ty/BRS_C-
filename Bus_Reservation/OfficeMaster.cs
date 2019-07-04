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
    public partial class OfficeMaster : Form
    {
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
            OfficeID.Text = Master.Add("Oid", "Office");
            Master.O = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (Master.O == 0)
                {
                    if (string.IsNullOrEmpty(OfficeID.Text.Trim()) | string.IsNullOrEmpty(OWorkerName.Text.Trim()) | string.IsNullOrEmpty(Officeaddress.Text.Trim()) | string.IsNullOrEmpty(Officecity.Text.Trim()) | string.IsNullOrEmpty(Officecontact.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Enter Office Information..");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Save(4));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Insert Into Office Values(" +  OfficeID.Text + ",'" +  OWorkerName.Text + "','" +  Officeaddress.Text + "','" +  Officecity.Text + "','" +  Officecontact.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(OfficeID.Text.Trim()) | string.IsNullOrEmpty(OWorkerName.Text.Trim()) | string.IsNullOrEmpty(Officeaddress.Text.Trim()) | string.IsNullOrEmpty(Officecity.Text.Trim()) | string.IsNullOrEmpty(Officecontact.Text.Trim()))
                    {
                        MessageBox.Show("Plz.. Enter Office Information..");
                    }
                    else
                    {
                        //MessageBox.Show(Master.Update(4));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Update Office Set OWname='" +  OWorkerName.Text + "',Oaddress='" +  Officeaddress.Text + "',Ocity='" +  Officecity.Text + "',Ocontact='" +  Officecontact.Text + "' Where Oid=" +  OfficeID.Text + "", con);
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
				Master.O = 1;
			}
		}

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("Oid", "Office", OfficeID.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string id = "";
                id = Interaction.InputBox("Plz Enter Office ID:","Title","1",200,200);
                Master.Find("Oid", "Office", id, 5);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                OfficeID.ReadOnly = true;
                OWorkerName.Enabled = false;
                Officeaddress.Enabled = false;
                Officecity.Enabled = false;
                Officecontact.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found Or " + ex.Message);
            }
        }

        private void OWorkerName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void Officecontact_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (Strings.Asc(e.KeyChar) != 13 && Strings.Asc(e.KeyChar) != 8 && !Information.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void Officecity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }
        public void MoveLR()
        {
            OfficeID.Text = Master.FindMe[0];
            OWorkerName.Text = Master.FindMe[1];
            Officeaddress.Text = Master.FindMe[2];
            Officecity.Text = Master.FindMe[3];
            Officecontact.Text = Master.FindMe[4];
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Oid", "Office", Convert.ToString(Convert.ToInt32(OfficeID.Text) - 1), 5);
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
                Master.Find("Oid", "Office", Convert.ToString(Convert.ToInt32(OfficeID.Text) + 1), 5);
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
                OfficeID.Clear();
                OWorkerName.Clear();
                Officeaddress.Clear();
                Officecity.Clear();
                Officecontact.Clear();
                OfficeID.Enabled = false;
                OWorkerName.Enabled = false;
                Officeaddress.Enabled = false;
                Officecity.Enabled = false;
                Officecontact.Enabled = false;
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
                OWorkerName.Enabled = true;
                Officeaddress.Enabled = true;
                Officecity.Enabled = true;
                Officecontact.Enabled = true;
                OWorkerName.Focus();
            }
        }
        public OfficeMaster()
        {
            Load += PassengerMaster_Load;
            InitializeComponent();
        }

        private void OfficeMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
