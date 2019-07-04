namespace Bus_Reservation
{
    partial class RouteMaster
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
            this.btnsave = new System.Windows.Forms.Button();
            this.Right1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.mainlabel = new System.Windows.Forms.Label();
            this.btnmain = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.TDistance = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TTime = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.FAmount = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.cmbstartpoint = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmbdestination = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.Departuretime = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.Arrivaltime = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.RouteName = new System.Windows.Forms.TextBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnfind = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Rno = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::Bus_Reservation.Properties.Resources.save_48;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.Location = new System.Drawing.Point(16, 186);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(150, 75);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Right1
            // 
            this.Right1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Right1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Right1.Enabled = false;
            this.Right1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Right1.FlatAppearance.BorderSize = 2;
            this.Right1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right1.Image = global::Bus_Reservation.Properties.Resources.chevron_right_round_48;
            this.Right1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Right1.Location = new System.Drawing.Point(668, 4);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(89, 58);
            this.Right1.TabIndex = 33;
            this.Right1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Right1.UseVisualStyleBackColor = false;
            this.Right1.Click += new System.EventHandler(this.Right1_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnadd.FlatAppearance.BorderSize = 2;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::Bus_Reservation.Properties.Resources.add_property_48;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadd.Location = new System.Drawing.Point(16, 105);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 75);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // mainlabel
            // 
            this.mainlabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(173, 29);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(506, 62);
            this.mainlabel.TabIndex = 0;
            this.mainlabel.Text = "ROUTE MASTER ";
            // 
            // btnmain
            // 
            this.btnmain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnmain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnmain.FlatAppearance.BorderSize = 2;
            this.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmain.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmain.Image = global::Bus_Reservation.Properties.Resources.checklist_48;
            this.btnmain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmain.Location = new System.Drawing.Point(16, 24);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(150, 75);
            this.btnmain.TabIndex = 7;
            this.btnmain.Text = "MAIN PAGE";
            this.btnmain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmain.UseVisualStyleBackColor = false;
            this.btnmain.Click += new System.EventHandler(this.btnmain_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnedit.FlatAppearance.BorderSize = 2;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Image = global::Bus_Reservation.Properties.Resources.edit_property_48;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnedit.Location = new System.Drawing.Point(16, 267);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(150, 75);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "EDIT";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Left1
            // 
            this.Left1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Left1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left1.Enabled = false;
            this.Left1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Left1.FlatAppearance.BorderSize = 2;
            this.Left1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left1.Image = global::Bus_Reservation.Properties.Resources.chevron_left_round_48;
            this.Left1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Left1.Location = new System.Drawing.Point(259, 4);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(89, 58);
            this.Left1.TabIndex = 32;
            this.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Left1.UseVisualStyleBackColor = false;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Orange;
            this.Label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(63, 533);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(169, 52);
            this.Label11.TabIndex = 30;
            this.Label11.Text = "Press Here - ->>";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TDistance
            // 
            this.TDistance.Enabled = false;
            this.TDistance.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDistance.Location = new System.Drawing.Point(668, 533);
            this.TDistance.Name = "TDistance";
            this.TDistance.Size = new System.Drawing.Size(175, 31);
            this.TDistance.TabIndex = 29;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(472, 533);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(139, 26);
            this.Label10.TabIndex = 28;
            this.Label10.Text = "Total Distance";
            // 
            // TTime
            // 
            this.TTime.Enabled = false;
            this.TTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTime.Location = new System.Drawing.Point(668, 433);
            this.TTime.Name = "TTime";
            this.TTime.Size = new System.Drawing.Size(175, 31);
            this.TTime.TabIndex = 27;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(472, 429);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(105, 26);
            this.Label9.TabIndex = 26;
            this.Label9.Text = "Total Time";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::Bus_Reservation.Properties.Resources.delete_property_48;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(16, 348);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 75);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FAmount
            // 
            this.FAmount.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAmount.Location = new System.Drawing.Point(668, 284);
            this.FAmount.Name = "FAmount";
            this.FAmount.Size = new System.Drawing.Size(124, 31);
            this.FAmount.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(472, 284);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(127, 26);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Fare Amount";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(227, 363);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(616, 26);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Note : Below Part Is Automated. Press Generate Your Route Button.";
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.Image = global::Bus_Reservation.Properties.Resources.process_48;
            this.btngenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngenerate.Location = new System.Drawing.Point(259, 498);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(164, 108);
            this.btngenerate.TabIndex = 7;
            this.btngenerate.Text = "Generate Your Route";
            this.btngenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // cmbstartpoint
            // 
            this.cmbstartpoint.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstartpoint.FormattingEnabled = true;
            this.cmbstartpoint.Items.AddRange(new object[] {
            "Pachora",
            "Pune ",
            "Mumbai",
            "Surat"});
            this.cmbstartpoint.Location = new System.Drawing.Point(259, 184);
            this.cmbstartpoint.Name = "cmbstartpoint";
            this.cmbstartpoint.Size = new System.Drawing.Size(164, 34);
            this.cmbstartpoint.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(472, 184);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(185, 26);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Choose Destination";
            // 
            // cmbdestination
            // 
            this.cmbdestination.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdestination.FormattingEnabled = true;
            this.cmbdestination.Items.AddRange(new object[] {
            "Pune",
            "Mumbai",
            "Surat",
            "Pachora"});
            this.cmbdestination.Location = new System.Drawing.Point(668, 184);
            this.cmbdestination.Name = "cmbdestination";
            this.cmbdestination.Size = new System.Drawing.Size(175, 34);
            this.cmbdestination.TabIndex = 4;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.mainlabel);
            this.Panel1.Location = new System.Drawing.Point(-16, -33);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1382, 85);
            this.Panel1.TabIndex = 4;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(26, 184);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(206, 26);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Choose Starting Point";
            // 
            // Departuretime
            // 
            this.Departuretime.Enabled = false;
            this.Departuretime.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Departuretime.Location = new System.Drawing.Point(259, 429);
            this.Departuretime.Name = "Departuretime";
            this.Departuretime.Size = new System.Drawing.Size(164, 31);
            this.Departuretime.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(26, 429);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(150, 26);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Departure Time";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Image = global::Bus_Reservation.Properties.Resources.shutdown_48;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(16, 510);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 75);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "EXIT FORM";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Arrivaltime
            // 
            this.Arrivaltime.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Arrivaltime.Location = new System.Drawing.Point(259, 279);
            this.Arrivaltime.Name = "Arrivaltime";
            this.Arrivaltime.Size = new System.Drawing.Size(164, 31);
            this.Arrivaltime.TabIndex = 5;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(26, 279);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 26);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Arrival Time";
            // 
            // RouteName
            // 
            this.RouteName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteName.Location = new System.Drawing.Point(668, 94);
            this.RouteName.Name = "RouteName";
            this.RouteName.Size = new System.Drawing.Size(175, 31);
            this.RouteName.TabIndex = 2;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(-16, 51);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.SplitContainer1.Panel2.Controls.Add(this.Label11);
            this.SplitContainer1.Panel2.Controls.Add(this.TDistance);
            this.SplitContainer1.Panel2.Controls.Add(this.Label10);
            this.SplitContainer1.Panel2.Controls.Add(this.TTime);
            this.SplitContainer1.Panel2.Controls.Add(this.Label9);
            this.SplitContainer1.Panel2.Controls.Add(this.FAmount);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.Label3);
            this.SplitContainer1.Panel2.Controls.Add(this.btngenerate);
            this.SplitContainer1.Panel2.Controls.Add(this.cmbdestination);
            this.SplitContainer1.Panel2.Controls.Add(this.cmbstartpoint);
            this.SplitContainer1.Panel2.Controls.Add(this.Label7);
            this.SplitContainer1.Panel2.Controls.Add(this.Label8);
            this.SplitContainer1.Panel2.Controls.Add(this.Departuretime);
            this.SplitContainer1.Panel2.Controls.Add(this.Arrivaltime);
            this.SplitContainer1.Panel2.Controls.Add(this.Label5);
            this.SplitContainer1.Panel2.Controls.Add(this.Label6);
            this.SplitContainer1.Panel2.Controls.Add(this.RouteName);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.Rno);
            this.SplitContainer1.Panel2.Controls.Add(this.Label1);
            this.SplitContainer1.Size = new System.Drawing.Size(1394, 724);
            this.SplitContainer1.SplitterDistance = 170;
            this.SplitContainer1.TabIndex = 5;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnfind.FlatAppearance.BorderSize = 2;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Image = global::Bus_Reservation.Properties.Resources.search_property_48;
            this.btnfind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfind.Location = new System.Drawing.Point(16, 429);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(150, 75);
            this.btnfind.TabIndex = 12;
            this.btnfind.Text = "FIND";
            this.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(472, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 26);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Route Name";
            // 
            // Rno
            // 
            this.Rno.BackColor = System.Drawing.Color.White;
            this.Rno.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rno.Location = new System.Drawing.Point(259, 94);
            this.Rno.Name = "Rno";
            this.Rno.ReadOnly = true;
            this.Rno.Size = new System.Drawing.Size(164, 31);
            this.Rno.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(26, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 26);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Route No";
            // 
            // RouteMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel1);
            this.Name = "RouteMaster";
            this.Text = "RouteMaster";
            this.Load += new System.EventHandler(this.RouteMaster_Load);
            this.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button Right1;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label mainlabel;
        internal System.Windows.Forms.Button btnmain;
        internal System.Windows.Forms.Button btnedit;
        internal System.Windows.Forms.Button Left1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TDistance;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TTime;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.TextBox FAmount;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btngenerate;
        internal System.Windows.Forms.ComboBox cmbstartpoint;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cmbdestination;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker Departuretime;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.DateTimePicker Arrivaltime;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox RouteName;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox Rno;
        internal System.Windows.Forms.Label Label1;
    }
}