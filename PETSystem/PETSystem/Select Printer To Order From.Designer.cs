namespace PETSystem
{
    partial class Select_Printer_To_Order_From
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
            this.btnSelectInstructor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInstructor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(177, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelectInstructor
            // 
            this.btnSelectInstructor.Location = new System.Drawing.Point(44, 100);
            this.btnSelectInstructor.Name = "btnSelectInstructor";
            this.btnSelectInstructor.Size = new System.Drawing.Size(118, 23);
            this.btnSelectInstructor.TabIndex = 10;
            this.btnSelectInstructor.Text = "Select Instructor";
            this.btnSelectInstructor.UseVisualStyleBackColor = true;
            this.btnSelectInstructor.Click += new System.EventHandler(this.btnSelectInstructor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Instructor";
            // 
            // cbInstructor
            // 
            this.cbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructor.FormattingEnabled = true;
            this.cbInstructor.Location = new System.Drawing.Point(129, 42);
            this.cbInstructor.Name = "cbInstructor";
            this.cbInstructor.Size = new System.Drawing.Size(166, 21);
            this.cbInstructor.TabIndex = 8;
            // 
            // Select_Printer_To_Order_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 188);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectInstructor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInstructor);
            this.Name = "Select_Printer_To_Order_From";
            this.Text = "Select_Printer_To_Order_From";
            this.Load += new System.EventHandler(this.Select_Printer_To_Order_From_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectInstructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInstructor;
    }
}