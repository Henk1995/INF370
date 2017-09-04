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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(14, 132);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 65;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(107, 129);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(143, 20);
            this.txtQuantity.TabIndex = 64;
            // 
            // btnARN
            // 
            this.btnARN.Location = new System.Drawing.Point(256, 48);
            this.btnARN.Name = "btnARN";
            this.btnARN.Size = new System.Drawing.Size(81, 74);
            this.btnARN.TabIndex = 63;
            this.btnARN.Text = "Add Reference Number";
            this.btnARN.UseVisualStyleBackColor = true;
            this.btnARN.Click += new System.EventHandler(this.btnARN_Click_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 106);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 62;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(107, 103);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 61;
            // 
            // txtReferenceNum
            // 
            this.txtReferenceNum.Location = new System.Drawing.Point(107, 50);
            this.txtReferenceNum.Name = "txtReferenceNum";
            this.txtReferenceNum.Size = new System.Drawing.Size(143, 20);
            this.txtReferenceNum.TabIndex = 60;
            this.txtReferenceNum.TextChanged += new System.EventHandler(this.txtReferenceNum_TextChanged_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 20);
            this.txtDescription.TabIndex = 59;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged_1);
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(467, 257);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(143, 23);
            this.btnPO.TabIndex = 58;
            this.btnPO.Text = "Place order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click_1);
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(107, 155);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(143, 23);
            this.btnAddI.TabIndex = 57;
            this.btnAddI.Text = "Add item";
            this.btnAddI.UseVisualStyleBackColor = true;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 257);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 13);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Order Description";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(12, 53);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(97, 13);
            this.lblRef.TabIndex = 54;
            this.lblRef.Text = "Reference Number";
            // 
            // rtbOrder
            // 
            this.rtbOrder.Location = new System.Drawing.Point(343, 6);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.Size = new System.Drawing.Size(267, 232);
            this.rtbOrder.TabIndex = 53;
            this.rtbOrder.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 52;
            // 
            // Place_Instructor_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 297);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
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

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
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
    }
}