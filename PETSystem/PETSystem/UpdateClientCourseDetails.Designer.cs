namespace PETSystem
{
    partial class UpdateClientCourseDetails
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbTimeSlotTime = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTimeslotDay = new System.Windows.Forms.ComboBox();
            this.lblInstructors = new System.Windows.Forms.Label();
            this.cbInstructors = new System.Windows.Forms.ComboBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Time Slot:";
            // 
            // cbTimeSlotTime
            // 
            this.cbTimeSlotTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSlotTime.FormattingEnabled = true;
            this.cbTimeSlotTime.Items.AddRange(new object[] {
            "8:30",
            "9:30",
            "10:30",
            "11:30",
            "12:30",
            "14:30",
            "15:30",
            "16:30"});
            this.cbTimeSlotTime.Location = new System.Drawing.Point(137, 150);
            this.cbTimeSlotTime.Name = "cbTimeSlotTime";
            this.cbTimeSlotTime.Size = new System.Drawing.Size(145, 21);
            this.cbTimeSlotTime.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Day of Week:";
            // 
            // cbTimeslotDay
            // 
            this.cbTimeslotDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeslotDay.FormattingEnabled = true;
            this.cbTimeslotDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednessday",
            "Thursday",
            "Friday"});
            this.cbTimeslotDay.Location = new System.Drawing.Point(137, 125);
            this.cbTimeslotDay.Name = "cbTimeslotDay";
            this.cbTimeslotDay.Size = new System.Drawing.Size(145, 21);
            this.cbTimeslotDay.TabIndex = 26;
            // 
            // lblInstructors
            // 
            this.lblInstructors.AutoSize = true;
            this.lblInstructors.Location = new System.Drawing.Point(29, 76);
            this.lblInstructors.Name = "lblInstructors";
            this.lblInstructors.Size = new System.Drawing.Size(59, 13);
            this.lblInstructors.TabIndex = 25;
            this.lblInstructors.Text = "Instructors:";
            // 
            // cbInstructors
            // 
            this.cbInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructors.FormattingEnabled = true;
            this.cbInstructors.Location = new System.Drawing.Point(137, 73);
            this.cbInstructors.Name = "cbInstructors";
            this.cbInstructors.Size = new System.Drawing.Size(145, 21);
            this.cbInstructors.TabIndex = 24;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(137, 175);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(145, 20);
            this.txtVenue.TabIndex = 23;
            this.txtVenue.TextChanged += new System.EventHandler(this.txtVenue_TextChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(137, 100);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(145, 20);
            this.txtStartDate.TabIndex = 22;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(137, 46);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(145, 21);
            this.cmbCourseName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Course Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateClientCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTimeSlotTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTimeslotDay);
            this.Controls.Add(this.lblInstructors);
            this.Controls.Add(this.cbInstructors);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateClientCourseDetails";
            this.Text = "Update Client Course Details";
            this.Load += new System.EventHandler(this.UpdateClientCourseDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTimeSlotTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimeslotDay;
        private System.Windows.Forms.Label lblInstructors;
        private System.Windows.Forms.ComboBox cbInstructors;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}