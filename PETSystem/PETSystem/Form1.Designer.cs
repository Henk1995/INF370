namespace PETSystem
{
    partial class Form1
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
            this.btnPrintingSupplier = new System.Windows.Forms.Button();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintingSupplier
            // 
            this.btnPrintingSupplier.Location = new System.Drawing.Point(184, 38);
            this.btnPrintingSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintingSupplier.Name = "btnPrintingSupplier";
            this.btnPrintingSupplier.Size = new System.Drawing.Size(103, 55);
            this.btnPrintingSupplier.TabIndex = 1;
            this.btnPrintingSupplier.Text = "Printing Supplier";
            this.btnPrintingSupplier.UseVisualStyleBackColor = true;
            this.btnPrintingSupplier.Click += new System.EventHandler(this.btnPrintingSupplier_Click);
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(326, 38);
            this.btnSearchCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(103, 55);
            this.btnSearchCourse.TabIndex = 2;
            this.btnSearchCourse.Text = "Search Course";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 268);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.btnPrintingSupplier);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrintingSupplier;
        private System.Windows.Forms.Button btnSearchCourse;
    }
}

