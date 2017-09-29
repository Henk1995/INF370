namespace PETSystem
{
    partial class MaintainCourses
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCourseTypeP = new System.Windows.Forms.Panel();
            this.txtNCDName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMaintain = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.MaintainTCPanel = new System.Windows.Forms.Panel();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.AddCourseTypeP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintain)).BeginInit();
            this.MaintainTCPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(130, 109);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(145, 20);
            this.txtVenue.TabIndex = 7;
            this.txtVenue.TextChanged += new System.EventHandler(this.txtVenue_TextChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(130, 56);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(145, 20);
            this.txtStartDate.TabIndex = 6;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(130, 29);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(145, 21);
            this.cmbName.TabIndex = 5;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            this.cmbName.Click += new System.EventHandler(this.cmbName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration in weeks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // AddCourseTypeP
            // 
            this.AddCourseTypeP.Controls.Add(this.txtNCDName);
            this.AddCourseTypeP.Controls.Add(this.button3);
            this.AddCourseTypeP.Controls.Add(this.label9);
            this.AddCourseTypeP.Controls.Add(this.label10);
            this.AddCourseTypeP.Location = new System.Drawing.Point(6, 13);
            this.AddCourseTypeP.Name = "AddCourseTypeP";
            this.AddCourseTypeP.Size = new System.Drawing.Size(276, 190);
            this.AddCourseTypeP.TabIndex = 10;
            // 
            // txtNCDName
            // 
            this.txtNCDName.Location = new System.Drawing.Point(123, 88);
            this.txtNCDName.Name = "txtNCDName";
            this.txtNCDName.Size = new System.Drawing.Size(119, 20);
            this.txtNCDName.TabIndex = 10;
            this.txtNCDName.TextChanged += new System.EventHandler(this.txtNCDName_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // dgvMaintain
            // 
            this.dgvMaintain.AllowUserToAddRows = false;
            this.dgvMaintain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintain.Location = new System.Drawing.Point(254, 6);
            this.dgvMaintain.Name = "dgvMaintain";
            this.dgvMaintain.Size = new System.Drawing.Size(473, 186);
            this.dgvMaintain.TabIndex = 12;
            this.dgvMaintain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaintainTCPanel
            // 
            this.MaintainTCPanel.Controls.Add(this.label1);
            this.MaintainTCPanel.Controls.Add(this.cbSearch);
            this.MaintainTCPanel.Controls.Add(this.txtCourseName);
            this.MaintainTCPanel.Controls.Add(this.button4);
            this.MaintainTCPanel.Controls.Add(this.label6);
            this.MaintainTCPanel.Controls.Add(this.label7);
            this.MaintainTCPanel.Location = new System.Drawing.Point(15, 15);
            this.MaintainTCPanel.Name = "MaintainTCPanel";
            this.MaintainTCPanel.Size = new System.Drawing.Size(233, 123);
            this.MaintainTCPanel.TabIndex = 11;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(111, 73);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(119, 20);
            this.txtCourseName.TabIndex = 10;
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
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
            this.label6.Location = new System.Drawing.Point(42, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search Text:";
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(319, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 366);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Training Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddCourseTypeP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Training Course Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dgvMaintain);
            this.tabPage3.Controls.Add(this.MaintainTCPanel);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Maintain Training Course";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVenue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 196);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(254, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 22);
            this.button5.TabIndex = 13;
            this.button5.Text = "Update Training Course Type";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Course Name",
            "Start Date",
            "Course Type"});
            this.cbSearch.Location = new System.Drawing.Point(109, 46);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Paramater:";
            // 
            // MaintainCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 448);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Name = "MaintainCourses";
            this.Text = "MaintainCourses";
            this.Load += new System.EventHandler(this.MaintainCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.AddCourseTypeP.ResumeLayout(false);
            this.AddCourseTypeP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintain)).EndInit();
            this.MaintainTCPanel.ResumeLayout(false);
            this.MaintainTCPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel AddCourseTypeP;
        private System.Windows.Forms.TextBox txtNCDName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMaintain;
        private System.Windows.Forms.Panel MaintainTCPanel;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearch;
    }
}
