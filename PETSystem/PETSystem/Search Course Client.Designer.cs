namespace PETSystem
{
    partial class Search_Course_Client
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
            this.txtSearcCCSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.txtSearchCCName = new System.Windows.Forms.TextBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourseClient = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearcCCSurname
            // 
            this.txtSearcCCSurname.Location = new System.Drawing.Point(12, 178);
            this.txtSearcCCSurname.Name = "txtSearcCCSurname";
            this.txtSearcCCSurname.Size = new System.Drawing.Size(326, 20);
            this.txtSearcCCSurname.TabIndex = 56;
            this.txtSearcCCSurname.TextChanged += new System.EventHandler(this.txtSearcCCSurname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Client Surname:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(347, 473);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(180, 23);
            this.btnAddClient.TabIndex = 53;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnViewClient
            // 
            this.btnViewClient.Location = new System.Drawing.Point(533, 473);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(180, 23);
            this.btnViewClient.TabIndex = 52;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // txtSearchCCName
            // 
            this.txtSearchCCName.Location = new System.Drawing.Point(12, 90);
            this.txtSearchCCName.Name = "txtSearchCCName";
            this.txtSearchCCName.Size = new System.Drawing.Size(326, 20);
            this.txtSearchCCName.TabIndex = 49;
            this.txtSearchCCName.TextChanged += new System.EventHandler(this.txtSearchCCName_TextChanged);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(727, 473);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(180, 23);
            this.btnUpdateClient.TabIndex = 51;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(913, 473);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(180, 23);
            this.btnRemoveClient.TabIndex = 50;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Client Name:";
            // 
            // dgvCourseClient
            // 
            this.dgvCourseClient.AllowUserToAddRows = false;
            this.dgvCourseClient.AllowUserToDeleteRows = false;
            this.dgvCourseClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseClient.Location = new System.Drawing.Point(347, 18);
            this.dgvCourseClient.Name = "dgvCourseClient";
            this.dgvCourseClient.ReadOnly = true;
            this.dgvCourseClient.Size = new System.Drawing.Size(746, 449);
            this.dgvCourseClient.TabIndex = 47;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 23);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Location = new System.Drawing.Point(12, 247);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(326, 23);
            this.btnRefreshDGV.TabIndex = 59;
            this.btnRefreshDGV.Text = "Refresh DGV";
            this.btnRefreshDGV.UseVisualStyleBackColor = true;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // Search_Course_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 509);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearcCCSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.txtSearchCCName);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourseClient);
            this.Name = "Search_Course_Client";
            this.Text = "Search_Course_Client";
            this.Load += new System.EventHandler(this.Search_Course_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearcCCSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.TextBox txtSearchCCName;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourseClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefreshDGV;
    }
}