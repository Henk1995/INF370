namespace Place_Order
{
    partial class PlaceOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddI = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtReferenceNum = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnARN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // rtbOrder
            // 
            this.rtbOrder.Location = new System.Drawing.Point(347, 12);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.Size = new System.Drawing.Size(267, 232);
            this.rtbOrder.TabIndex = 3;
            this.rtbOrder.Text = "";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(16, 56);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(97, 13);
            this.lblRef.TabIndex = 4;
            this.lblRef.Text = "Reference Number";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Order Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(111, 189);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(143, 23);
            this.btnAddI.TabIndex = 7;
            this.btnAddI.Text = "Add item";
            this.btnAddI.UseVisualStyleBackColor = true;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click);
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(471, 263);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(143, 23);
            this.btnPO.TabIndex = 8;
            this.btnPO.Text = "Place order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 82);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 20);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(111, 108);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(143, 20);
            this.txtUnitprice.TabIndex = 10;
            this.txtUnitprice.TextChanged += new System.EventHandler(this.txtUnitprice_TextChanged);
            // 
            // txtReferenceNum
            // 
            this.txtReferenceNum.Location = new System.Drawing.Point(111, 56);
            this.txtReferenceNum.Name = "txtReferenceNum";
            this.txtReferenceNum.Size = new System.Drawing.Size(143, 20);
            this.txtReferenceNum.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(111, 134);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 12;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 111);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(111, 161);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(143, 20);
            this.nudQuantity.TabIndex = 15;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(16, 168);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(46, 13);
            this.lblNum.TabIndex = 16;
            this.lblNum.Text = "Quantity";
            // 
            // btnARN
            // 
            this.btnARN.Location = new System.Drawing.Point(260, 54);
            this.btnARN.Name = "btnARN";
            this.btnARN.Size = new System.Drawing.Size(81, 74);
            this.btnARN.TabIndex = 17;
            this.btnARN.Text = "Add Reference Number";
            this.btnARN.UseVisualStyleBackColor = true;
            this.btnARN.Click += new System.EventHandler(this.btnARN_Click);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 298);
            this.Controls.Add(this.btnARN);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtReferenceNum);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.btnAddI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.rtbOrder);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrder";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOrder;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddI;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtReferenceNum;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnARN;
    }
}

