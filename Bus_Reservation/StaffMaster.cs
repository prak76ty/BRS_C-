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
    public partial class StaffMaster : Form
    {
        private void btnexit_Click(System.Object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnmain_Click(System.Object sender, System.EventArgs e)
        {
            FormControls("CLR");
        }

        private void StaffMaster_Load(System.Object sender, System.EventArgs e)
        {
            FormControls("CLR");
        }

        private void btnadd_Click(System.Object sender, System.EventArgs e)
        {
            FormControls("Save");
            StaffID.Text = Master.Add("Sid", "Staff");
            Master.S = 0;
        }

        private void btnsave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (Master.S == 0)
                {
                    if (StaffType.Text == "Select")
                    {
                        MessageBox.Show("Select an Valid Catagory");
                    }
                    else if (string.IsNullOrEmpty(StaffName.Text.Trim()) | string.IsNullOrEmpty(StaffAddress.Text.Trim()) | string.IsNullOrEmpty(StaffCity.Text.Trim()) | string.IsNullOrEmpty(StaffContact.Text.Trim()) | string.IsNullOrEmpty(StaffID.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing..!");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Save(6));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Insert Into Staff Values(" +  StaffID.Text + ",'" +  StaffName.Text + "','" +  StaffType.Text + "','" +  StaffAddress.Text + "','" +  StaffCity.Text + "','" +  StaffContact.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Success !");
                        FormControls("CLR");
                    }
                }
                else
                {
                    if (StaffType.Text == "Select")
                    {
                        MessageBox.Show("Select an Valid Catagory");
                    }
                    else if (string.IsNullOrEmpty(StaffName.Text.Trim()) | string.IsNullOrEmpty(StaffAddress.Text.Trim()) | string.IsNullOrEmpty(StaffCity.Text.Trim()) | string.IsNullOrEmpty(StaffContact.Text.Trim()) | string.IsNullOrEmpty(StaffID.Text.Trim()))
                    {
                        MessageBox.Show("Information is Missing..!");
                    }
                    else
                    {
                       // MessageBox.Show(Master.Update(6));
                        SqlConnection con = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();
                        con = new SqlConnection(Master.CS);
                        con.Open();
                        cmd = new SqlCommand("Update Staff Set Sname='" +  StaffName.Text + "',Stype='" +  StaffType.Text + "',Saddress='" +  StaffAddress.Text + "',Scity='" +  StaffCity.Text + "',Scontact='" +  StaffContact.Text + "' Where Sid=" +  StaffID.Text + "", con);
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
            if (res == DialogResult.Yes)
            {
                FormControls("Save");
                Master.S = 1;
            }
        }

        private void btndelete_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To Delete Record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				MessageBox.Show(Master.Delete("Sid", "Staff", StaffID.Text));
				FormControls("CLR");
			}
		}

        private void btnfind_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                string id = "";
                id = Interaction.InputBox("Plz Enter Staff ID:","Title","1",200,200);
                Master.Find("Sid", "Staff", id, 6);
                MoveLR();
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                btnadd.Enabled = false;
                StaffID.ReadOnly = true;
                StaffName.Enabled = false;
                StaffType.Enabled = false;
                StaffAddress.Enabled = false;
                StaffCity.Enabled = false;
                StaffContact.Enabled = false;
                Left1.Enabled = true;
                Right1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Record Found Or " + ex.Message);
            }
        }

        private void StaffName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }

        private void StaffContact_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (Strings.Asc(e.KeyChar) != 13 && Strings.Asc(e.KeyChar) != 8 && !Information.IsNumeric(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void StaffCity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == Strings.Chr(Keys.Delete)) & !(e.KeyChar == Strings.Chr(Keys.Back)) & !(e.KeyChar == Strings.Chr(Keys.Space)))
            //{
            //    e.Handled = true;
            //}
        }
        public void MoveLR()
        {
            StaffID.Text = Master.FindMe[0];
            StaffName.Text = Master.FindMe[1];
            StaffType.Text = Master.FindMe[2];
            StaffAddress.Text = Master.FindMe[3];
            StaffCity.Text = Master.FindMe[4];
            StaffContact.Text = Master.FindMe[5];
        }

        private void Left1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Master.Find("Sid", "Staff", Convert.ToString(Convert.ToInt32(StaffID.Text) - 1), 6);
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
                Master.Find("Sid", "Staff", Convert.ToString(Convert.ToInt32(StaffID.Text) + 1), 6);
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
                StaffID.Clear();
                StaffName.Clear();
                StaffType.Text = "Select";
                StaffAddress.Clear();
                StaffCity.Clear();
                StaffContact.Clear();
                StaffID.Enabled = false;
                StaffName.Enabled = false;
                StaffType.Enabled = false;
                StaffAddress.Enabled = false;
                StaffCity.Enabled = false;
                StaffContact.Enabled = false;
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
                StaffName.Enabled = true;
                StaffType.Enabled = true;
                StaffAddress.Enabled = true;
                StaffCity.Enabled = true;
                StaffContact.Enabled = true;
                StaffName.Focus();
            }
        }
        public StaffMaster()
        {
            Load += StaffMaster_Load;
            InitializeComponent();
        }
    }
}
