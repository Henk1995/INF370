﻿namespace PETSystem
{
    partial class WriteoffStock
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
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.txtWriteoffQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStockUnitPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStockDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(166, 184);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(19, 13);
            this.lblStockQuantity.TabIndex = 127;
            this.lblStockQuantity.Text = "50";
            // 
            // txtWriteoffQuantity
            // 
            this.txtWriteoffQuantity.Location = new System.Drawing.Point(169, 215);
            this.txtWriteoffQuantity.Name = "txtWriteoffQuantity";
            this.txtWriteoffQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtWriteoffQuantity.TabIndex = 126;
            this.txtWriteoffQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtWriteoffQuantity.Leave += new System.EventHandler(this.txtWriteoffQuantity_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "Writeoff Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "Quantity on hand:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 123;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStockUnitPrice
            // 
            this.lblStockUnitPrice.AutoSize = true;
            this.lblStockUnitPrice.Location = new System.Drawing.Point(166, 112);
            this.lblStockUnitPrice.Name = "lblStockUnitPrice";
            this.lblStockUnitPrice.Size = new System.Drawing.Size(40, 13);
            this.lblStockUnitPrice.TabIndex = 122;
            this.lblStockUnitPrice.Text = "250.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Stock Description:";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(166, 150);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(39, 13);
            this.lblStockType.TabIndex = 119;
            this.lblStockType.Text = "Book\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 118;
            // 
            // lblStockDesc
            // 
            this.lblStockDesc.AutoSize = true;
            this.lblStockDesc.Location = new System.Drawing.Point(166, 76);
            this.lblStockDesc.Name = "lblStockDesc";
            this.lblStockDesc.Size = new System.Drawing.Size(131, 13);
            this.lblStockDesc.TabIndex = 117;
            this.lblStockDesc.Text = "Workbook for PET course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Stock Type:";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Location = new System.Drawing.Point(166, 31);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(31, 13);
            this.lblStockID.TabIndex = 115;
            this.lblStockID.Text = "0002";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 114;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Stock ID";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(169, 250);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(134, 20);
            this.txtReason.TabIndex = 129;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            this.txtReason.Leave += new System.EventHandler(this.txtReason_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Reason for Writeoff:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(169, 286);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(134, 20);
            this.txtDate.TabIndex = 131;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "Date: (dd/mm/yy)";
            // 
            // WriteoffStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 393);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.txtWriteoffQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStockUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStockDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WriteoffStock";
            this.Text = "WriteoffStock";
            this.Load += new System.EventHandler(this.WriteoffStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.TextBox txtWriteoffQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStockUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
    }
}