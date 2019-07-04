namespace Bus_Reservation
{
    partial class PassengerMaster
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
            this.PassengerContact = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.PassengerCity = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PassengerAddress = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PassengerName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.PassengerNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
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
            this.SplitContainer1.Location = new System.Drawing.Point(-16, 55);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.SplitContainer1.Panel2.Controls.Add(this.PassengerContact);
            this.SplitContainer1.Panel2.Controls.Add(this.Label5);
            this.SplitContainer1.Panel2.Controls.Add(this.PassengerCity);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.PassengerAddress);
            this.SplitContainer1.Panel2.Controls.Add(this.Label3);
            this.SplitContainer1.Panel2.Controls.Add(this.PassengerName);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.PassengerNo);
            this.SplitContainer1.Panel2.Controls.Add(this.Label1);
            this.SplitContainer1.Size = new System.Drawing.Size(1394, 720);
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
            this.Right1.Location = new System.Drawing.Point(616, 9);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(89, 58);
            this.Right1.TabIndex = 44;
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
            this.Left1.Location = new System.Drawing.Point(203, 9);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(89, 58);
            this.Left1.TabIndex = 43;
            this.Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Left1.UseVisualStyleBackColor = false;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // PassengerContact
            // 
            this.PassengerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerContact.Location = new System.Drawing.Point(500, 506);
            this.PassengerContact.Name = "PassengerContact";
            this.PassengerContact.Size = new System.Drawing.Size(264, 38);
            this.PassengerContact.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(173, 510);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(296, 31);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Passenger Contact No.";
            // 
            // PassengerCity
            // 
            this.PassengerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerCity.Location = new System.Drawing.Point(500, 425);
            this.PassengerCity.Name = "PassengerCity";
            this.PassengerCity.Size = new System.Drawing.Size(264, 38);
            this.PassengerCity.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(173, 429);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(199, 31);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Passenger City";
            // 
            // PassengerAddress
            // 
            this.PassengerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerAddress.Location = new System.Drawing.Point(500, 263);
            this.PassengerAddress.Multiline = true;
            this.PassengerAddress.Name = "PassengerAddress";
            this.PassengerAddress.Size = new System.Drawing.Size(264, 92);
            this.PassengerAddress.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(173, 267);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(251, 31);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Passenger Address";
            // 
            // PassengerName
            // 
            this.PassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerName.Location = new System.Drawing.Point(500, 182);
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.Size = new System.Drawing.Size(264, 38);
            this.PassengerName.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(173, 186);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(223, 31);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Passenger Name";
            // 
            // PassengerNo
            // 
            this.PassengerNo.BackColor = System.Drawing.Color.White;
            this.PassengerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerNo.Location = new System.Drawing.Point(500, 101);
            this.PassengerNo.Name = "PassengerNo";
            this.PassengerNo.ReadOnly = true;
            this.PassengerNo.Size = new System.Drawing.Size(264, 38);
            this.PassengerNo.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(173, 105);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(186, 31);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Passenger No";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.mainlabel);
            this.Panel1.Location = new System.Drawing.Point(-16, -33);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1382, 90);
            this.Panel1.TabIndex = 6;
            // 
            // mainlabel
            // 
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(174, 31);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(506, 62);
            this.mainlabel.TabIndex = 1;
            this.mainlabel.Text = "PASSENGER MASTER ";
            // 
            // PassengerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel1);
            this.Name = "PassengerMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassengerMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PassengerMaster_Load);
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
        internal System.Windows.Forms.TextBox PassengerContact;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox PassengerCity;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox PassengerAddress;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox PassengerName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox PassengerNo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label mainlabel;
    }
}