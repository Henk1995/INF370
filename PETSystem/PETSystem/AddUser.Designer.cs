namespace PETSystem
{
    partial class AddUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddU = new System.Windows.Forms.Button();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAddU);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 269);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(78, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 25);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnAddU
            // 
            this.btnAddU.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddU.Location = new System.Drawing.Point(403, 233);
            this.btnAddU.Name = "btnAddU";
            this.btnAddU.Size = new System.Drawing.Size(96, 31);
            this.btnAddU.TabIndex = 14;
            this.btnAddU.Text = "Add User";
            this.btnAddU.UseVisualStyleBackColor = true;
            this.btnAddU.Click += new System.EventHandler(this.btnAddU_Click);
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.DisplayMember = "PrivName";
            this.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilege.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrivilege.FormattingEnabled = true;
            this.cmbPrivilege.Location = new System.Drawing.Point(78, 87);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(124, 26);
            this.cmbPrivilege.TabIndex = 13;
            this.cmbPrivilege.ValueMember = "PrivName";
            this.cmbPrivilege.SelectedIndexChanged += new System.EventHandler(this.cmbPrivilege_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Privilege:";
            // 
            // txtRetype
            // 
            this.txtRetype.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetype.Location = new System.Drawing.Point(351, 56);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(128, 25);
            this.txtRetype.TabIndex = 11;
            this.txtRetype.TextChanged += new System.EventHandler(this.txtRetype_TextChanged);
            this.txtRetype.Leave += new System.EventHandler(this.txtRetype_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Re-Type Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(78, 56);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(124, 25);
            this.txtPass.TabIndex = 9;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // txtUserN
            // 
            this.txtUserN.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserN.Location = new System.Drawing.Point(78, 22);
            this.txtUserN.Name = "txtUserN";
            this.txtUserN.Size = new System.Drawing.Size(124, 25);
            this.txtUserN.TabIndex = 7;
            this.txtUserN.TextChanged += new System.EventHandler(this.txtUserN_TextChanged);
            this.txtUserN.Leave += new System.EventHandler(this.txtUserN_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(349, 24);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(130, 25);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(78, 24);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(124, 25);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            this.txtFirst.Leave += new System.EventHandler(this.txtFirst_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(403, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logout In:";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogout.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLogout.Location = new System.Drawing.Point(452, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(73, 19);
            this.lblLogout.TabIndex = 17;
            this.lblLogout.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRetype);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUserN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.cmbPrivilege);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 119);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Details:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 270);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(528, 308);
            this.MinimumSize = new System.Drawing.Size(528, 308);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddU;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}