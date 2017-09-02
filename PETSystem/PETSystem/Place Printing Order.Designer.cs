namespace PETSystem
{
    partial class Place_Printing_Order
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnARN
            // 
            this.btnARN.Location = new System.Drawing.Point(254, 54);
            this.btnARN.Name = "btnARN";
            this.btnARN.Size = new System.Drawing.Size(81, 74);
            this.btnARN.TabIndex = 49;
            this.btnARN.Text = "Add Reference Number";
            this.btnARN.UseVisualStyleBackColor = true;
            this.btnARN.Click += new System.EventHandler(this.btnARN_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(105, 109);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 44;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtReferenceNum
            // 
            this.txtReferenceNum.Location = new System.Drawing.Point(105, 56);
            this.txtReferenceNum.Name = "txtReferenceNum";
            this.txtReferenceNum.Size = new System.Drawing.Size(143, 20);
            this.txtReferenceNum.TabIndex = 43;
            this.txtReferenceNum.TextChanged += new System.EventHandler(this.txtReferenceNum_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 82);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 20);
            this.txtDescription.TabIndex = 41;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(465, 263);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(143, 23);
            this.btnPO.TabIndex = 40;
            this.btnPO.Text = "Place order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(105, 161);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(143, 23);
            this.btnAddI.TabIndex = 39;
            this.btnAddI.Text = "Add item";
            this.btnAddI.UseVisualStyleBackColor = true;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 263);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 13);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Order Description";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(10, 59);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(97, 13);
            this.lblRef.TabIndex = 36;
            this.lblRef.Text = "Reference Number";
            // 
            // rtbOrder
            // 
            this.rtbOrder.Location = new System.Drawing.Point(341, 12);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.Size = new System.Drawing.Size(267, 232);
            this.rtbOrder.TabIndex = 35;
            this.rtbOrder.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 34;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 135);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(143, 20);
            this.txtQuantity.TabIndex = 50;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Quantity";
            // 
            // Place_Printing_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 307);
            this.Controls.Add(this.label2);
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
            this.Name = "Place_Printing_Order";
            this.Text = "Place_Printing_Order";
            this.Load += new System.EventHandler(this.Place_Printing_Order_Load);
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
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
    }
}