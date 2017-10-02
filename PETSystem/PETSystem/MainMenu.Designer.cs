namespace PETSystem
{
    partial class MainMenuF
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
            this.Logout = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.inf370RegDataSet = new PETSystem.inf370RegDataSet();
            this.applicationFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationFormTableAdapter = new PETSystem.inf370RegDataSetTableAdapters.ApplicationFormTableAdapter();
            this.tableAdapterManager = new PETSystem.inf370RegDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf370RegDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 440);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(144, 31);
            this.Logout.TabIndex = 19;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 304);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 117);
            this.button8.TabIndex = 18;
            this.button8.Text = "Stock";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(198, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 117);
            this.button7.TabIndex = 17;
            this.button7.Text = "Courses";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(383, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 117);
            this.button6.TabIndex = 16;
            this.button6.Text = "Reports";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(383, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 117);
            this.button5.TabIndex = 15;
            this.button5.Text = "Printers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 117);
            this.button4.TabIndex = 14;
            this.button4.Text = "Orders";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 117);
            this.button3.TabIndex = 13;
            this.button3.Text = "Suppliers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 117);
            this.button2.TabIndex = 12;
            this.button2.Text = "Instructors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 117);
            this.button1.TabIndex = 11;
            this.button1.Text = "Instructor Training";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(12, 49);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(144, 117);
            this.Users.TabIndex = 10;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "PET System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(655, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(655, 271);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // inf370RegDataSet
            // 
            this.inf370RegDataSet.DataSetName = "inf370RegDataSet";
            this.inf370RegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationFormBindingSource
            // 
            this.applicationFormBindingSource.DataMember = "ApplicationForm";
            this.applicationFormBindingSource.DataSource = this.inf370RegDataSet;
            // 
            // applicationFormTableAdapter
            // 
            this.applicationFormTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationFormTableAdapter = this.applicationFormTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.ClientCourseLineTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CourseInstanceTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.CourseTimesTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DamagedStockTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = null;
            this.tableAdapterManager.MailingListTableAdapter = null;
            this.tableAdapterManager.OrderLineTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.PictureTableTableAdapter = null;
            this.tableAdapterManager.PrinterOrderTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.PrivilegeTypeTableAdapter = null;
            this.tableAdapterManager.QualifiedCoursesTableAdapter = null;
            this.tableAdapterManager.RefundTableAdapter = null;
            this.tableAdapterManager.ResultsTableAdapter = null;
            this.tableAdapterManager.RoyaltiesCourseTableAdapter = null;
            this.tableAdapterManager.RoyaltiesOrderTableAdapter = null;
            this.tableAdapterManager.StockLineTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StockTypeTableAdapter = null;
            this.tableAdapterManager.SupplierOrderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.SupplierTypeTableAdapter = null;
            this.tableAdapterManager.TableOrderTableAdapter = null;
            this.tableAdapterManager.TimeSlotTableAdapter = null;
            this.tableAdapterManager.TitleTableAdapter = null;
            this.tableAdapterManager.TrainingCourseLineTableAdapter = null;
            this.tableAdapterManager.TrainingCourseTableAdapter = null;
            this.tableAdapterManager.TrainingCourseTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PETSystem.inf370RegDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = null;
            // 
            // MainMenuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Users);
            this.Name = "MainMenuF";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf370RegDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private inf370RegDataSet inf370RegDataSet;
        private System.Windows.Forms.BindingSource applicationFormBindingSource;
        private inf370RegDataSetTableAdapters.ApplicationFormTableAdapter applicationFormTableAdapter;
        private inf370RegDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}