﻿namespace PETSystem
{
    partial class CalculateRoyalties
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvInstructor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(34, 205);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructor ID";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(70, 48);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(156, 20);
            this.txtInstructorID.TabIndex = 5;
            this.txtInstructorID.TextChanged += new System.EventHandler(this.txtInstructorID_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(70, 104);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Royalties";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvInstructor
            // 
            this.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructor.Location = new System.Drawing.Point(256, 48);
            this.dgvInstructor.Name = "dgvInstructor";
            this.dgvInstructor.Size = new System.Drawing.Size(600, 189);
            this.dgvInstructor.TabIndex = 8;
            // 
            // CalculateRoyalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 302);
            this.Controls.Add(this.dgvInstructor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstructorID);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculateRoyalties";
            this.Text = "Calculate Royalties";
            this.Load += new System.EventHandler(this.CalculateRoyalties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvInstructor;
    }
}