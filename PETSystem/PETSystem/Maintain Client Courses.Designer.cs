namespace PETSystem
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
            this.dgvMaintainClientCourses = new System.Windows.Forms.DataGridView();
            this.AddCourseTypeP = new System.Windows.Forms.Panel();
            this.txtNCDName = new System.Windows.Forms.TextBox();
            this.btnSubmitNewCourseName = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.AddCoursePanel = new System.Windows.Forms.Panel();
            this.lblInstructors = new System.Windows.Forms.Label();
            this.cbInstructors = new System.Windows.Forms.ComboBox();
            this.btnSubmitCouseDetails = new System.Windows.Forms.Button();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaintainTCPanel = new System.Windows.Forms.Panel();
            this.txtSearchCourseName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.addTrainingCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainingCourseTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainTrainingCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTimeslot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintainClientCourses)).BeginInit();
            this.AddCourseTypeP.SuspendLayout();
            this.AddCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.MaintainTCPanel.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaintainClientCourses
            // 
            this.dgvMaintainClientCourses.AllowUserToAddRows = false;
            this.dgvMaintainClientCourses.AllowUserToDeleteRows = false;
            this.dgvMaintainClientCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintainClientCourses.Location = new System.Drawing.Point(297, 27);
            this.dgvMaintainClientCourses.Name = "dgvMaintainClientCourses";
            this.dgvMaintainClientCourses.Size = new System.Drawing.Size(469, 186);
            this.dgvMaintainClientCourses.TabIndex = 18;
            // 
            // AddCourseTypeP
            // 
            this.AddCourseTypeP.Controls.Add(this.txtNCDName);
            this.AddCourseTypeP.Controls.Add(this.btnSubmitNewCourseName);
            this.AddCourseTypeP.Controls.Add(this.label9);
            this.AddCourseTypeP.Controls.Add(this.label10);
            this.AddCourseTypeP.Location = new System.Drawing.Point(469, 241);
            this.AddCourseTypeP.Name = "AddCourseTypeP";
            this.AddCourseTypeP.Size = new System.Drawing.Size(276, 190);
            this.AddCourseTypeP.TabIndex = 15;
            // 
            // txtNCDName
            // 
            this.txtNCDName.Location = new System.Drawing.Point(123, 88);
            this.txtNCDName.Name = "txtNCDName";
            this.txtNCDName.Size = new System.Drawing.Size(119, 20);
            this.txtNCDName.TabIndex = 10;
            // 
            // btnSubmitNewCourseName
            // 
            this.btnSubmitNewCourseName.Location = new System.Drawing.Point(170, 145);
            this.btnSubmitNewCourseName.Name = "btnSubmitNewCourseName";
            this.btnSubmitNewCourseName.Size = new System.Drawing.Size(102, 39);
            this.btnSubmitNewCourseName.TabIndex = 9;
            this.btnSubmitNewCourseName.Text = "Submit";
            this.btnSubmitNewCourseName.UseVisualStyleBackColor = true;
            this.btnSubmitNewCourseName.Click += new System.EventHandler(this.btnSubmitNewCourseName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "New Course Details:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCoursePanel
            // 
            this.AddCoursePanel.Controls.Add(this.label8);
            this.AddCoursePanel.Controls.Add(this.cbTimeslot);
            this.AddCoursePanel.Controls.Add(this.lblInstructors);
            this.AddCoursePanel.Controls.Add(this.cbInstructors);
            this.AddCoursePanel.Controls.Add(this.btnSubmitCouseDetails);
            this.AddCoursePanel.Controls.Add(this.nudDuration);
            this.AddCoursePanel.Controls.Add(this.txtVenue);
            this.AddCoursePanel.Controls.Add(this.txtStartDate);
            this.AddCoursePanel.Controls.Add(this.cmbCourseName);
            this.AddCoursePanel.Controls.Add(this.label5);
            this.AddCoursePanel.Controls.Add(this.label4);
            this.AddCoursePanel.Controls.Add(this.label3);
            this.AddCoursePanel.Controls.Add(this.label2);
            this.AddCoursePanel.Controls.Add(this.label1);
            this.AddCoursePanel.Location = new System.Drawing.Point(15, 156);
            this.AddCoursePanel.Name = "AddCoursePanel";
            this.AddCoursePanel.Size = new System.Drawing.Size(276, 259);
            this.AddCoursePanel.TabIndex = 14;
            // 
            // lblInstructors
            // 
            this.lblInstructors.AutoSize = true;
            this.lblInstructors.Location = new System.Drawing.Point(8, 70);
            this.lblInstructors.Name = "lblInstructors";
            this.lblInstructors.Size = new System.Drawing.Size(59, 13);
            this.lblInstructors.TabIndex = 13;
            this.lblInstructors.Text = "Instructors:";
            // 
            // cbInstructors
            // 
            this.cbInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructors.FormattingEnabled = true;
            this.cbInstructors.Location = new System.Drawing.Point(116, 67);
            this.cbInstructors.Name = "cbInstructors";
            this.cbInstructors.Size = new System.Drawing.Size(145, 21);
            this.cbInstructors.TabIndex = 12;
            // 
            // btnSubmitCouseDetails
            // 
            this.btnSubmitCouseDetails.Location = new System.Drawing.Point(159, 208);
            this.btnSubmitCouseDetails.Name = "btnSubmitCouseDetails";
            this.btnSubmitCouseDetails.Size = new System.Drawing.Size(102, 39);
            this.btnSubmitCouseDetails.TabIndex = 9;
            this.btnSubmitCouseDetails.Text = "Submit";
            this.btnSubmitCouseDetails.UseVisualStyleBackColor = true;
            this.btnSubmitCouseDetails.Click += new System.EventHandler(this.btnSubmitCouseDetails_Click);
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(116, 146);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(145, 20);
            this.nudDuration.TabIndex = 8;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(116, 174);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(145, 20);
            this.txtVenue.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(116, 94);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(145, 20);
            this.txtStartDate.TabIndex = 6;
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(116, 40);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(145, 21);
            this.cmbCourseName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration in weeks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
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
            // MaintainTCPanel
            // 
            this.MaintainTCPanel.Controls.Add(this.txtSearchCourseName);
            this.MaintainTCPanel.Controls.Add(this.button4);
            this.MaintainTCPanel.Controls.Add(this.label6);
            this.MaintainTCPanel.Controls.Add(this.label7);
            this.MaintainTCPanel.Location = new System.Drawing.Point(15, 27);
            this.MaintainTCPanel.Name = "MaintainTCPanel";
            this.MaintainTCPanel.Size = new System.Drawing.Size(276, 123);
            this.MaintainTCPanel.TabIndex = 17;
            // 
            // txtSearchCourseName
            // 
            this.txtSearchCourseName.Location = new System.Drawing.Point(89, 33);
            this.txtSearchCourseName.Name = "txtSearchCourseName";
            this.txtSearchCourseName.Size = new System.Drawing.Size(119, 20);
            this.txtSearchCourseName.TabIndex = 10;
            this.txtSearchCourseName.TextChanged += new System.EventHandler(this.txtSearchCourseName_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Course Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search Course:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainingCourseToolStripMenuItem,
            this.addTrainingCourseTypeToolStripMenuItem,
            this.maintainTrainingCourseToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(796, 24);
            this.MSMain.TabIndex = 13;
            this.MSMain.Text = "menuStrip1";
            // 
            // addTrainingCourseToolStripMenuItem
            // 
            this.addTrainingCourseToolStripMenuItem.Name = "addTrainingCourseToolStripMenuItem";
            this.addTrainingCourseToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.addTrainingCourseToolStripMenuItem.Text = "Add Client Course";
            this.addTrainingCourseToolStripMenuItem.Click += new System.EventHandler(this.addTrainingCourseToolStripMenuItem_Click);
            // 
            // addTrainingCourseTypeToolStripMenuItem
            // 
            this.addTrainingCourseTypeToolStripMenuItem.Name = "addTrainingCourseTypeToolStripMenuItem";
            this.addTrainingCourseTypeToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.addTrainingCourseTypeToolStripMenuItem.Text = "Add Client Course Type";
            this.addTrainingCourseTypeToolStripMenuItem.Click += new System.EventHandler(this.addTrainingCourseTypeToolStripMenuItem_Click);
            // 
            // maintainTrainingCourseToolStripMenuItem
            // 
            this.maintainTrainingCourseToolStripMenuItem.Name = "maintainTrainingCourseToolStripMenuItem";
            this.maintainTrainingCourseToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.maintainTrainingCourseToolStripMenuItem.Text = "Maintain Client Course";
            this.maintainTrainingCourseToolStripMenuItem.Click += new System.EventHandler(this.maintainTrainingCourseToolStripMenuItem_Click);
            // 
            // cbTimeslot
            // 
            this.cbTimeslot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeslot.FormattingEnabled = true;
            this.cbTimeslot.Location = new System.Drawing.Point(116, 119);
            this.cbTimeslot.Name = "cbTimeslot";
            this.cbTimeslot.Size = new System.Drawing.Size(145, 21);
            this.cbTimeslot.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Time Slot:";
            // 
            // Maintain_Client_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.dgvMaintainClientCourses);
            this.Controls.Add(this.AddCourseTypeP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AddCoursePanel);
            this.Controls.Add(this.MaintainTCPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MSMain);
            this.Name = "Maintain_Client_Courses";
            this.Text = "Maintain_Client_Courses";
            this.Load += new System.EventHandler(this.Maintain_Client_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintainClientCourses)).EndInit();
            this.AddCourseTypeP.ResumeLayout(false);
            this.AddCourseTypeP.PerformLayout();
            this.AddCoursePanel.ResumeLayout(false);
            this.AddCoursePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.MaintainTCPanel.ResumeLayout(false);
            this.MaintainTCPanel.PerformLayout();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaintainClientCourses;
        private System.Windows.Forms.Panel AddCourseTypeP;
        private System.Windows.Forms.TextBox txtNCDName;
        private System.Windows.Forms.Button btnSubmitNewCourseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel AddCoursePanel;
        private System.Windows.Forms.Button btnSubmitCouseDetails;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MaintainTCPanel;
        private System.Windows.Forms.TextBox txtSearchCourseName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem addTrainingCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainingCourseTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainTrainingCourseToolStripMenuItem;
        private System.Windows.Forms.Label lblInstructors;
        private System.Windows.Forms.ComboBox cbInstructors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimeslot;
    }
}