﻿namespace PETSystem
{
    partial class Maintain_Client_Courses
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddCoursePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTimeSlotTime = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTimeslotDay = new System.Windows.Forms.ComboBox();
            this.lblInstructors = new System.Windows.Forms.Label();
            this.cbInstructors = new System.Windows.Forms.ComboBox();
            this.btnSubmitCouseDetails = new System.Windows.Forms.Button();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMaintainClientCourses = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeslotDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSlotTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSearchCourse = new System.Windows.Forms.DataGridView();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtSearcCCSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.txtSearchCCName = new System.Windows.Forms.TextBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvCourseClient = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AddCoursePanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintainClientCourses)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCourse)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 348);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddCoursePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddCoursePanel
            // 
            this.AddCoursePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddCoursePanel.Controls.Add(this.label5);
            this.AddCoursePanel.Controls.Add(this.cbTimeSlotTime);
            this.AddCoursePanel.Controls.Add(this.label8);
            this.AddCoursePanel.Controls.Add(this.cbTimeslotDay);
            this.AddCoursePanel.Controls.Add(this.lblInstructors);
            this.AddCoursePanel.Controls.Add(this.cbInstructors);
            this.AddCoursePanel.Controls.Add(this.btnSubmitCouseDetails);
            this.AddCoursePanel.Controls.Add(this.txtVenue);
            this.AddCoursePanel.Controls.Add(this.txtStartDate);
            this.AddCoursePanel.Controls.Add(this.cmbCourseName);
            this.AddCoursePanel.Controls.Add(this.label4);
            this.AddCoursePanel.Controls.Add(this.label3);
            this.AddCoursePanel.Controls.Add(this.label2);
            this.AddCoursePanel.Controls.Add(this.label1);
            this.AddCoursePanel.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoursePanel.Location = new System.Drawing.Point(18, 19);
            this.AddCoursePanel.Name = "AddCoursePanel";
            this.AddCoursePanel.Size = new System.Drawing.Size(283, 282);
            this.AddCoursePanel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 17;
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
            this.cbTimeSlotTime.Location = new System.Drawing.Point(117, 161);
            this.cbTimeSlotTime.Name = "cbTimeSlotTime";
            this.cbTimeSlotTime.Size = new System.Drawing.Size(145, 26);
            this.cbTimeSlotTime.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 15;
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
            this.cbTimeslotDay.Location = new System.Drawing.Point(117, 129);
            this.cbTimeslotDay.Name = "cbTimeslotDay";
            this.cbTimeslotDay.Size = new System.Drawing.Size(145, 26);
            this.cbTimeslotDay.TabIndex = 14;
            // 
            // lblInstructors
            // 
            this.lblInstructors.AutoSize = true;
            this.lblInstructors.Location = new System.Drawing.Point(25, 69);
            this.lblInstructors.Name = "lblInstructors";
            this.lblInstructors.Size = new System.Drawing.Size(86, 18);
            this.lblInstructors.TabIndex = 13;
            this.lblInstructors.Text = "Instructors:";
            // 
            // cbInstructors
            // 
            this.cbInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructors.FormattingEnabled = true;
            this.cbInstructors.Location = new System.Drawing.Point(117, 66);
            this.cbInstructors.Name = "cbInstructors";
            this.cbInstructors.Size = new System.Drawing.Size(145, 26);
            this.cbInstructors.TabIndex = 12;
            // 
            // btnSubmitCouseDetails
            // 
            this.btnSubmitCouseDetails.Location = new System.Drawing.Point(160, 224);
            this.btnSubmitCouseDetails.Name = "btnSubmitCouseDetails";
            this.btnSubmitCouseDetails.Size = new System.Drawing.Size(102, 39);
            this.btnSubmitCouseDetails.TabIndex = 9;
            this.btnSubmitCouseDetails.Text = "Submit";
            this.btnSubmitCouseDetails.UseVisualStyleBackColor = true;
            this.btnSubmitCouseDetails.Click += new System.EventHandler(this.btnSubmitCouseDetails_Click_1);
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(117, 193);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(145, 25);
            this.txtVenue.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(117, 98);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(145, 25);
            this.txtStartDate.TabIndex = 6;
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(117, 34);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(145, 26);
            this.cmbCourseName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Details:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maintain  Course";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMaintainClientCourses);
            this.panel1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 170);
            this.panel1.TabIndex = 29;
            // 
            // dgvMaintainClientCourses
            // 
            this.dgvMaintainClientCourses.AllowUserToAddRows = false;
            this.dgvMaintainClientCourses.AllowUserToDeleteRows = false;
            this.dgvMaintainClientCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintainClientCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Instructor,
            this.TimeslotDay,
            this.TimeSlotTime,
            this.Venue,
            this.StartDate});
            this.dgvMaintainClientCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvMaintainClientCourses.Name = "dgvMaintainClientCourses";
            this.dgvMaintainClientCourses.ReadOnly = true;
            this.dgvMaintainClientCourses.Size = new System.Drawing.Size(752, 169);
            this.dgvMaintainClientCourses.TabIndex = 26;
            this.dgvMaintainClientCourses.SelectionChanged += new System.EventHandler(this.dgvMaintainClientCourses_SelectionChanged_1);
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // TimeslotDay
            // 
            this.TimeslotDay.HeaderText = "Timeslot Day";
            this.TimeslotDay.Name = "TimeslotDay";
            this.TimeslotDay.ReadOnly = true;
            // 
            // TimeSlotTime
            // 
            this.TimeSlotTime.HeaderText = "Timeslot Time";
            this.TimeSlotTime.Name = "TimeSlotTime";
            this.TimeSlotTime.ReadOnly = true;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(103, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Course Type";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCourseDuration);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.txtCourseCost);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 160);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 72;
            this.label12.Text = "Course Name:";
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDuration.Location = new System.Drawing.Point(135, 106);
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(195, 25);
            this.txtCourseDuration.TabIndex = 68;
            this.txtCourseDuration.TextChanged += new System.EventHandler(this.txtCourseDuration_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 71;
            this.label13.Text = "Course Cost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 18);
            this.label11.TabIndex = 73;
            this.label11.Text = "Course Duration:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(135, 32);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(195, 25);
            this.txtCourseName.TabIndex = 66;
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
            // 
            // txtCourseCost
            // 
            this.txtCourseCost.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCost.Location = new System.Drawing.Point(135, 68);
            this.txtCourseCost.Name = "txtCourseCost";
            this.txtCourseCost.Size = new System.Drawing.Size(195, 25);
            this.txtCourseCost.TabIndex = 67;
            this.txtCourseCost.TextChanged += new System.EventHandler(this.txtCourseCost_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 69;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSearchCourse);
            this.tabPage4.Controls.Add(this.btnRemoveCourse);
            this.tabPage4.Controls.Add(this.btnUpdateCourse);
            this.tabPage4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Maintain Course Type";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSearchCourse
            // 
            this.dgvSearchCourse.AllowUserToAddRows = false;
            this.dgvSearchCourse.AllowUserToDeleteRows = false;
            this.dgvSearchCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCourse.Location = new System.Drawing.Point(109, 19);
            this.dgvSearchCourse.Name = "dgvSearchCourse";
            this.dgvSearchCourse.ReadOnly = true;
            this.dgvSearchCourse.Size = new System.Drawing.Size(344, 288);
            this.dgvSearchCourse.TabIndex = 66;
            this.dgvSearchCourse.SelectionChanged += new System.EventHandler(this.dgvSearchCourse_SelectionChanged);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(3, 57);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(97, 32);
            this.btnRemoveCourse.TabIndex = 70;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(3, 19);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(97, 32);
            this.btnUpdateCourse.TabIndex = 69;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtSearcCCSurname);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.btnAddClient);
            this.tabPage5.Controls.Add(this.btnViewClient);
            this.tabPage5.Controls.Add(this.txtSearchCCName);
            this.tabPage5.Controls.Add(this.btnUpdateClient);
            this.tabPage5.Controls.Add(this.btnRemoveClient);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.dgvCourseClient);
            this.tabPage5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(764, 322);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Maintain Course Clients";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtSearcCCSurname
            // 
            this.txtSearcCCSurname.Location = new System.Drawing.Point(7, 136);
            this.txtSearcCCSurname.Name = "txtSearcCCSurname";
            this.txtSearcCCSurname.Size = new System.Drawing.Size(217, 25);
            this.txtSearcCCSurname.TabIndex = 68;
            this.txtSearcCCSurname.TextChanged += new System.EventHandler(this.txtSearcCCSurname_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 67;
            this.label10.Text = "Client Surname:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(8, 167);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(113, 33);
            this.btnAddClient.TabIndex = 66;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnViewClient
            // 
            this.btnViewClient.Location = new System.Drawing.Point(10, 206);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(111, 33);
            this.btnViewClient.TabIndex = 65;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // txtSearchCCName
            // 
            this.txtSearchCCName.Location = new System.Drawing.Point(7, 48);
            this.txtSearchCCName.Name = "txtSearchCCName";
            this.txtSearchCCName.Size = new System.Drawing.Size(217, 25);
            this.txtSearchCCName.TabIndex = 62;
            this.txtSearchCCName.TextChanged += new System.EventHandler(this.txtSearchCCName_TextChanged);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(127, 167);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(112, 33);
            this.btnUpdateClient.TabIndex = 64;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(127, 206);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(112, 33);
            this.btnRemoveClient.TabIndex = 63;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 61;
            this.label14.Text = "Client Name:";
            // 
            // dgvCourseClient
            // 
            this.dgvCourseClient.AllowUserToAddRows = false;
            this.dgvCourseClient.AllowUserToDeleteRows = false;
            this.dgvCourseClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseClient.Location = new System.Drawing.Point(280, 19);
            this.dgvCourseClient.Name = "dgvCourseClient";
            this.dgvCourseClient.ReadOnly = true;
            this.dgvCourseClient.Size = new System.Drawing.Size(445, 209);
            this.dgvCourseClient.TabIndex = 60;
            this.dgvCourseClient.SelectionChanged += new System.EventHandler(this.dgvCourseClient_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(679, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Logout In:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTimer.Location = new System.Drawing.Point(729, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 19);
            this.lblTimer.TabIndex = 23;
            this.lblTimer.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Maintain_Client_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 410);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(805, 448);
            this.MinimumSize = new System.Drawing.Size(805, 448);
            this.Name = "Maintain_Client_Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintain_Client_Courses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maintain_Client_Courses_FormClosing);
            this.Load += new System.EventHandler(this.Maintain_Client_Courses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.AddCoursePanel.ResumeLayout(false);
            this.AddCoursePanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintainClientCourses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCourse)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel AddCoursePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTimeSlotTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimeslotDay;
        private System.Windows.Forms.Label lblInstructors;
        private System.Windows.Forms.ComboBox cbInstructors;
        private System.Windows.Forms.Button btnSubmitCouseDetails;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMaintainClientCourses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCourseCost;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvSearchCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtSearcCCSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.TextBox txtSearchCCName;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvCourseClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeslotDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlotTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}