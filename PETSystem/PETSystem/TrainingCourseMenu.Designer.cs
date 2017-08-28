namespace PETSystem
{
    partial class TrainingCourseMenu
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
            this.btnMainM = new System.Windows.Forms.Button();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCourseT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVMParticipants = new System.Windows.Forms.Button();
            this.btnMCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainM
            // 
            this.btnMainM.Location = new System.Drawing.Point(1, 271);
            this.btnMainM.Name = "btnMainM";
            this.btnMainM.Size = new System.Drawing.Size(114, 34);
            this.btnMainM.TabIndex = 9;
            this.btnMainM.Text = "Main Menu";
            this.btnMainM.UseVisualStyleBackColor = true;
            this.btnMainM.Click += new System.EventHandler(this.btnMainM_Click);
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(276, 249);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(123, 39);
            this.btnAddResult.TabIndex = 8;
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // dgvTC
            // 
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Location = new System.Drawing.Point(276, 27);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.Size = new System.Drawing.Size(561, 216);
            this.dgvTC.TabIndex = 7;
            this.dgvTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name:";
            // 
            // txtCourseN
            // 
            this.txtCourseN.Location = new System.Drawing.Point(113, 66);
            this.txtCourseN.Name = "txtCourseN";
            this.txtCourseN.Size = new System.Drawing.Size(122, 20);
            this.txtCourseN.TabIndex = 1;
            this.txtCourseN.TextChanged += new System.EventHandler(this.txtCourseN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Course";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCourseT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCourseN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 136);
            this.panel1.TabIndex = 6;
            // 
            // txtCourseT
            // 
            this.txtCourseT.Location = new System.Drawing.Point(113, 100);
            this.txtCourseT.Name = "txtCourseT";
            this.txtCourseT.Size = new System.Drawing.Size(122, 20);
            this.txtCourseT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course Type:";
            // 
            // btnVMParticipants
            // 
            this.btnVMParticipants.Location = new System.Drawing.Point(405, 249);
            this.btnVMParticipants.Name = "btnVMParticipants";
            this.btnVMParticipants.Size = new System.Drawing.Size(194, 39);
            this.btnVMParticipants.TabIndex = 10;
            this.btnVMParticipants.Text = "View/Maintain Participants";
            this.btnVMParticipants.UseVisualStyleBackColor = true;
            // 
            // btnMCourses
            // 
            this.btnMCourses.Location = new System.Drawing.Point(12, 6);
            this.btnMCourses.Name = "btnMCourses";
            this.btnMCourses.Size = new System.Drawing.Size(123, 39);
            this.btnMCourses.TabIndex = 11;
            this.btnMCourses.Text = "Maintain Courses";
            this.btnMCourses.UseVisualStyleBackColor = true;
            this.btnMCourses.Click += new System.EventHandler(this.btnMCourses_Click);
            // 
            // TrainingCourseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 318);
            this.Controls.Add(this.btnMCourses);
            this.Controls.Add(this.btnVMParticipants);
            this.Controls.Add(this.btnMainM);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.dgvTC);
            this.Controls.Add(this.panel1);
            this.Name = "TrainingCourseMenu";
            this.Text = "TrainingCourseMenu";
            this.Load += new System.EventHandler(this.TrainingCourseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        //private INF370DataSet iNF370DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn priveledgeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMainM;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCourseT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVMParticipants;
        private System.Windows.Forms.Button btnMCourses;
    }
}