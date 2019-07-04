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

    public partial class MDI : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void EXITToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult res = MessageBox.Show("Do U Want To LOG OFF?", "LOG OFF?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				Master.LR();
				Application.Exit();
			} else {
				this.Show();
			}
		}

        private void ROUTEMASTERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RouteMaster r1 = new RouteMaster();
            r1.MdiParent = this;
            r1.Show();
            r1.BringToFront();
        }

        private void PASSENGERMASTERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            PassengerMaster p1 = new PassengerMaster();
            p1.MdiParent = this;
            p1.Show();
            p1.BringToFront();
        }

        private void STAFFMASTERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            StaffMaster s1 = new StaffMaster();
            s1.MdiParent = this;
            s1.Show();
            s1.BringToFront();
        }

        private void BUSMASTERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            BusMaster b1 = new BusMaster();
            b1.MdiParent = this;
            b1.Show();
            b1.BringToFront();
        }

        private void OFFCEMASTERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            OfficeMaster o1 = new OfficeMaster();
            o1.MdiParent = this;
            o1.Show();
            o1.BringToFront();
        }

        private void DRIVERMASTEToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            DriverMaster d1 = new DriverMaster();
            d1.MdiParent = this;
            d1.Show();
            d1.BringToFront();
        }

        private void SEATBOOKINGToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            SeatBooking s1 = new SeatBooking();
            s1.MdiParent = this;
            s1.Show();
            s1.BringToFront();
        }

        private void BOOKINGCANCELLATIONToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            BookingCancellation b1 = new BookingCancellation();
            b1.MdiParent = this;
            b1.Show();
            b1.BringToFront();
        }


        private void CurrentBookedSeatToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            CurrentSB c1 = new CurrentSB();
            c1.MdiParent = this;
            c1.Show();
            c1.BringToFront();
        }

        private void CancelledSeatsToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            CancellationSB c2 = new CancellationSB();
            c2.MdiParent = this;
            c2.Show();
            c2.BringToFront();
        }

        private void CompletedBookingToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            CompletedSB c3 = new CompletedSB();
            c3.MdiParent = this;
            c3.Show();
            c3.BringToFront();
        }

        private void ADVANCEBOOKINGToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            AdvanceSeatBooking a1 = new AdvanceSeatBooking();
            a1.MdiParent = this;
            a1.Show();
            a1.BringToFront();
        }

        private void ADVANCEBOOKINGCANCELLATIONToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            AdvanceBookingCancellation a2 = new AdvanceBookingCancellation();
            a2.MdiParent = this;
            a2.Show();
            a2.BringToFront();
        }

        private void ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            WaitingList w1 = new WaitingList();
            w1.MdiParent = this;
            w1.Show();
            w1.BringToFront();
        }

        private void MDI_Disposed(object sender, System.EventArgs e)
        {
            Master.LR();
            Application.Exit();
        }
        private void MDI_Load(System.Object sender, System.EventArgs e)
        {
            Master.Completed();
            RealMDI r1 = new RealMDI();
            r1.MdiParent = this;
            r1.Show();
        }

        private void CLEARCURRENTBOOKINGToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            CLEAR Current = new CLEAR("C");
            Current.Show();
            Current.BringToFront();
        }

        private void CLEARADVANCEBOOKINGToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            CLEAR Advance = new CLEAR("A");
            Advance.Show();
            Advance.BringToFront();
        }

        private void CLEARCANCELLATIONBOOKINGToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            CLEAR CancellationB = new CLEAR("Canc");
            CancellationB.Show();
            CancellationB.BringToFront();
        }

        private void CLEARCOMPLETEDBOOKINGSToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            CLEAR CompletedB = new CLEAR("Comp");
            CompletedB.Show();
            CompletedB.BringToFront();
        }

        private void CLEARALLBOOKINGSToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            CLEAR All = new CLEAR("All");
            All.Show();
            All.BringToFront();
        }

        private void ROUTEToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            RRouteMaster r1 = new RRouteMaster();
            r1.MdiParent = this;
            r1.Show();
            r1.BringToFront();
        }

        private void BUSToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            BusMaster b1 = new BusMaster();
            b1.MdiParent = this;
            b1.Show();
            b1.BringToFront();
        }

        private void PASSENGERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RPassengerMaster p2 = new RPassengerMaster();
            p2.MdiParent = this;
            p2.Show();
            p2.BringToFront();
        }

        private void DRIVERToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RDriverMaster d1 = new RDriverMaster();
            d1.MdiParent = this;
            d1.Show();
            d1.BringToFront();
        }

        private void STAFFToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RStaffMaster s2 = new RStaffMaster();
            s2.MdiParent = this;
            s2.Show();
            s2.BringToFront();
        }

        private void OFFICEToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            ROfficeMaster o1 = new ROfficeMaster();
            o1.MdiParent = this;
            o1.Show();
            o1.BringToFront();
        }

        private void CLEARALLMASTERDATAToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CLEAR MF = new CLEAR("MF");
            MF.Show();
            MF.BringToFront();
        }

        private void LOGINRECORDSToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RLoginRecords l1 = new RLoginRecords();
            l1.MdiParent = this;
            l1.Show();
            l1.BringToFront();
        }

        private void CURRENTBOOKINGREPORTToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RBookingCurrent c1 = new RBookingCurrent();
            c1.MdiParent = this;
            c1.Show();
            c1.BringToFront();
        }

        private void ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RBookingAdvanceWaiting a2 = new RBookingAdvanceWaiting();
            a2.MdiParent = this;
            a2.Show();
            a2.BringToFront();
        }

        private void COMPLETEDBOOKINGREPORTSToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RBookingCompleted c3 = new RBookingCompleted();
            c3.MdiParent = this;
            c3.Show();
            c3.BringToFront();
        }

        private void CANCELLATIONBOOKINGREPORTToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
        {
            RBookingCancellation c2 = new RBookingCancellation();
            c2.MdiParent = this;
            c2.Show();
            c2.BringToFront();
        }
        public MDI()
        {
            Load += MDI_Load;
            Disposed += MDI_Disposed;
            InitializeComponent();
        }

        private void EXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do U Want To LOG OFF?", "LOG OFF?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes) {
				Master.LR();
				Application.Exit();
			} else {
				this.Show();
			}
        }
    }
}
