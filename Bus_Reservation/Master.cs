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
    static class Master
    {
        static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader dr;
        public static int t;
        public static int ID;
        public static int CID;
        public static int f;
        public static int R;
        public static int O;
        public static int S;
        public static string a1,a2,a3,a4,s1,s2,s3,s4;
        public static string[] FindMe = new string[255];
        public static string LIDT;
        public static int getme;

        public static string CS = "Data Source=.\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True";
        public static string Add(string MAX, string Table)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Select max(" + MAX + ") From " + Table, con);
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
            ID = t;
            dr.Close();
            con.Close();
            return ID.ToString();
        }

        public static string Delete(string MAX, string Table, string Key)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Delete From " + Table + " Where " + MAX + "=" + Key + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Record Deleted !";
        }

        public static void Find(string MAX, string Table, string Key, int Size)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Select * From " + Table + " Where " + MAX + "=" + Key + "", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (Size >= 5)
            {
                FindMe[0] = Convert.ToString(dr.GetValue(0));
                FindMe[1] = Convert.ToString(dr.GetValue(1));
                FindMe[2] = Convert.ToString(dr.GetValue(2));
                FindMe[3] = Convert.ToString(dr.GetValue(3));
                FindMe[4] = Convert.ToString(dr.GetValue(4));
            }
            if (Size >= 6)
            {
                FindMe[5] = Convert.ToString(dr.GetValue(5));
            }
            if (Size >= 9)
            {
                FindMe[6] = Convert.ToString(dr.GetValue(6));
                FindMe[7] = Convert.ToString(dr.GetValue(7));
                FindMe[8] = Convert.ToString(dr.GetValue(8));
            }
            if (Size >= 12)
            {
                FindMe[9] = Convert.ToString(dr.GetValue(9));
                FindMe[10] = Convert.ToString(dr.GetValue(10));
                FindMe[11] = Convert.ToString(dr.GetValue(11));
            }
            dr.Close();
            con.Close();
        }

        //public static string Save(int Key)
        //{
        //    con = new SqlConnection(CS);
        //    con.Open();
        //    if (Key == 1)
        //    {
        //        cmd = new SqlCommand("Insert Into Route Values(" + RouteMaster.Rno.Text + ",'" + RouteMaster.RouteName.Text + "','" + Strings.Format(RouteMaster.Arrivaltime.Value, "hh:mm:ss tt") + "','" + Strings.Format(RouteMaster.Departuretime.Value, "hh:mm:ss tt") + "','" + RouteMaster.cmbstartpoint.Text + "','" + RouteMaster.cmbdestination.Text + "','" + RouteMaster.FAmount.Text + "','" + RouteMaster.TTime.Text + "','" + RouteMaster.TDistance.Text + "')", con);
        //    }
        //    else if (Key == 2)
        //    {
        //        cmd = new SqlCommand("Insert Into Bus Values(" + My.MyProject.Forms.BusMaster.BusSerialNo.Text + ",'" + My.MyProject.Forms.BusMaster.BusNumber.Text + "','" + My.MyProject.Forms.BusMaster.BusRoute.Text + "','" + My.MyProject.Forms.BusMaster.BusType.Text + "','" + My.MyProject.Forms.BusMaster.BusReservation.Text + "','" + My.MyProject.Forms.BusMaster.SeatCapacity.Text + "')", con);
        //    }
        //    else if (Key == 3)
        //    {
        //        cmd = new SqlCommand("Insert Into Driver Values(" + My.MyProject.Forms.DriverMaster.DriverID.Text + ",'" + My.MyProject.Forms.DriverMaster.DriverName.Text + "','" + My.MyProject.Forms.DriverMaster.DriverAddress.Text + "','" + My.MyProject.Forms.DriverMaster.Drivercity.Text + "','" + My.MyProject.Forms.DriverMaster.DriverAge.Text + "','" + My.MyProject.Forms.DriverMaster.DriverContact.Text + "','" + My.MyProject.Forms.DriverMaster.DriverLicense.Text + "','" + My.MyProject.Forms.DriverMaster.DateJoining.Value + "','" + My.MyProject.Forms.DriverMaster.DriverSalary.Text + "','" + My.MyProject.Forms.DriverMaster.DriverQualification.Text + "','" + My.MyProject.Forms.DriverMaster.DriverReference.Text + "','" + My.MyProject.Forms.DriverMaster.DriverConctact2.Text + "')", con);
        //    }
        //    else if (Key == 4)
        //    {
        //        cmd = new SqlCommand("Insert Into Office Values(" + OfficeMaster.OfficeID.Text + ",'" + OfficeMaster.OWorkerName.Text + "','" + OfficeMaster.Officeaddress.Text + "','" + OfficeMaster.Officecity.Text + "','" + OfficeMaster.Officecontact.Text + "')", con);
        //    }
        //    else if (Key == 5)
        //    {
        //        cmd = new SqlCommand("Insert Into Passenger Values(" + PassengerMaster.PassengerNo.Text + ",'" + PassengerMaster.PassengerName.Text + "','" + PassengerMaster.PassengerAddress.Text + "','" + PassengerMaster.PassengerCity.Text + "','" + PassengerMaster.PassengerContact.Text + "')", con);
        //    }
        //    else if (Key == 6)
        //    {
        //        cmd = new SqlCommand("Insert Into Staff Values(" + StaffMaster.StaffID.Text + ",'" + StaffMaster.StaffName.Text + "','" + StaffMaster.StaffType.Text + "','" + StaffMaster.StaffAddress.Text + "','" + StaffMaster.StaffCity.Text + "','" + StaffMaster.StaffContact.Text + "')", con);
        //    }
        //    cmd.ExecuteNonQuery();
        //    return "Success... !";
        //}

        //public static string Update(int Key)
        //{
        //    con = new SqlConnection(CS);
        //    con.Open();
        //    if (Key == 1)
        //    {
        //        cmd = new SqlCommand("Update Route Set Rname='" + RouteMaster.RouteName.Text + "',Arrivaltime='" + Strings.Format(RouteMaster.Arrivaltime.Value, "hh:mm tt") + "',Departuretime='" + Strings.Format(RouteMaster.Departuretime.Value, "hh:mm tt") + "',Startingpoint='" + RouteMaster.cmbstartpoint.Text + "',Destination='" + RouteMaster.cmbdestination.Text + "',FareAmt='" + RouteMaster.FAmount.Text + "',TotalTime='" + RouteMaster.TTime.Text + "',TotalDistance='" + RouteMaster.TDistance.Text + "' Where Rno=" + RouteMaster.Rno.Text + "", con);
        //    }
        //    else if (Key == 2)
        //    {
        //        cmd = new SqlCommand("Update Bus Set BusNo='" + My.MyProject.Forms.BusMaster.BusNumber.Text + "',Route='" + My.MyProject.Forms.BusMaster.BusRoute.Text + "',Type='" + My.MyProject.Forms.BusMaster.BusType.Text + "',Reservation='" + My.MyProject.Forms.BusMaster.BusReservation.Text + "',SeatCapacity='" + My.MyProject.Forms.BusMaster.SeatCapacity.Text + "' Where BusSno=" + My.MyProject.Forms.BusMaster.BusSerialNo.Text + "", con);
        //    }
        //    else if (Key == 3)
        //    {
        //        cmd = new SqlCommand("Update Driver Set Dname='" + My.MyProject.Forms.DriverMaster.DriverName.Text + "',Daddress='" + My.MyProject.Forms.DriverMaster.DriverAddress.Text + "',Dcity='" + My.MyProject.Forms.DriverMaster.Drivercity.Text + "',Dage='" + My.MyProject.Forms.DriverMaster.DriverAge.Text + "',Dcontact='" + My.MyProject.Forms.DriverMaster.DriverContact.Text + "',Dlicense='" + My.MyProject.Forms.DriverMaster.DriverLicense.Text + "',Djoiningdate='" + My.MyProject.Forms.DriverMaster.DateJoining.Value + "',Dsalary='" + My.MyProject.Forms.DriverMaster.DriverSalary.Text + "',Dqualification='" + My.MyProject.Forms.DriverMaster.DriverQualification.Text + "',Dreference='" + My.MyProject.Forms.DriverMaster.DriverReference.Text + "',Dcontact2='" + My.MyProject.Forms.DriverMaster.DriverConctact2.Text + "' Where Did=" + My.MyProject.Forms.DriverMaster.DriverID.Text + "", con);
        //    }
        //    else if (Key == 4)
        //    {
        //        cmd = new SqlCommand("Update Office Set OWname='" + OfficeMaster.OWorkerName.Text + "',Oaddress='" + OfficeMaster.Officeaddress.Text + "',Ocity='" + OfficeMaster.Officecity.Text + "',Ocontact='" + OfficeMaster.Officecontact.Text + "' Where Oid=" + OfficeMaster.OfficeID.Text + "", con);
        //    }
        //    else if (Key == 5)
        //    {
        //        cmd = new SqlCommand("Update Passenger Set Pname='" + PassengerMaster.PassengerName.Text + "',Paddress='" + PassengerMaster.PassengerAddress.Text + "',Pcity='" + PassengerMaster.PassengerCity.Text + "',Pcontact='" + PassengerMaster.PassengerContact.Text + "' Where Pno=" + PassengerMaster.PassengerNo.Text + "", con);
        //    }
        //    else if (Key == 6)
        //    {
        //        cmd = new SqlCommand("Update Staff Set Sname='" + StaffMaster.StaffName.Text + "',Stype='" + StaffMaster.StaffType.Text + "',Saddress='" + StaffMaster.StaffAddress.Text + "',Scity='" + StaffMaster.StaffCity.Text + "',Scontact='" + StaffMaster.StaffContact.Text + "' Where Sid=" + StaffMaster.StaffID.Text + "", con);
        //    }
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return "Record is Updated !";
        //}
        public static void Completed()
        {
            System.DateTime BD = default(System.DateTime);
            System.DateTime BD2 = default(System.DateTime);
            int Bno = 0;
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Select Distinct BookingDate,BookingNo From APaymentPassenger Where WaitingNo=" + "0" + "", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BD2 = Convert.ToDateTime(dr.GetValue(0));
                Bno = Convert.ToInt32(dr.GetValue(1));
                if (DateAndTime.Today >= BD2)
                {
                    dr.Close();
                    cmd = new SqlCommand("Insert Into PaymentPassenger Select * From APaymentPassenger Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Insert Into PassengerDetails Select * From APassengerDetails Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Delete From APassengerDetails Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Delete From APaymentPassenger Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Select Distinct BookingDate,BookingNo From APaymentPassenger Where WaitingNo=" + "0" + "", con);
                    dr = cmd.ExecuteReader();
                }
            }
            dr.Close();

            cmd = new SqlCommand("Select Distinct BookingDate,BookingNo From PaymentPassenger", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BD = Convert.ToDateTime(dr.GetValue(0));
                Bno = Convert.ToInt32(dr.GetValue(1));
                if (DateAndTime.Today > BD)
                {
                    dr.Close();
                    cmd = new SqlCommand("Insert Into CompletedPP Select * From PaymentPassenger Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Insert Into CompletedPassenger Select * From PassengerDetails Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Delete From PassengerDetails Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Delete From PaymentPassenger Where BookingNo=" + Bno + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Select Distinct BookingDate,BookingNo From PaymentPassenger", con);
                    dr = cmd.ExecuteReader();
                }
            }
            dr.Close();
            con.Close();
        }
        public static void clear(string PP, string PD)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("delete from " + PP + "", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from " + PD + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static string AddCount(string MAX, string Table)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Select COUNT(" + MAX + ") From " + Table, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            CID = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            con.Close();
            return CID.ToString();
        }
        public static string AddCount(string MAX, string Table, string Condition, string Value)
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Select COUNT(" + MAX + ") From " + Table + " Where " + Condition + "='" + Value + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            CID = Convert.ToInt32(dr.GetValue(0));
            dr.Close();
            con.Close();
            return CID.ToString();
        }
        public static void LR()
        {
            con = new SqlConnection(CS);
            con.Open();
            cmd = new SqlCommand("Update LoginRecords Set LogoutDateTime='" + DateTime.Now + "' Where LogInDateTime='" + LIDT + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void LI(int a)
        {
            getme=a;
            con = new SqlConnection(CS);
            con.Open();
            LIDT = Convert.ToString(DateTime.Now);
            cmd = new SqlCommand("Insert Into LoginRecords(ID,LogInDateTime) Values(" + getme + ",'" + LIDT + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void getinfoA(string a,string b,string c,string d)
        {
            a1 = a;
            a2 = b;
            a3 = c;
            a4 = d;
        }
        public static void getinfos(string a, string b, string c, string d)
        {
            s1 = a;
            s2 = b;
            s3 = c;
            s4 = d;
        }
    }
}
