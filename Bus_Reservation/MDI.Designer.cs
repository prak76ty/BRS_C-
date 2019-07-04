namespace Bus_Reservation
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.ROUTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MASTERFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ROUTEMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BUSMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PASSENGERMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DRIVERMASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STAFFMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFFCEMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TRANSACTIONFROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SEATBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BOOKINGCANCELLATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADVANCEBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentBookedSeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelledSeatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompletedBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RESETDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARCURRENTBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARADVANCEBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARALLBOOKINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLEARALLMASTERDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PASSENGERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DRIVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFFICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGINRECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BOOKINGREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CURRENTBOOKINGREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ROUTEToolStripMenuItem
            // 
            this.ROUTEToolStripMenuItem.Name = "ROUTEToolStripMenuItem";
            this.ROUTEToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ROUTEToolStripMenuItem.Text = "ROUTE";
            this.ROUTEToolStripMenuItem.Click += new System.EventHandler(this.ROUTEToolStripMenuItem_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASTERFORMToolStripMenuItem,
            this.TRANSACTIONFROMToolStripMenuItem,
            this.REPORTToolStripMenuItem,
            this.RESETDATAToolStripMenuItem,
            this.REPORTSToolStripMenuItem,
            this.BOOKINGREPORTSToolStripMenuItem,
            this.ABOUTToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(999, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // MASTERFORMToolStripMenuItem
            // 
            this.MASTERFORMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ROUTEMASTERToolStripMenuItem,
            this.BUSMASTERToolStripMenuItem,
            this.PASSENGERMASTERToolStripMenuItem,
            this.DRIVERMASTEToolStripMenuItem,
            this.STAFFMASTERToolStripMenuItem,
            this.OFFCEMASTERToolStripMenuItem});
            this.MASTERFORMToolStripMenuItem.Name = "MASTERFORMToolStripMenuItem";
            this.MASTERFORMToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.MASTERFORMToolStripMenuItem.Text = "MASTER FORM";
            // 
            // ROUTEMASTERToolStripMenuItem
            // 
            this.ROUTEMASTERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ROUTEMASTERToolStripMenuItem.Name = "ROUTEMASTERToolStripMenuItem";
            this.ROUTEMASTERToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ROUTEMASTERToolStripMenuItem.Text = "ROUTE MASTER";
            this.ROUTEMASTERToolStripMenuItem.Click += new System.EventHandler(this.ROUTEMASTERToolStripMenuItem_Click_1);
            // 
            // BUSMASTERToolStripMenuItem
            // 
            this.BUSMASTERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.BUSMASTERToolStripMenuItem.Name = "BUSMASTERToolStripMenuItem";
            this.BUSMASTERToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.BUSMASTERToolStripMenuItem.Text = "BUS MASTER";
            this.BUSMASTERToolStripMenuItem.Click += new System.EventHandler(this.BUSMASTERToolStripMenuItem_Click_1);
            // 
            // PASSENGERMASTERToolStripMenuItem
            // 
            this.PASSENGERMASTERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.PASSENGERMASTERToolStripMenuItem.Name = "PASSENGERMASTERToolStripMenuItem";
            this.PASSENGERMASTERToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.PASSENGERMASTERToolStripMenuItem.Text = "PASSENGER MASTER";
            this.PASSENGERMASTERToolStripMenuItem.Click += new System.EventHandler(this.PASSENGERMASTERToolStripMenuItem_Click_1);
            // 
            // DRIVERMASTEToolStripMenuItem
            // 
            this.DRIVERMASTEToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DRIVERMASTEToolStripMenuItem.Name = "DRIVERMASTEToolStripMenuItem";
            this.DRIVERMASTEToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.DRIVERMASTEToolStripMenuItem.Text = "DRIVER MASTER";
            this.DRIVERMASTEToolStripMenuItem.Click += new System.EventHandler(this.DRIVERMASTEToolStripMenuItem_Click_1);
            // 
            // STAFFMASTERToolStripMenuItem
            // 
            this.STAFFMASTERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.STAFFMASTERToolStripMenuItem.Name = "STAFFMASTERToolStripMenuItem";
            this.STAFFMASTERToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.STAFFMASTERToolStripMenuItem.Text = "STAFF MASTER";
            this.STAFFMASTERToolStripMenuItem.Click += new System.EventHandler(this.STAFFMASTERToolStripMenuItem_Click_1);
            // 
            // OFFCEMASTERToolStripMenuItem
            // 
            this.OFFCEMASTERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.OFFCEMASTERToolStripMenuItem.Name = "OFFCEMASTERToolStripMenuItem";
            this.OFFCEMASTERToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.OFFCEMASTERToolStripMenuItem.Text = "OFFICE MASTER";
            this.OFFCEMASTERToolStripMenuItem.Click += new System.EventHandler(this.OFFCEMASTERToolStripMenuItem_Click_1);
            // 
            // TRANSACTIONFROMToolStripMenuItem
            // 
            this.TRANSACTIONFROMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SEATBOOKINGToolStripMenuItem,
            this.BOOKINGCANCELLATIONToolStripMenuItem,
            this.ADVANCEBOOKINGToolStripMenuItem,
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem,
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem});
            this.TRANSACTIONFROMToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.TRANSACTIONFROMToolStripMenuItem.Name = "TRANSACTIONFROMToolStripMenuItem";
            this.TRANSACTIONFROMToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.TRANSACTIONFROMToolStripMenuItem.Text = "TRANSACTION FORM";
            // 
            // SEATBOOKINGToolStripMenuItem
            // 
            this.SEATBOOKINGToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SEATBOOKINGToolStripMenuItem.Name = "SEATBOOKINGToolStripMenuItem";
            this.SEATBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.SEATBOOKINGToolStripMenuItem.Text = "SEAT BOOKING";
            this.SEATBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.SEATBOOKINGToolStripMenuItem_Click_1);
            // 
            // BOOKINGCANCELLATIONToolStripMenuItem
            // 
            this.BOOKINGCANCELLATIONToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.BOOKINGCANCELLATIONToolStripMenuItem.Name = "BOOKINGCANCELLATIONToolStripMenuItem";
            this.BOOKINGCANCELLATIONToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.BOOKINGCANCELLATIONToolStripMenuItem.Text = "BOOKING CANCELLATION";
            this.BOOKINGCANCELLATIONToolStripMenuItem.Click += new System.EventHandler(this.BOOKINGCANCELLATIONToolStripMenuItem_Click_1);
            // 
            // ADVANCEBOOKINGToolStripMenuItem
            // 
            this.ADVANCEBOOKINGToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ADVANCEBOOKINGToolStripMenuItem.Name = "ADVANCEBOOKINGToolStripMenuItem";
            this.ADVANCEBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ADVANCEBOOKINGToolStripMenuItem.Text = "ADVANCE BOOKING";
            this.ADVANCEBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.ADVANCEBOOKINGToolStripMenuItem_Click_1);
            // 
            // ADVANCEBOOKINGCANCELLATIONToolStripMenuItem
            // 
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.Name = "ADVANCEBOOKINGCANCELLATIONToolStripMenuItem";
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.Text = "ADVANCE BOOKING CANCELLATION";
            this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem.Click += new System.EventHandler(this.ADVANCEBOOKINGCANCELLATIONToolStripMenuItem_Click_1);
            // 
            // ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem
            // 
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.Name = "ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem";
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.Text = "ALLOCATE SEAT TO WAITING PASSENGER";
            this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem.Click += new System.EventHandler(this.ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem_Click_1);
            // 
            // REPORTToolStripMenuItem
            // 
            this.REPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentBookedSeatToolStripMenuItem,
            this.CancelledSeatsToolStripMenuItem,
            this.CompletedBookingToolStripMenuItem});
            this.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem";
            this.REPORTToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.REPORTToolStripMenuItem.Text = "UTILITIES";
            // 
            // CurrentBookedSeatToolStripMenuItem
            // 
            this.CurrentBookedSeatToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CurrentBookedSeatToolStripMenuItem.Name = "CurrentBookedSeatToolStripMenuItem";
            this.CurrentBookedSeatToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.CurrentBookedSeatToolStripMenuItem.Text = "SEARCH CURRENT OR ADVANCE/WAITING BOOKING";
            this.CurrentBookedSeatToolStripMenuItem.Click += new System.EventHandler(this.CurrentBookedSeatToolStripMenuItem_Click_1);
            // 
            // CancelledSeatsToolStripMenuItem
            // 
            this.CancelledSeatsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CancelledSeatsToolStripMenuItem.Name = "CancelledSeatsToolStripMenuItem";
            this.CancelledSeatsToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.CancelledSeatsToolStripMenuItem.Text = "SEARCH CANCELLED BOOKING";
            this.CancelledSeatsToolStripMenuItem.Click += new System.EventHandler(this.CancelledSeatsToolStripMenuItem_Click_1);
            // 
            // CompletedBookingToolStripMenuItem
            // 
            this.CompletedBookingToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CompletedBookingToolStripMenuItem.Name = "CompletedBookingToolStripMenuItem";
            this.CompletedBookingToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.CompletedBookingToolStripMenuItem.Text = "SEARCH COMPLETED BOOKING";
            this.CompletedBookingToolStripMenuItem.Click += new System.EventHandler(this.CompletedBookingToolStripMenuItem_Click_1);
            // 
            // RESETDATAToolStripMenuItem
            // 
            this.RESETDATAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CLEARCURRENTBOOKINGToolStripMenuItem,
            this.CLEARADVANCEBOOKINGToolStripMenuItem,
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem,
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem,
            this.CLEARALLBOOKINGSToolStripMenuItem,
            this.CLEARALLMASTERDATAToolStripMenuItem});
            this.RESETDATAToolStripMenuItem.Name = "RESETDATAToolStripMenuItem";
            this.RESETDATAToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.RESETDATAToolStripMenuItem.Text = "CLEAR DATA";
            // 
            // CLEARCURRENTBOOKINGToolStripMenuItem
            // 
            this.CLEARCURRENTBOOKINGToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CLEARCURRENTBOOKINGToolStripMenuItem.Name = "CLEARCURRENTBOOKINGToolStripMenuItem";
            this.CLEARCURRENTBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARCURRENTBOOKINGToolStripMenuItem.Text = "CLEAR CURRENT BOOKINGS";
            this.CLEARCURRENTBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.CLEARCURRENTBOOKINGToolStripMenuItem_Click_1);
            // 
            // CLEARADVANCEBOOKINGToolStripMenuItem
            // 
            this.CLEARADVANCEBOOKINGToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CLEARADVANCEBOOKINGToolStripMenuItem.Name = "CLEARADVANCEBOOKINGToolStripMenuItem";
            this.CLEARADVANCEBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARADVANCEBOOKINGToolStripMenuItem.Text = "CLEAR ADVANCE BOOKINGS";
            this.CLEARADVANCEBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.CLEARADVANCEBOOKINGToolStripMenuItem_Click_1);
            // 
            // CLEARCANCELLATIONBOOKINGToolStripMenuItem
            // 
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem.Name = "CLEARCANCELLATIONBOOKINGToolStripMenuItem";
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem.Text = "CLEAR  CANCELLATION BOOKINGS";
            this.CLEARCANCELLATIONBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.CLEARCANCELLATIONBOOKINGToolStripMenuItem_Click_1);
            // 
            // CLEARCOMPLETEDBOOKINGSToolStripMenuItem
            // 
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem.Name = "CLEARCOMPLETEDBOOKINGSToolStripMenuItem";
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem.Text = "CLEAR COMPLETED BOOKINGS";
            this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem.Click += new System.EventHandler(this.CLEARCOMPLETEDBOOKINGSToolStripMenuItem_Click_1);
            // 
            // CLEARALLBOOKINGSToolStripMenuItem
            // 
            this.CLEARALLBOOKINGSToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CLEARALLBOOKINGSToolStripMenuItem.Name = "CLEARALLBOOKINGSToolStripMenuItem";
            this.CLEARALLBOOKINGSToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARALLBOOKINGSToolStripMenuItem.Text = "CLEAR ALL BOOKINGS";
            this.CLEARALLBOOKINGSToolStripMenuItem.Click += new System.EventHandler(this.CLEARALLBOOKINGSToolStripMenuItem_Click_1);
            // 
            // CLEARALLMASTERDATAToolStripMenuItem
            // 
            this.CLEARALLMASTERDATAToolStripMenuItem.Name = "CLEARALLMASTERDATAToolStripMenuItem";
            this.CLEARALLMASTERDATAToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.CLEARALLMASTERDATAToolStripMenuItem.Text = "CLEAR ALL MASTER DATA";
            this.CLEARALLMASTERDATAToolStripMenuItem.Click += new System.EventHandler(this.CLEARALLMASTERDATAToolStripMenuItem_Click);
            // 
            // REPORTSToolStripMenuItem
            // 
            this.REPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ROUTEToolStripMenuItem,
            this.BUSToolStripMenuItem,
            this.PASSENGERToolStripMenuItem,
            this.DRIVERToolStripMenuItem,
            this.STAFFToolStripMenuItem,
            this.OFFICEToolStripMenuItem,
            this.LOGINRECORDSToolStripMenuItem});
            this.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem";
            this.REPORTSToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.REPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // BUSToolStripMenuItem
            // 
            this.BUSToolStripMenuItem.Name = "BUSToolStripMenuItem";
            this.BUSToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.BUSToolStripMenuItem.Text = "BUS";
            this.BUSToolStripMenuItem.Click += new System.EventHandler(this.BUSToolStripMenuItem_Click_1);
            // 
            // PASSENGERToolStripMenuItem
            // 
            this.PASSENGERToolStripMenuItem.Name = "PASSENGERToolStripMenuItem";
            this.PASSENGERToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PASSENGERToolStripMenuItem.Text = "PASSENGER";
            this.PASSENGERToolStripMenuItem.Click += new System.EventHandler(this.PASSENGERToolStripMenuItem_Click_1);
            // 
            // DRIVERToolStripMenuItem
            // 
            this.DRIVERToolStripMenuItem.Name = "DRIVERToolStripMenuItem";
            this.DRIVERToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.DRIVERToolStripMenuItem.Text = "DRIVER";
            this.DRIVERToolStripMenuItem.Click += new System.EventHandler(this.DRIVERToolStripMenuItem_Click_1);
            // 
            // STAFFToolStripMenuItem
            // 
            this.STAFFToolStripMenuItem.Name = "STAFFToolStripMenuItem";
            this.STAFFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.STAFFToolStripMenuItem.Text = "STAFF";
            this.STAFFToolStripMenuItem.Click += new System.EventHandler(this.STAFFToolStripMenuItem_Click_1);
            // 
            // OFFICEToolStripMenuItem
            // 
            this.OFFICEToolStripMenuItem.Name = "OFFICEToolStripMenuItem";
            this.OFFICEToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.OFFICEToolStripMenuItem.Text = "OFFICE";
            this.OFFICEToolStripMenuItem.Click += new System.EventHandler(this.OFFICEToolStripMenuItem_Click_1);
            // 
            // LOGINRECORDSToolStripMenuItem
            // 
            this.LOGINRECORDSToolStripMenuItem.Name = "LOGINRECORDSToolStripMenuItem";
            this.LOGINRECORDSToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.LOGINRECORDSToolStripMenuItem.Text = "LOGIN RECORDS";
            this.LOGINRECORDSToolStripMenuItem.Click += new System.EventHandler(this.LOGINRECORDSToolStripMenuItem_Click_1);
            // 
            // BOOKINGREPORTSToolStripMenuItem
            // 
            this.BOOKINGREPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CURRENTBOOKINGREPORTToolStripMenuItem,
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem,
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem,
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem});
            this.BOOKINGREPORTSToolStripMenuItem.Name = "BOOKINGREPORTSToolStripMenuItem";
            this.BOOKINGREPORTSToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.BOOKINGREPORTSToolStripMenuItem.Text = "BOOKING REPORTS";
            // 
            // CURRENTBOOKINGREPORTToolStripMenuItem
            // 
            this.CURRENTBOOKINGREPORTToolStripMenuItem.Name = "CURRENTBOOKINGREPORTToolStripMenuItem";
            this.CURRENTBOOKINGREPORTToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.CURRENTBOOKINGREPORTToolStripMenuItem.Text = "CURRENT BOOKING REPORT";
            this.CURRENTBOOKINGREPORTToolStripMenuItem.Click += new System.EventHandler(this.CURRENTBOOKINGREPORTToolStripMenuItem_Click_1);
            // 
            // ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem
            // 
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem.Name = "ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem";
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem.Text = "ADVANCE - WAITING BOOKING REPORT";
            this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem.Click += new System.EventHandler(this.ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem_Click_1);
            // 
            // CANCELLATIONBOOKINGREPORTToolStripMenuItem
            // 
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem.Name = "CANCELLATIONBOOKINGREPORTToolStripMenuItem";
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem.Text = "CANCELLATION BOOKING REPORT";
            this.CANCELLATIONBOOKINGREPORTToolStripMenuItem.Click += new System.EventHandler(this.CANCELLATIONBOOKINGREPORTToolStripMenuItem_Click_1);
            // 
            // COMPLETEDBOOKINGREPORTSToolStripMenuItem
            // 
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem.Name = "COMPLETEDBOOKINGREPORTSToolStripMenuItem";
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem.Text = "COMPLETED BOOKING REPORTS";
            this.COMPLETEDBOOKINGREPORTSToolStripMenuItem.Click += new System.EventHandler(this.COMPLETEDBOOKINGREPORTSToolStripMenuItem_Click_1);
            // 
            // ABOUTToolStripMenuItem
            // 
            this.ABOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EXITToolStripMenuItem});
            this.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem";
            this.ABOUTToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ABOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.EXITToolStripMenuItem.Text = "LOG OFF";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click_1);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 393);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem ROUTEToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem MASTERFORMToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ROUTEMASTERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BUSMASTERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PASSENGERMASTERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DRIVERMASTEToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem STAFFMASTERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OFFCEMASTERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TRANSACTIONFROMToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SEATBOOKINGToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BOOKINGCANCELLATIONToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ADVANCEBOOKINGToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ADVANCEBOOKINGCANCELLATIONToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ALLOCATESEATTOWAITINGPASSENGERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem REPORTToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CurrentBookedSeatToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CancelledSeatsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CompletedBookingToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RESETDATAToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARCURRENTBOOKINGToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARADVANCEBOOKINGToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARCANCELLATIONBOOKINGToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARCOMPLETEDBOOKINGSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARALLBOOKINGSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CLEARALLMASTERDATAToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem REPORTSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BUSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PASSENGERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DRIVERToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem STAFFToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OFFICEToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LOGINRECORDSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BOOKINGREPORTSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CURRENTBOOKINGREPORTToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ADVANCEWAITINGBOOKINGREPORTToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CANCELLATIONBOOKINGREPORTToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem COMPLETEDBOOKINGREPORTSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ABOUTToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
    }
}