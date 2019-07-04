namespace Bus_Reservation
{
    partial class BusMaster
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
            this.mainlabel = new System.Windows.Forms.Label();
            this.Right1 = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.BusReservation = new System.Windows.Forms.ComboBox();
            this.BusType = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnmain = new System.Windows.Forms.Button();
            this.BusRoute = new System.Windows.Forms.ComboBox();
            this.BusNumber = new System.Windows.Forms.ComboBox();
            this.SeatCapacity = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.BusSerialNo = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panel1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(171, 20);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(506, 62);
            this.mainlabel.TabIndex = 1;
            this.mainlabel.Text = "BUS MASTER ";
            // 
            // Right1
            // 
            this.Right1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Right1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Right1.Enabled = false;
            this.Right1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Right1.FlatAppearance.BorderSize = 2;
            this.Right1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right1.Image = global::Bus_Reservation.Properties.Resources.chevron_right_round_48;
            this.Right1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Right1.Location = new System.Drawing.Point(611, 9);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(89, 58);
            this.Right1.TabIndex = 35;
            this.Right1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Right1.UseVisualStyleBackColor = false;
            this.Right1.Click += new System.EventHandler(this.Right1_Click);
            // 
            // Left1
            // 
            this.Left1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Left1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left1.Enabled = false;
            this.Left1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Left1.FlatAppearance.BorderSize = 2;
            this.Left1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left1.Image = global::Bus_Reservation.Properties.Resources.chevron_left_round_48;
            this.Left1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Left1.Location = new System.Drawing.Point(202, 9);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(89, 58);
            this.Left1.TabIndex = 34;
            this.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Left1.UseVisualStyleBackColor = false;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // BusReservation
            // 
            this.BusReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BusReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusReservation.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusReservation.FormattingEnabled = true;
            this.BusReservation.Items.AddRange(new object[] {
            "1x1",
            "2x1",
            "2x2"});
            this.BusReservation.Location = new System.Drawing.Point(497, 430);
            this.BusReservation.Name = "BusReservation";
            this.BusReservation.Size = new System.Drawing.Size(264, 34);
            this.BusReservation.TabIndex = 4;
            // 
            // BusType
            // 
            this.BusType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BusType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusType.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusType.FormattingEnabled = true;
            this.BusType.Items.AddRange(new object[] {
            "Seater",
            "Push Back",
            "Sleeper",
            "Semi Sleeper"});
            this.BusType.Location = new System.Drawing.Point(497, 349);
            this.BusType.Name = "BusType";
            this.BusType.Size = new System.Drawing.Size(264, 34);
            this.BusType.TabIndex = 3;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.mainlabel);
            this.Panel1.Location = new System.Drawing.Point(0, -18);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1382, 92);
            this.Panel1.TabIndex = 6;
            // 
            // btnmain
            // 
            this.btnmain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnmain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnmain.FlatAppearance.BorderSize = 2;
            this.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmain.ForeColor = System.Drawing.Color.Black;
            this.btnmain.Image = global::Bus_Reservation.Properties.Resources.checklist_48;
            this.btnmain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmain.Location = new System.Drawing.Point(16, 24);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(150, 75);
            this.btnmain.TabIndex = 6;
            this.btnmain.Text = "MAIN PAGE";
            this.btnmain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmain.UseVisualStyleBackColor = false;
            this.btnmain.Click += new System.EventHandler(this.btnmain_Click);
            // 
            // BusRoute
            // 
            this.BusRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BusRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusRoute.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusRoute.FormattingEnabled = true;
            this.BusRoute.Items.AddRange(new object[] {
            "Pachora To Pune",
            "Pachora To Mumbai",
            "Pachora To Surat",
            "Pune To Pachora",
            "Mumbai To Pachora",
            "Surat To Pachora"});
            this.BusRoute.Location = new System.Drawing.Point(497, 267);
            this.BusRoute.Name = "BusRoute";
            this.BusRoute.Size = new System.Drawing.Size(264, 34);
            this.BusRoute.TabIndex = 2;
            // 
            // BusNumber
            // 
            this.BusNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BusNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusNumber.FormattingEnabled = true;
            this.BusNumber.Items.AddRange(new object[] {
            "MH 19 1020",
            "MH 19 3333",
            "MH 19 5747",
            "MH 19 57472",
            "MH-19  1000",
            "MH-19 2000"});
            this.BusNumber.Location = new System.Drawing.Point(497, 186);
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.Size = new System.Drawing.Size(264, 34);
            this.BusNumber.TabIndex = 1;
            // 
            // SeatCapacity
            // 
            this.SeatCapacity.Enabled = false;
            this.SeatCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatCapacity.Location = new System.Drawing.Point(497, 508);
            this.SeatCapacity.Name = "SeatCapacity";
            this.SeatCapacity.Size = new System.Drawing.Size(264, 38);
            this.SeatCapacity.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnadd.FlatAppearance.BorderSize = 2;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::Bus_Reservation.Properties.Resources.add_property_48;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadd.Location = new System.Drawing.Point(16, 105);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 75);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Image = global::Bus_Reservation.Properties.Resources.shutdown_48;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(16, 510);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 75);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "EXIT FORM";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(170, 512);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(184, 31);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Seat Capacity";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(170, 349);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(129, 31);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Bus Type";
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnfind.FlatAppearance.BorderSize = 2;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Image = global::Bus_Reservation.Properties.Resources.search_property_48;
            this.btnfind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfind.Location = new System.Drawing.Point(16, 429);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(150, 75);
            this.btnfind.TabIndex = 11;
            this.btnfind.Text = "FIND";
            this.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(170, 430);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 31);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Reservation";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::Bus_Reservation.Properties.Resources.save_48;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.Location = new System.Drawing.Point(16, 186);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(150, 75);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(170, 267);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 31);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Route";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnedit.FlatAppearance.BorderSize = 2;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Image = global::Bus_Reservation.Properties.Resources.edit_property_48;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnedit.Location = new System.Drawing.Point(16, 267);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(150, 75);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "EDIT";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(170, 186);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(164, 31);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Bus Number";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::Bus_Reservation.Properties.Resources.delete_property_48;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(16, 348);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 75);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // BusSerialNo
            // 
            this.BusSerialNo.BackColor = System.Drawing.Color.White;
            this.BusSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusSerialNo.Location = new System.Drawing.Point(497, 101);
            this.BusSerialNo.Name = "BusSerialNo";
            this.BusSerialNo.ReadOnly = true;
            this.BusSerialNo.Size = new System.Drawing.Size(264, 38);
            this.BusSerialNo.TabIndex = 17;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(170, 105);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(179, 31);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "Bus Serial No";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(0, 67);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Cyan;
            this.SplitContainer1.Panel1.Controls.Add(this.btnexit);
            this.SplitContainer1.Panel1.Controls.Add(this.btnfind);
            this.SplitContainer1.Panel1.Controls.Add(this.btndelete);
            this.SplitContainer1.Panel1.Controls.Add(this.btnedit);
            this.SplitContainer1.Panel1.Controls.Add(this.btnsave);
            this.SplitContainer1.Panel1.Controls.Add(this.btnadd);
            this.SplitContainer1.Panel1.Controls.Add(this.btnmain);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.SplitContainer1.Panel2.Controls.Add(this.Right1);
            this.SplitContainer1.Panel2.Controls.Add(this.Left1);
            this.SplitContainer1.Panel2.Controls.Add(this.BusReservation);
            this.SplitContainer1.Panel2.Controls.Add(this.BusType);
            this.SplitContainer1.Panel2.Controls.Add(this.BusRoute);
            this.SplitContainer1.Panel2.Controls.Add(this.BusNumber);
            this.SplitContainer1.Panel2.Controls.Add(this.SeatCapacity);
            this.SplitContainer1.Panel2.Controls.Add(this.Label7);
            this.SplitContainer1.Panel2.Controls.Add(this.Label5);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.Label3);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.BusSerialNo);
            this.SplitContainer1.Panel2.Controls.Add(this.Label6);
            this.SplitContainer1.Size = new System.Drawing.Size(1394, 741);
            this.SplitContainer1.SplitterDistance = 170;
            this.SplitContainer1.TabIndex = 7;
            // 
            // BusMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel1);
            this.Name = "BusMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BusMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BusMaster_Load);
            this.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label mainlabel;
        internal System.Windows.Forms.Button Right1;
        internal System.Windows.Forms.Button Left1;
        internal System.Windows.Forms.ComboBox BusReservation;
        internal System.Windows.Forms.ComboBox BusType;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnmain;
        internal System.Windows.Forms.ComboBox BusRoute;
        internal System.Windows.Forms.ComboBox BusNumber;
        internal System.Windows.Forms.TextBox SeatCapacity;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnedit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.TextBox BusSerialNo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}