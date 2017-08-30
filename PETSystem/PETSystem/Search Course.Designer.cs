﻿namespace PETSystem
{
    partial class SearchCourse
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSearcCourseName = new System.Windows.Forms.Button();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.txtSearchCourseName = new System.Windows.Forms.TextBox();
            this.btnSearchCourseClient = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(200, 467);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(135, 23);
            this.btnMainMenu.TabIndex = 48;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(343, 467);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(135, 23);
            this.btnAddCourse.TabIndex = 47;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSearcCourseName
            // 
            this.btnSearcCourseName.Location = new System.Drawing.Point(8, 110);
            this.btnSearcCourseName.Name = "btnSearcCourseName";
            this.btnSearcCourseName.Size = new System.Drawing.Size(326, 23);
            this.btnSearcCourseName.TabIndex = 43;
            this.btnSearcCourseName.Text = "Search Course Name";
            this.btnSearcCourseName.UseVisualStyleBackColor = true;
            this.btnSearcCourseName.Click += new System.EventHandler(this.btnSearcCourseName_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(484, 467);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(135, 23);
            this.btnViewCourse.TabIndex = 42;
            this.btnViewCourse.Text = "View Course";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(766, 467);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveCourse.TabIndex = 41;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // txtSearchCourseName
            // 
            this.txtSearchCourseName.Location = new System.Drawing.Point(8, 84);
            this.txtSearchCourseName.Name = "txtSearchCourseName";
            this.txtSearchCourseName.Size = new System.Drawing.Size(326, 20);
            this.txtSearchCourseName.TabIndex = 38;
            this.txtSearchCourseName.TextChanged += new System.EventHandler(this.txtSearchCourseName_TextChanged);
            // 
            // btnSearchCourseClient
            // 
            this.btnSearchCourseClient.Location = new System.Drawing.Point(908, 467);
            this.btnSearchCourseClient.Name = "btnSearchCourseClient";
            this.btnSearchCourseClient.Size = new System.Drawing.Size(135, 23);
            this.btnSearchCourseClient.TabIndex = 40;
            this.btnSearchCourseClient.Text = "Search Course Client";
            this.btnSearchCourseClient.UseVisualStyleBackColor = true;
            this.btnSearchCourseClient.Click += new System.EventHandler(this.btnSearchCourseClient_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(626, 467);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateCourse.TabIndex = 39;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Course Name:";
            // 
            // dgvSearchCourse
            // 
            this.dgvSearchCourse.AllowUserToAddRows = false;
            this.dgvSearchCourse.AllowUserToDeleteRows = false;
            this.dgvSearchCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCourse.Location = new System.Drawing.Point(343, 12);
            this.dgvSearchCourse.Name = "dgvSearchCourse";
            this.dgvSearchCourse.ReadOnly = true;
            this.dgvSearchCourse.Size = new System.Drawing.Size(700, 449);
            this.dgvSearchCourse.TabIndex = 36;
            this.dgvSearchCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchCourse_CellContentClick);
            this.dgvSearchCourse.SelectionChanged += new System.EventHandler(this.dgvSearchCourse_SelectionChanged);
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 505);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnSearcCourseName);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.txtSearchCourseName);
            this.Controls.Add(this.btnSearchCourseClient);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchCourse);
            this.Name = "SearchCourse";
            this.Text = "SearchCourse";
            this.Load += new System.EventHandler(this.SearchCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSearcCourseName;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.TextBox txtSearchCourseName;
        private System.Windows.Forms.Button btnSearchCourseClient;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchCourse;
    }
}