namespace PETSystem
{
    partial class AddStock
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStockDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblstockID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(159, 193);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtQuantity.TabIndex = 110;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 109;
            this.label11.Text = "Quantity:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(156, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 107;
            this.lblPrice.Text = "250.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Stock Description:";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(156, 162);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(39, 13);
            this.lblStockType.TabIndex = 104;
            this.lblStockType.Text = "Book\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 103;
            // 
            // lblStockDesc
            // 
            this.lblStockDesc.AutoSize = true;
            this.lblStockDesc.Location = new System.Drawing.Point(156, 88);
            this.lblStockDesc.Name = "lblStockDesc";
            this.lblStockDesc.Size = new System.Drawing.Size(131, 13);
            this.lblStockDesc.TabIndex = 102;
            this.lblStockDesc.Text = "Workbook for PET course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Stock Type:";
            // 
            // lblstockID
            // 
            this.lblstockID.AutoSize = true;
            this.lblstockID.Location = new System.Drawing.Point(156, 43);
            this.lblstockID.Name = "lblstockID";
            this.lblstockID.Size = new System.Drawing.Size(31, 13);
            this.lblstockID.TabIndex = 100;
            this.lblstockID.Text = "0002";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 23);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Stock ID";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 292);
            this.ControlBox = false;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStockDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstockID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblstockID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}