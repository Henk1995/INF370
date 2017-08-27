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
            this.btnSearchCCSurname = new System.Windows.Forms.Button();
            this.txtSearcCCSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearcCCName = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.txtSearchCCName = new System.Windows.Forms.TextBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourseClient = new System.Windows.Forms.DataGridView();
            this.columnnn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCCSurname
            // 
            this.btnSearchCCSurname.Location = new System.Drawing.Point(12, 204);
            this.btnSearchCCSurname.Name = "btnSearchCCSurname";
            this.btnSearchCCSurname.Size = new System.Drawing.Size(326, 23);
            this.btnSearchCCSurname.TabIndex = 57;
            this.btnSearchCCSurname.Text = "Search Client Surname";
            this.btnSearchCCSurname.UseVisualStyleBackColor = true;
            this.btnSearchCCSurname.Click += new System.EventHandler(this.btnSearchCCSurname_Click);
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
            // btnSearcCCName
            // 
            this.btnSearcCCName.Location = new System.Drawing.Point(12, 116);
            this.btnSearcCCName.Name = "btnSearcCCName";
            this.btnSearcCCName.Size = new System.Drawing.Size(326, 23);
            this.btnSearcCCName.TabIndex = 54;
            this.btnSearcCCName.Text = "Search Client Name";
            this.btnSearcCCName.UseVisualStyleBackColor = true;
            this.btnSearcCCName.Click += new System.EventHandler(this.btnSearcCCName_Click);
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
            this.dgvCourseClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnnn1,
            this.Column2,
            this.Column1,
            this.Column4,
            this.Gender,
            this.Column3,
            this.Column5});
            this.dgvCourseClient.Location = new System.Drawing.Point(347, 18);
            this.dgvCourseClient.Name = "dgvCourseClient";
            this.dgvCourseClient.Size = new System.Drawing.Size(746, 449);
            this.dgvCourseClient.TabIndex = 47;
            // 
            // columnnn1
            // 
            this.columnnn1.HeaderText = "Client ID";
            this.columnnn1.Name = "columnnn1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Surname";
            this.Column4.Name = "Column4";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone Number";
            this.Column5.Name = "Column5";
            // 
            // Search_Course_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 509);
            this.Controls.Add(this.btnSearchCCSurname);
            this.Controls.Add(this.txtSearcCCSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearcCCName);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.txtSearchCCName);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourseClient);
            this.Name = "Search_Course_Client";
            this.Text = "Search_Course_Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCCSurname;
        private System.Windows.Forms.TextBox txtSearcCCSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearcCCName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.TextBox txtSearchCCName;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourseClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnnn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}