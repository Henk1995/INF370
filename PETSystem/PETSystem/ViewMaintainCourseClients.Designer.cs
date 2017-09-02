namespace PETSystem
{
    partial class ViewMaintainCourseClients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClientsAvailable = new System.Windows.Forms.DataGridView();
            this.dgvClientCourseLine = new System.Windows.Forms.DataGridView();
            this.btnAddClientToCourse = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCourseLine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClientsAvailable);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients List:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClientCourseLine);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Clients:";
            // 
            // dgvClientsAvailable
            // 
            this.dgvClientsAvailable.AllowUserToAddRows = false;
            this.dgvClientsAvailable.AllowUserToDeleteRows = false;
            this.dgvClientsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsAvailable.Location = new System.Drawing.Point(7, 20);
            this.dgvClientsAvailable.Name = "dgvClientsAvailable";
            this.dgvClientsAvailable.ReadOnly = true;
            this.dgvClientsAvailable.Size = new System.Drawing.Size(654, 190);
            this.dgvClientsAvailable.TabIndex = 0;
            this.dgvClientsAvailable.SelectionChanged += new System.EventHandler(this.dgvClientsAvailable_SelectionChanged);
            // 
            // dgvClientCourseLine
            // 
            this.dgvClientCourseLine.AllowUserToAddRows = false;
            this.dgvClientCourseLine.AllowUserToDeleteRows = false;
            this.dgvClientCourseLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCourseLine.Location = new System.Drawing.Point(6, 19);
            this.dgvClientCourseLine.Name = "dgvClientCourseLine";
            this.dgvClientCourseLine.ReadOnly = true;
            this.dgvClientCourseLine.Size = new System.Drawing.Size(654, 190);
            this.dgvClientCourseLine.TabIndex = 1;
            this.dgvClientCourseLine.SelectionChanged += new System.EventHandler(this.dgvClientCourseLine_SelectionChanged);
            // 
            // btnAddClientToCourse
            // 
            this.btnAddClientToCourse.Location = new System.Drawing.Point(19, 243);
            this.btnAddClientToCourse.Name = "btnAddClientToCourse";
            this.btnAddClientToCourse.Size = new System.Drawing.Size(312, 23);
            this.btnAddClientToCourse.TabIndex = 1;
            this.btnAddClientToCourse.Text = "Add Selected Client to Course";
            this.btnAddClientToCourse.UseVisualStyleBackColor = true;
            this.btnAddClientToCourse.Click += new System.EventHandler(this.btnAddClientToCourse_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(348, 243);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(325, 23);
            this.btnRemoveClient.TabIndex = 2;
            this.btnRemoveClient.Text = "Remove Selected Client from Course";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewMaintainCourseClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnAddClientToCourse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewMaintainCourseClients";
            this.Text = "ViewMaintainCourseClients";
            this.Load += new System.EventHandler(this.ViewMaintainCourseClients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCourseLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientsAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClientCourseLine;
        private System.Windows.Forms.Button btnAddClientToCourse;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnBack;
    }
}