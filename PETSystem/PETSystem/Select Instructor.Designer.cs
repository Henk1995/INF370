namespace PETSystem
{
    partial class Select_Instructor
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectInstructor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInstructor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(172, 99);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelectInstructor
            // 
            this.btnSelectInstructor.Location = new System.Drawing.Point(39, 99);
            this.btnSelectInstructor.Name = "btnSelectInstructor";
            this.btnSelectInstructor.Size = new System.Drawing.Size(118, 23);
            this.btnSelectInstructor.TabIndex = 6;
            this.btnSelectInstructor.Text = "Select Instructor";
            this.btnSelectInstructor.UseVisualStyleBackColor = true;
            this.btnSelectInstructor.Click += new System.EventHandler(this.btnSelectInstructor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instructor";
            // 
            // cbInstructor
            // 
            this.cbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructor.FormattingEnabled = true;
            this.cbInstructor.Location = new System.Drawing.Point(124, 41);
            this.cbInstructor.Name = "cbInstructor";
            this.cbInstructor.Size = new System.Drawing.Size(166, 21);
            this.cbInstructor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Logout In:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(249, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 19);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Select_Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 137);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectInstructor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInstructor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Select_Instructor";
            this.Text = "Select_Instructor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Select_Instructor_FormClosing);
            this.Load += new System.EventHandler(this.Select_Instructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectInstructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInstructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}