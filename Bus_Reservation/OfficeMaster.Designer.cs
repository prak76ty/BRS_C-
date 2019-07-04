namespace Bus_Reservation
{
    partial class OfficeMaster
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmain = new System.Windows.Forms.Button();
            this.Right1 = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.Officecontact = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Officecity = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Officeaddress = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.OWorkerName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.OfficeID = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.mainlabel = new System.Windows.Forms.Label();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(-16, 49);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.SplitContainer1.Panel2.Controls.Add(this.Officecontact);
            this.SplitContainer1.Panel2.Controls.Add(this.Label5);
            this.SplitContainer1.Panel2.Controls.Add(this.Officecity);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.Officeaddress);
            this.SplitContainer1.Panel2.Controls.Add(this.Label3);
            this.SplitContainer1.Panel2.Controls.Add(this.OWorkerName);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.OfficeID);
            this.SplitContainer1.Panel2.Controls.Add(this.Label6);
            this.SplitContainer1.Size = new System.Drawing.Size(1394, 726);
            this.SplitContainer1.SplitterDistance = 170;
            this.SplitContainer1.TabIndex = 7;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // btnmain
            // 
            this.btnmain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnmain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmain.FlatAppearance.BorderSize = 2;
            this.btnmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Right1.Location = new System.Drawing.Point(580, 9);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(89, 58);
            this.Right1.TabIndex = 42;
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
            this.Left1.Location = new System.Drawing.Point(167, 9);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(89, 58);
            this.Left1.TabIndex = 41;
            this.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Left1.UseVisualStyleBackColor = false;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // Officecontact
            // 
            this.Officecontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officecontact.Location = new System.Drawing.Point(463, 510);
            this.Officecontact.Name = "Officecontact";
            this.Officecontact.Size = new System.Drawing.Size(264, 38);
            this.Officecontact.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(136, 514);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(159, 31);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Contact No.";
            // 
            // Officecity
            // 
            this.Officecity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officecity.Location = new System.Drawing.Point(463, 429);
            this.Officecity.Name = "Officecity";
            this.Officecity.Size = new System.Drawing.Size(264, 38);
            this.Officecity.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(136, 433);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(141, 31);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Office City";
            // 
            // Officeaddress
            // 
            this.Officeaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Officeaddress.Location = new System.Drawing.Point(463, 267);
            this.Officeaddress.Multiline = true;
            this.Officeaddress.Name = "Officeaddress";
            this.Officeaddress.Size = new System.Drawing.Size(264, 92);
            this.Officeaddress.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(136, 271);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(193, 31);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Office Address";
            // 
            // OWorkerName
            // 
            this.OWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OWorkerName.Location = new System.Drawing.Point(463, 186);
            this.OWorkerName.Name = "OWorkerName";
            this.OWorkerName.Size = new System.Drawing.Size(264, 38);
            this.OWorkerName.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(136, 190);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(259, 31);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Office Worker Name";
            // 
            // OfficeID
            // 
            this.OfficeID.BackColor = System.Drawing.Color.White;
            this.OfficeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeID.Location = new System.Drawing.Point(463, 105);
            this.OfficeID.Name = "OfficeID";
            this.OfficeID.ReadOnly = true;
            this.OfficeID.Size = new System.Drawing.Size(264, 38);
            this.OfficeID.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(136, 109);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(115, 31);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "Offce ID";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.mainlabel);
            this.Panel1.Location = new System.Drawing.Point(-16, -33);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1382, 87);
            this.Panel1.TabIndex = 6;
            // 
            // mainlabel
            // 
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(171, 29);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(506, 62);
            this.mainlabel.TabIndex = 1;
            this.mainlabel.Text = "OFFICE MASTER ";
            // 
            // OfficeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel1);
            this.Name = "OfficeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OfficeMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OfficeMaster_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            this.SplitContainer1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btnfind;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnedit;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Button btnmain;
        internal System.Windows.Forms.Button Right1;
        internal System.Windows.Forms.Button Left1;
        internal System.Windows.Forms.TextBox Officecontact;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Officecity;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Officeaddress;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox OWorkerName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox OfficeID;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label mainlabel;
    }
}