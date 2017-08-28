namespace PETSystem
{
    partial class ViewInstructor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.dgvInstructor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Instructor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "InstructorID";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(83, 43);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(154, 20);
            this.txtInstructorID.TabIndex = 4;
            this.txtInstructorID.TextChanged += new System.EventHandler(this.txtInstructorID_TextChanged);
            // 
            // dgvInstructor
            // 
            this.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructor.Location = new System.Drawing.Point(293, 43);
            this.dgvInstructor.Name = "dgvInstructor";
            this.dgvInstructor.Size = new System.Drawing.Size(517, 194);
            this.dgvInstructor.TabIndex = 8;
            // 
            // ViewInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 261);
            this.Controls.Add(this.dgvInstructor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstructorID);
            this.Name = "ViewInstructor";
            this.Text = "View Instructor";
            this.Load += new System.EventHandler(this.ViewInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.DataGridView dgvInstructor;
    }
}