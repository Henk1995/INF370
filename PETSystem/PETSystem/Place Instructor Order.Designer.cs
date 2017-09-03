namespace PETSystem
{
    partial class Place_Instructor_Order
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
            this.btnARN = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtReferenceNum = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnAddI = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnARN
            // 
            this.btnARN.Location = new System.Drawing.Point(257, 23);
            this.btnARN.Name = "btnARN";
            this.btnARN.Size = new System.Drawing.Size(81, 50);
            this.btnARN.TabIndex = 33;
            this.btnARN.Text = "Add Reference Number";
            this.btnARN.UseVisualStyleBackColor = true;
            this.btnARN.Click += new System.EventHandler(this.btnARN_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(7, 108);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(108, 105);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 28;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtReferenceNum
            // 
            this.txtReferenceNum.Location = new System.Drawing.Point(108, 23);
            this.txtReferenceNum.Name = "txtReferenceNum";
            this.txtReferenceNum.Size = new System.Drawing.Size(143, 20);
            this.txtReferenceNum.TabIndex = 27;
            this.txtReferenceNum.TextChanged += new System.EventHandler(this.txtReferenceNum_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(108, 79);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 20);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(468, 260);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(143, 23);
            this.btnPO.TabIndex = 24;
            this.btnPO.Text = "Place order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(108, 157);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(143, 52);
            this.btnAddI.TabIndex = 23;
            this.btnAddI.Text = "Add item";
            this.btnAddI.UseVisualStyleBackColor = true;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 260);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Order Description";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(7, 26);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(97, 13);
            this.lblRef.TabIndex = 20;
            this.lblRef.Text = "Reference Number";
            // 
            // rtbOrder
            // 
            this.rtbOrder.Location = new System.Drawing.Point(344, 9);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.Size = new System.Drawing.Size(267, 232);
            this.rtbOrder.TabIndex = 19;
            this.rtbOrder.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(257, 79);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 46);
            this.btnGo.TabIndex = 34;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Place_Instructor_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 297);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnARN);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtReferenceNum);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.btnAddI);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.rtbOrder);
            this.Controls.Add(this.label1);
            this.Name = "Place_Instructor_Order";
            this.Text = "Place Instructor Order";
            this.Load += new System.EventHandler(this.Place_Instructor_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnARN;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtReferenceNum;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnAddI;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.RichTextBox rtbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
    }
}