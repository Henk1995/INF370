namespace PETSystem
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
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.txtSearchCourseName = new System.Windows.Forms.TextBox();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchCourse = new System.Windows.Forms.DataGridView();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(8, 305);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(213, 23);
            this.btnMainMenu.TabIndex = 48;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(227, 305);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(97, 23);
            this.btnAddCourse.TabIndex = 47;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(330, 304);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(97, 23);
            this.btnViewCourse.TabIndex = 42;
            this.btnViewCourse.Text = "View Course";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(536, 305);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(97, 23);
            this.btnRemoveCourse.TabIndex = 41;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // txtSearchCourseName
            // 
            this.txtSearchCourseName.Location = new System.Drawing.Point(8, 84);
            this.txtSearchCourseName.Name = "txtSearchCourseName";
            this.txtSearchCourseName.Size = new System.Drawing.Size(213, 20);
            this.txtSearchCourseName.TabIndex = 38;
            this.txtSearchCourseName.TextChanged += new System.EventHandler(this.txtSearchCourseName_TextChanged);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(433, 305);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(97, 23);
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
            this.dgvSearchCourse.Location = new System.Drawing.Point(227, 12);
            this.dgvSearchCourse.Name = "dgvSearchCourse";
            this.dgvSearchCourse.ReadOnly = true;
            this.dgvSearchCourse.Size = new System.Drawing.Size(658, 288);
            this.dgvSearchCourse.TabIndex = 36;
            this.dgvSearchCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchCourse_CellContentClick);
            this.dgvSearchCourse.SelectionChanged += new System.EventHandler(this.dgvSearchCourse_SelectionChanged);
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Location = new System.Drawing.Point(8, 150);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(213, 23);
            this.btnRefreshDGV.TabIndex = 49;
            this.btnRefreshDGV.Text = "Refresh DGV";
            this.btnRefreshDGV.UseVisualStyleBackColor = true;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Search Course Clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 342);
            this.Controls.Add(this.dgvSearchCourse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.txtSearchCourseName);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.TextBox txtSearchCourseName;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchCourse;
        private System.Windows.Forms.Button btnRefreshDGV;
        private System.Windows.Forms.Button button1;
    }
}