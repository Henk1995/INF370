﻿namespace PETSystem
{
    partial class Client_Course_Menu
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
            this.btnMCourses = new System.Windows.Forms.Button();
            this.btnVMParticipants = new System.Windows.Forms.Button();
            this.btnMainM = new System.Windows.Forms.Button();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMCourses
            // 
            this.btnMCourses.Location = new System.Drawing.Point(19, 9);
            this.btnMCourses.Name = "btnMCourses";
            this.btnMCourses.Size = new System.Drawing.Size(123, 39);
            this.btnMCourses.TabIndex = 17;
            this.btnMCourses.Text = "Maintain Courses";
            this.btnMCourses.UseVisualStyleBackColor = true;
            this.btnMCourses.Click += new System.EventHandler(this.btnMCourses_Click);
            // 
            // btnVMParticipants
            // 
            this.btnVMParticipants.Location = new System.Drawing.Point(569, 272);
            this.btnVMParticipants.Name = "btnVMParticipants";
            this.btnVMParticipants.Size = new System.Drawing.Size(194, 39);
            this.btnVMParticipants.TabIndex = 16;
            this.btnVMParticipants.Text = "View/Maintain Participants";
            this.btnVMParticipants.UseVisualStyleBackColor = true;
            this.btnVMParticipants.Click += new System.EventHandler(this.btnVMParticipants_Click);
            // 
            // btnMainM
            // 
            this.btnMainM.Location = new System.Drawing.Point(19, 277);
            this.btnMainM.Name = "btnMainM";
            this.btnMainM.Size = new System.Drawing.Size(123, 34);
            this.btnMainM.TabIndex = 15;
            this.btnMainM.Text = "Back";
            this.btnMainM.UseVisualStyleBackColor = true;
            this.btnMainM.Click += new System.EventHandler(this.btnMainM_Click);
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(440, 272);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(123, 39);
            this.btnAddResult.TabIndex = 14;
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // dgvTC
            // 
            this.dgvTC.AllowUserToAddRows = false;
            this.dgvTC.AllowUserToDeleteRows = false;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTC.Location = new System.Drawing.Point(19, 53);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.ReadOnly = true;
            this.dgvTC.Size = new System.Drawing.Size(744, 216);
            this.dgvTC.TabIndex = 13;
            this.dgvTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_CellContentClick);
            this.dgvTC.SelectionChanged += new System.EventHandler(this.dgvTC_SelectionChanged);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Course ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Instructor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Timeslot Day";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time of Day";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Venue";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "StartDate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(706, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 19);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "Logout In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Client_Course_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnMCourses);
            this.Controls.Add(this.btnVMParticipants);
            this.Controls.Add(this.btnMainM);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.dgvTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Client_Course_Menu";
            this.Text = "Client_Course_Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Course_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Client_Course_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMCourses;
        private System.Windows.Forms.Button btnVMParticipants;
        private System.Windows.Forms.Button btnMainM;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}