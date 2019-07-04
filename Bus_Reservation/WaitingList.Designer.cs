namespace Bus_Reservation
{
    partial class WaitingList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingList));
            this.SeatCapacity = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label17 = new System.Windows.Forms.Label();
            this.PCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusReservation = new System.Windows.Forms.ComboBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.BusNumber = new System.Windows.Forms.ComboBox();
            this.cmbdestination = new System.Windows.Forms.ComboBox();
            this.cmbstartpoint = new System.Windows.Forms.ComboBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusType = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Pno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departuretime = new System.Windows.Forms.DateTimePicker();
            this.Arrivaltime = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.BusSerialNo = new System.Windows.Forms.ComboBox();
            this.RNo = new System.Windows.Forms.ComboBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Bno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Ending = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SC2 = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.SeatAvailability = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Button2 = new System.Windows.Forms.Button();
            this.Proceed = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.BookingNo = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeatCapacity
            // 
            this.SeatCapacity.Enabled = false;
            this.SeatCapacity.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatCapacity.Location = new System.Drawing.Point(890, 218);
            this.SeatCapacity.Name = "SeatCapacity";
            this.SeatCapacity.Size = new System.Drawing.Size(131, 26);
            this.SeatCapacity.TabIndex = 325;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Waiting No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // PContact
            // 
            this.PContact.HeaderText = "Contact";
            this.PContact.Name = "PContact";
            this.PContact.ReadOnly = true;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(791, 221);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(101, 21);
            this.Label17.TabIndex = 324;
            this.Label17.Text = "Seat Capacity";
            // 
            // PCity
            // 
            this.PCity.HeaderText = "City";
            this.PCity.Name = "PCity";
            this.PCity.ReadOnly = true;
            // 
            // BusReservation
            // 
            this.BusReservation.Enabled = false;
            this.BusReservation.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusReservation.FormattingEnabled = true;
            this.BusReservation.Items.AddRange(new object[] {
            "Select",
            "1x1",
            "2x1",
            "2x2"});
            this.BusReservation.Location = new System.Drawing.Point(690, 218);
            this.BusReservation.Name = "BusReservation";
            this.BusReservation.Size = new System.Drawing.Size(98, 29);
            this.BusReservation.TabIndex = 323;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(603, 223);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(89, 21);
            this.Label18.TabIndex = 322;
            this.Label18.Text = "Reservation";
            // 
            // BusNumber
            // 
            this.BusNumber.Enabled = false;
            this.BusNumber.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusNumber.FormattingEnabled = true;
            this.BusNumber.Items.AddRange(new object[] {
            "Select",
            "MH 19 1020",
            "MH 19 3333",
            "MH 19 5747",
            "MH 19 57472",
            "MH-19  1000",
            "MH-19 2000"});
            this.BusNumber.Location = new System.Drawing.Point(304, 218);
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.Size = new System.Drawing.Size(100, 29);
            this.BusNumber.TabIndex = 319;
            // 
            // cmbdestination
            // 
            this.cmbdestination.BackColor = System.Drawing.Color.LightCyan;
            this.cmbdestination.Enabled = false;
            this.cmbdestination.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbdestination.FormattingEnabled = true;
            this.cmbdestination.Items.AddRange(new object[] {
            "Pachora",
            "Pune",
            "Mumbai",
            "Surat"});
            this.cmbdestination.Location = new System.Drawing.Point(890, 157);
            this.cmbdestination.Name = "cmbdestination";
            this.cmbdestination.Size = new System.Drawing.Size(131, 29);
            this.cmbdestination.TabIndex = 317;
            // 
            // cmbstartpoint
            // 
            this.cmbstartpoint.BackColor = System.Drawing.Color.LightCyan;
            this.cmbstartpoint.Enabled = false;
            this.cmbstartpoint.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstartpoint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbstartpoint.FormattingEnabled = true;
            this.cmbstartpoint.Items.AddRange(new object[] {
            "Pachora",
            "Pune",
            "Mumbai",
            "Surat"});
            this.cmbstartpoint.Location = new System.Drawing.Point(669, 157);
            this.cmbstartpoint.Name = "cmbstartpoint";
            this.cmbstartpoint.Size = new System.Drawing.Size(122, 29);
            this.cmbstartpoint.TabIndex = 316;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(417, 221);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(72, 21);
            this.Label20.TabIndex = 320;
            this.Label20.Text = "Bus Type";
            // 
            // Pname
            // 
            this.Pname.HeaderText = "Name";
            this.Pname.Name = "Pname";
            this.Pname.ReadOnly = true;
            // 
            // BusType
            // 
            this.BusType.Enabled = false;
            this.BusType.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusType.FormattingEnabled = true;
            this.BusType.Items.AddRange(new object[] {
            "Select",
            "Seater",
            "Push Back",
            "Sleeper",
            "Semi Sleeper"});
            this.BusType.Location = new System.Drawing.Point(489, 218);
            this.BusType.Name = "BusType";
            this.BusType.Size = new System.Drawing.Size(108, 29);
            this.BusType.TabIndex = 321;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(797, 160);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(87, 21);
            this.Label11.TabIndex = 315;
            this.Label11.Text = "Destination";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(600, 160);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(63, 21);
            this.Label16.TabIndex = 314;
            this.Label16.Text = "Starting";
            // 
            // Pno
            // 
            this.Pno.HeaderText = "Passenger No";
            this.Pno.Name = "Pno";
            this.Pno.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Current Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Departuretime
            // 
            this.Departuretime.Enabled = false;
            this.Departuretime.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Departuretime.Location = new System.Drawing.Point(470, 155);
            this.Departuretime.Name = "Departuretime";
            this.Departuretime.Size = new System.Drawing.Size(124, 26);
            this.Departuretime.TabIndex = 313;
            // 
            // Arrivaltime
            // 
            this.Arrivaltime.Enabled = false;
            this.Arrivaltime.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Arrivaltime.Location = new System.Drawing.Point(268, 155);
            this.Arrivaltime.Name = "Arrivaltime";
            this.Arrivaltime.Size = new System.Drawing.Size(113, 26);
            this.Arrivaltime.TabIndex = 312;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(210, 160);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 21);
            this.Label9.TabIndex = 310;
            this.Label9.Text = "Arrival";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 156);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 25);
            this.Label1.TabIndex = 307;
            this.Label1.Text = "Route No";
            // 
            // BDate
            // 
            this.BDate.HeaderText = "Booking Date";
            this.BDate.Name = "BDate";
            this.BDate.ReadOnly = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(265, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(469, 30);
            this.Label10.TabIndex = 257;
            this.Label10.Text = "ALLOCATE SEATS TO WAITING PASSENGERS";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(387, 160);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(77, 21);
            this.Label8.TabIndex = 311;
            this.Label8.Text = "Departure";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 222);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(82, 25);
            this.Label7.TabIndex = 309;
            this.Label7.Text = "Bus No";
            // 
            // BusSerialNo
            // 
            this.BusSerialNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusSerialNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BusSerialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusSerialNo.Enabled = false;
            this.BusSerialNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusSerialNo.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusSerialNo.FormattingEnabled = true;
            this.BusSerialNo.Location = new System.Drawing.Point(114, 218);
            this.BusSerialNo.Name = "BusSerialNo";
            this.BusSerialNo.Size = new System.Drawing.Size(83, 29);
            this.BusSerialNo.TabIndex = 308;
            this.BusSerialNo.SelectedIndexChanged += new System.EventHandler(this.BusSerialNo_SelectedIndexChanged);
            // 
            // RNo
            // 
            this.RNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RNo.Enabled = false;
            this.RNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RNo.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNo.FormattingEnabled = true;
            this.RNo.Location = new System.Drawing.Point(114, 157);
            this.RNo.Name = "RNo";
            this.RNo.Size = new System.Drawing.Size(83, 29);
            this.RNo.TabIndex = 306;
            this.RNo.SelectedIndexChanged += new System.EventHandler(this.RNo_SelectedIndexChanged);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(203, 221);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(95, 21);
            this.Label21.TabIndex = 318;
            this.Label21.Text = "Bus Number";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(320, 6);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 264;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(161, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(740, 30);
            this.Label2.TabIndex = 257;
            this.Label2.Text = "BOOKING DETAILS AND PERSON OR PASSENGER BOOKED BY DETAILS";
            // 
            // DGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bno,
            this.Column1,
            this.BDate,
            this.Column2,
            this.Column3,
            this.Pno,
            this.Pname,
            this.PCity,
            this.PContact,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.Location = new System.Drawing.Point(45, 392);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(944, 195);
            this.DGV.TabIndex = 305;
            // 
            // Bno
            // 
            this.Bno.HeaderText = "Booking No";
            this.Bno.Name = "Bno";
            this.Bno.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Route & Bus";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Image = global::Bus_Reservation.Properties.Resources.return_48;
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button4.Location = new System.Drawing.Point(11, 593);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(119, 65);
            this.Button4.TabIndex = 292;
            this.Button4.Text = "Clear";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Image = global::Bus_Reservation.Properties.Resources.cancelled_logo;
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(274, 593);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(235, 65);
            this.Button3.TabIndex = 290;
            this.Button3.Text = "Cancell Seat   ";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Ending
            // 
            this.Ending.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Ending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ending.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ending.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ending.Image = global::Bus_Reservation.Properties.Resources.shutdown_48;
            this.Ending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ending.Location = new System.Drawing.Point(899, 593);
            this.Ending.Name = "Ending";
            this.Ending.Size = new System.Drawing.Size(122, 65);
            this.Ending.TabIndex = 291;
            this.Ending.Text = "Close";
            this.Ending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ending.UseVisualStyleBackColor = false;
            this.Ending.Click += new System.EventHandler(this.Ending_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(585, 63);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(317, 26);
            this.Label5.TabIndex = 304;
            this.Label5.Text = "Give Booking No of Waiting Lst";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(40, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(255, 26);
            this.Label4.TabIndex = 303;
            this.Label4.Text = "Search By  Booking Date";
            // 
            // SC2
            // 
            this.SC2.BackColor = System.Drawing.Color.MintCream;
            this.SC2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SC2.Enabled = false;
            this.SC2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SC2.Location = new System.Drawing.Point(690, 310);
            this.SC2.Name = "SC2";
            this.SC2.Size = new System.Drawing.Size(39, 24);
            this.SC2.TabIndex = 302;
            this.SC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(515, 309);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(273, 26);
            this.Label19.TabIndex = 301;
            this.Label19.Text = "Seat Booked From   20 Seats";
            // 
            // SeatAvailability
            // 
            this.SeatAvailability.BackColor = System.Drawing.Color.MintCream;
            this.SeatAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeatAvailability.Enabled = false;
            this.SeatAvailability.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatAvailability.Location = new System.Drawing.Point(473, 311);
            this.SeatAvailability.Name = "SeatAvailability";
            this.SeatAvailability.Size = new System.Drawing.Size(47, 24);
            this.SeatAvailability.TabIndex = 300;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(670, 276);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(148, 25);
            this.Label15.TabIndex = 299;
            this.Label15.Text = "Upper Section";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(501, 276);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(148, 25);
            this.Label14.TabIndex = 298;
            this.Label14.Text = "Lower Section";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label13.Location = new System.Drawing.Point(152, 276);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(312, 26);
            this.Label13.TabIndex = 297;
            this.Label13.Text = "Seat Selection Lower Or Upper";
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Enabled = false;
            this.RadioButton1.Location = new System.Drawing.Point(489, 283);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(31, 17);
            this.RadioButton1.TabIndex = 287;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "L";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Enabled = false;
            this.RadioButton2.Location = new System.Drawing.Point(657, 283);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(33, 17);
            this.RadioButton2.TabIndex = 288;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "U";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Turquoise;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(346, 90);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(146, 56);
            this.Button2.TabIndex = 284;
            this.Button2.Text = "SEARCH";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proceed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.Image = global::Bus_Reservation.Properties.Resources.checklist_48;
            this.Proceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Proceed.Location = new System.Drawing.Point(537, 593);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(235, 65);
            this.Proceed.TabIndex = 289;
            this.Proceed.Text = "Choose Seat    ";
            this.Proceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Location = new System.Drawing.Point(0, 341);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1302, 45);
            this.Panel3.TabIndex = 296;
            // 
            // BookingNo
            // 
            this.BookingNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingNo.Location = new System.Drawing.Point(672, 106);
            this.BookingNo.Name = "BookingNo";
            this.BookingNo.Size = new System.Drawing.Size(163, 27);
            this.BookingNo.TabIndex = 285;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.DateTimePicker1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1302, 40);
            this.Panel1.TabIndex = 295;
            // 
            // BookingDate
            // 
            this.BookingDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(157, 97);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(163, 31);
            this.BookingDate.TabIndex = 283;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Turquoise;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(856, 95);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(146, 56);
            this.Button1.TabIndex = 286;
            this.Button1.Text = "SEARCH";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(6, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(133, 26);
            this.Label3.TabIndex = 294;
            this.Label3.Text = "Booking Date";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(532, 103);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(115, 26);
            this.Label12.TabIndex = 293;
            this.Label12.Text = "Booking No";
            // 
            // WaitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.SeatCapacity);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.BusReservation);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.BusNumber);
            this.Controls.Add(this.cmbdestination);
            this.Controls.Add(this.cmbstartpoint);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.BusType);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Departuretime);
            this.Controls.Add(this.Arrivaltime);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.BusSerialNo);
            this.Controls.Add(this.RNo);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Ending);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.SC2);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.SeatAvailability);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.BookingNo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label12);
            this.Name = "WaitingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WaitingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WaitingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox SeatCapacity;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PContact;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PCity;
        internal System.Windows.Forms.ComboBox BusReservation;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.ComboBox BusNumber;
        internal System.Windows.Forms.ComboBox cmbdestination;
        internal System.Windows.Forms.ComboBox cmbstartpoint;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        internal System.Windows.Forms.ComboBox BusType;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Pno;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DateTimePicker Departuretime;
        internal System.Windows.Forms.DateTimePicker Arrivaltime;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox BusSerialNo;
        internal System.Windows.Forms.ComboBox RNo;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView DGV;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Bno;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Ending;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox SC2;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox SeatAvailability;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Proceed;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox BookingNo;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DateTimePicker BookingDate;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label12;
    }
}