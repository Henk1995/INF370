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
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.addTrainingCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainTrainingCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCoursePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaintain = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.MaintainTCPanel = new System.Windows.Forms.Panel();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.MSMain.SuspendLayout();
            this.AddCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintain)).BeginInit();
            this.MaintainTCPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainingCourseToolStripMenuItem,
            this.maintainTrainingCourseToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(752, 24);
            this.MSMain.TabIndex = 0;
            this.MSMain.Text = "menuStrip1";
            // 
            // addTrainingCourseToolStripMenuItem
            // 
            this.addTrainingCourseToolStripMenuItem.Name = "addTrainingCourseToolStripMenuItem";
            this.addTrainingCourseToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.addTrainingCourseToolStripMenuItem.Text = "Add Training Course";
            this.addTrainingCourseToolStripMenuItem.Click += new System.EventHandler(this.addTrainingCourseToolStripMenuItem_Click);
            // 
            // maintainTrainingCourseToolStripMenuItem
            // 
            this.maintainTrainingCourseToolStripMenuItem.Name = "maintainTrainingCourseToolStripMenuItem";
            this.maintainTrainingCourseToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.maintainTrainingCourseToolStripMenuItem.Text = "Maintain Training Course";
            this.maintainTrainingCourseToolStripMenuItem.Click += new System.EventHandler(this.maintainTrainingCourseToolStripMenuItem_Click);
            // 
            // AddCoursePanel
            // 
            this.AddCoursePanel.Controls.Add(this.button1);
            this.AddCoursePanel.Controls.Add(this.numericUpDown1);
            this.AddCoursePanel.Controls.Add(this.txtVenue);
            this.AddCoursePanel.Controls.Add(this.txtStartDate);
            this.AddCoursePanel.Controls.Add(this.cmbName);
            this.AddCoursePanel.Controls.Add(this.label5);
            this.AddCoursePanel.Controls.Add(this.label4);
            this.AddCoursePanel.Controls.Add(this.label3);
            this.AddCoursePanel.Controls.Add(this.label2);
            this.AddCoursePanel.Controls.Add(this.label1);
            this.AddCoursePanel.Location = new System.Drawing.Point(3, 156);
            this.AddCoursePanel.Name = "AddCoursePanel";
            this.AddCoursePanel.Size = new System.Drawing.Size(276, 202);
            this.AddCoursePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 93);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(128, 121);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(145, 20);
            this.txtVenue.TabIndex = 7;
            this.txtVenue.TextChanged += new System.EventHandler(this.txtVenue_TextChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(128, 68);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(145, 20);
            this.txtStartDate.TabIndex = 6;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(128, 41);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(145, 21);
            this.cmbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration in weeks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
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
            // dgvMaintain
            // 
            this.dgvMaintain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintain.Location = new System.Drawing.Point(285, 27);
            this.dgvMaintain.Name = "dgvMaintain";
            this.dgvMaintain.Size = new System.Drawing.Size(469, 186);
            this.dgvMaintain.TabIndex = 12;
            this.dgvMaintain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaintainTCPanel
            // 
            this.MaintainTCPanel.Controls.Add(this.txtCourseName);
            this.MaintainTCPanel.Controls.Add(this.button4);
            this.MaintainTCPanel.Controls.Add(this.label6);
            this.MaintainTCPanel.Controls.Add(this.label7);
            this.MaintainTCPanel.Location = new System.Drawing.Point(3, 27);
            this.MaintainTCPanel.Name = "MaintainTCPanel";
            this.MaintainTCPanel.Size = new System.Drawing.Size(276, 123);
            this.MaintainTCPanel.TabIndex = 11;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(89, 33);
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
            this.label6.Location = new System.Drawing.Point(7, 36);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MaintainCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 411);
            this.Controls.Add(this.dgvMaintain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AddCoursePanel);
            this.Controls.Add(this.MaintainTCPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MSMain);
            this.MainMenuStrip = this.MSMain;
            this.Name = "MaintainCourses";
            this.Text = "MaintainCourses";
            this.Load += new System.EventHandler(this.MaintainCourses_Load);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.AddCoursePanel.ResumeLayout(false);
            this.AddCoursePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintain)).EndInit();
            this.MaintainTCPanel.ResumeLayout(false);
            this.MaintainTCPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem addTrainingCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainTrainingCourseToolStripMenuItem;
        private System.Windows.Forms.Panel AddCoursePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvMaintain;
        private System.Windows.Forms.Panel MaintainTCPanel;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}