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
    public partial class PassengerMaster : Form
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
            PassengerNo.Text = Master.Add("Pno", "Passenger");
            Master.f = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (Master.f == 0)
                {
                    if (string.IsNullOrEmpty(PassengerNo.Text.Trim()) | string.IsNullOrEmpty(PassengerName.Text.Trim()) | string.IsNullOrEmpty(PassengerAddress.Text.Trim()) | string.IsNullOrEmpty(PassengerCity.Text.Trim()) | string.IsNullOrEmpty(PassengerContact.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing.. !");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Save(5));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Insert Into Passenger Values(" +  PassengerNo.Text + ",'" +  PassengerName.Text + "','" +  PassengerAddress.Text + "','" +  PassengerCity.Text + "','" +  PassengerContact.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(PassengerNo.Text.Trim()) | string.IsNullOrEmpty(PassengerName.Text.Trim()) | string.IsNullOrEmpty(PassengerAddress.Text.Trim()) | string.IsNullOrEmpty(PassengerCity.Text.Trim()) | string.IsNullOrEmpty(PassengerContact.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing.. !");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Update(5));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Update Passenger Set Pname='" +  PassengerName.Text + "',Paddress='" +  PassengerAddress.Text + "',Pcity='" +  PassengerCity.Text + "',Pcontact='" +  PassengerContact.Text + "' Where Pno=" +  PassengerNo.Text + "", con);
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
				Master.f = 1;
			}
		}

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("Pno", "Passenger", PassengerNo.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string id = "";
                id = Interaction.InputBox("Plz Enter Passenger No:","Title","1",200,200);
                Master.Find("Pno", "Passenger", id, 5);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                PassengerNo.ReadOnly = true;
                PassengerName.Enabled = false;
                PassengerAddress.Enabled = false;
                PassengerCity.Enabled = false;
                PassengerContact.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found Or " + ex.Message);
            }
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
        public void MoveLR()
        {
            PassengerNo.Text = Master.FindMe[0];
            PassengerName.Text = Master.FindMe[1];
            PassengerAddress.Text = Master.FindMe[2];
            PassengerCity.Text = Master.FindMe[3];
            PassengerContact.Text = Master.FindMe[4];
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Pno", "Passenger", Convert.ToString(Convert.ToInt32(PassengerNo.Text) - 1), 5);
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
                Master.Find("Pno", "Passenger", Convert.ToString(Convert.ToInt32(PassengerNo.Text) + 1), 5);
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
                PassengerNo.Clear();
                PassengerName.Clear();
                PassengerAddress.Clear();
                PassengerCity.Clear();
                PassengerContact.Clear();
                PassengerNo.Enabled = false;
                PassengerName.Enabled = false;
                PassengerAddress.Enabled = false;
                PassengerCity.Enabled = false;
                PassengerContact.Enabled = false;
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
                PassengerName.Enabled = true;
                PassengerAddress.Enabled = true;
                PassengerCity.Enabled = true;
                PassengerContact.Enabled = true;
                PassengerName.Focus();
            }
        }
        public PassengerMaster()
        {
            Load += PassengerMaster_Load;
            InitializeComponent();
        }
    }
}
