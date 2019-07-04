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

    public partial class Login : Form
    {
        public int a;
        public string LIDT;
        public string LIDT2;
        private void btnclose_Click_1(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(System.Object sender, System.EventArgs e)
        {
            //Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True";
            con.Open();

            //command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username,password from Newuser where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";

            //data reader
            SqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            dr.Read();

            if (string.IsNullOrEmpty(txtusername.Text) & string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Plz Enter Username and Password.. Press OK");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
            else if (dr.HasRows)
            {
                dr.Close();
                cmd = new SqlCommand("select ID from Newuser where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                a = Convert.ToInt32(dr.GetValue(0));
                dr.Close();
                Master.LI(a);
                MessageBox.Show("You Are Connecting To Bus Reservation System... Press OK");
                this.Hide();
                MDI m1 = new MDI();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Wrong User.. Plz Enter Valid Username and Password Again.. Press OK");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
            dr.Close();
            con.Close();
        }

        private void Label6_Click_1(System.Object sender, System.EventArgs e)
        {
            Newuser a = new Newuser();
            a.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
      
        }
        public Login()
		{
			Load += Login_Load;
			InitializeComponent();
		}
       


    }
}
