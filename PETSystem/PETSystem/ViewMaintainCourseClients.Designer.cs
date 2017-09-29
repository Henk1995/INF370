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
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvClientCourseLine = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMainM = new System.Windows.Forms.Button();
            this.dgvClientsAvailable = new System.Windows.Forms.DataGridView();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCourseLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(238, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Search Clients:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Search Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Clients In Selected Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course Clients In system";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvClientCourseLine
            // 
            this.dgvClientCourseLine.AllowUserToAddRows = false;
            this.dgvClientCourseLine.AllowUserToDeleteRows = false;
            this.dgvClientCourseLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCourseLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_Name,
            this.ResultID});
            this.dgvClientCourseLine.Location = new System.Drawing.Point(238, 231);
            this.dgvClientCourseLine.MultiSelect = false;
            this.dgvClientCourseLine.Name = "dgvClientCourseLine";
            this.dgvClientCourseLine.ReadOnly = true;
            this.dgvClientCourseLine.Size = new System.Drawing.Size(583, 129);
            this.dgvClientCourseLine.TabIndex = 31;
            this.dgvClientCourseLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientCourseLine_CellContentClick);
            this.dgvClientCourseLine.SelectionChanged += new System.EventHandler(this.dgvClientCourseLine_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(627, 366);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(194, 39);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMainM
            // 
            this.btnMainM.Location = new System.Drawing.Point(14, 366);
            this.btnMainM.Name = "btnMainM";
            this.btnMainM.Size = new System.Drawing.Size(114, 34);
            this.btnMainM.TabIndex = 28;
            this.btnMainM.Text = "Main Menu";
            this.btnMainM.UseVisualStyleBackColor = true;
            this.btnMainM.Click += new System.EventHandler(this.btnMainM_Click);
            // 
            // dgvClientsAvailable
            // 
            this.dgvClientsAvailable.AllowUserToAddRows = false;
            this.dgvClientsAvailable.AllowUserToDeleteRows = false;
            this.dgvClientsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsAvailable.Location = new System.Drawing.Point(238, 47);
            this.dgvClientsAvailable.MultiSelect = false;
            this.dgvClientsAvailable.Name = "dgvClientsAvailable";
            this.dgvClientsAvailable.ReadOnly = true;
            this.dgvClientsAvailable.Size = new System.Drawing.Size(583, 138);
            this.dgvClientsAvailable.TabIndex = 27;
            this.dgvClientsAvailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientsAvailable_CellContentClick);
            this.dgvClientsAvailable.SelectionChanged += new System.EventHandler(this.dgvClientsAvailable_SelectionChanged);
            // 
            // Client_Name
            // 
            this.Client_Name.HeaderText = "Client Name";
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.ReadOnly = true;
            // 
            // ResultID
            // 
            this.ResultID.HeaderText = "Result";
            this.ResultID.Name = "ResultID";
            this.ResultID.ReadOnly = true;
            // 
            // ViewMaintainCourseClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 430);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvClientCourseLine);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnMainM);
            this.Controls.Add(this.dgvClientsAvailable);
            this.Controls.Add(this.btnBack);
            this.Name = "ViewMaintainCourseClients";
            this.Text = "ViewMaintainCourseClients";
            this.Load += new System.EventHandler(this.ViewMaintainCourseClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCourseLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClientCourseLine;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMainM;
        private System.Windows.Forms.DataGridView dgvClientsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultID;
    }
}