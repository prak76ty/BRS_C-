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

    public partial class Newuser : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        int t;
        private void Button2_Click_1(System.Object sender, System.EventArgs e)
        {
            txtfullname.Clear();
            txtAK.Clear();
            txtmobile.Clear();
            txtpassword.Clear();
            txtusername.Clear();
            txtfullname.Focus();
        }

        private void Button1_Click_1(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfullname.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Full Name..");
            }
            else if (string.IsNullOrEmpty(txtmobile.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Mobile Number..");
            }
            else if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Username..");
            }
            else if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Password..");
            }
            else if (string.IsNullOrEmpty(txtAK.Text.Trim()))
            {
                MessageBox.Show("Plz.. Enter Access Key..");
            }
            else
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from  AKPrivate where KeyIMP='" + txtAK.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    cmd = new SqlCommand("Select max(ID) From Newuser", con);
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
                    txtID.Text = t.ToString();
                    dr.Close();
                    cmd = new SqlCommand("Insert Into Newuser values(" + txtID.Text + ",'" + txtfullname.Text + "','" + txtmobile.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Congratulations.. Successfully Registered");
                    con.Close();
                    txtID.Text = Master.Add("ID", "Newuser");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Access Key.. Try Again");
                }
            }
        }

        private void Newuser_Load(System.Object sender, System.EventArgs e)
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select max(ID) From Newuser", con);
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
            txtID.Text = t.ToString();
        }

        private void Button3_Click_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UName.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter UserName..");
                }
                else if (string.IsNullOrEmpty(OPassword.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter Old Password..");
                }
                else if (string.IsNullOrEmpty(NPassword.Text.Trim()) | string.IsNullOrEmpty(OPassword.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter New Password and Confirm it..");
                }
                else if (NPassword.Text != CPassword.Text)
                {
                    MessageBox.Show("Plz.. Password You Typed Did Not Match .. Plz Enter New Password Both Boxes..");
                }
                else if (string.IsNullOrEmpty(AK.Text.Trim()))
                {
                    MessageBox.Show("Plz.. Enter Access Key..");
                }
                else
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select username,password from Newuser where username='" + UName.Text + "' and password='" + OPassword.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cmd = new SqlCommand("select * from  AKPrivate where KeyIMP='" + AK.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            dr.Close();
                            cmd = new SqlCommand("Update Newuser Set password='" + NPassword.Text + "' Where username='" + UName.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password Changed Successfully..!");
                            AK.Clear();
                            NPassword.Clear();
                            CPassword.Clear();
                            OPassword.Clear();
                            UName.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Access Key..!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username and Password..!");
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry.. Something Went Wrong..! Or " + ex.Message);
            }
        }
        public Newuser()
        {
            Load += Newuser_Load;
            InitializeComponent();
        }
    }
}
