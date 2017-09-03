namespace PETSystem
{
    partial class Log_Order_Refund
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
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrinterOrderID = new System.Windows.Forms.TextBox();
            this.dgvPrinterOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 22);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Location = new System.Drawing.Point(68, 143);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(246, 31);
            this.btnReturnOrder.TabIndex = 27;
            this.btnReturnOrder.Text = "Return Order";
            this.btnReturnOrder.UseVisualStyleBackColor = true;
            this.btnReturnOrder.Click += new System.EventHandler(this.btnReturnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order ID";
            // 
            // txtPrinterOrderID
            // 
            this.txtPrinterOrderID.Location = new System.Drawing.Point(174, 83);
            this.txtPrinterOrderID.Name = "txtPrinterOrderID";
            this.txtPrinterOrderID.Size = new System.Drawing.Size(140, 20);
            this.txtPrinterOrderID.TabIndex = 25;
            this.txtPrinterOrderID.TextChanged += new System.EventHandler(this.txtPrinterOrderID_TextChanged);
            // 
            // dgvPrinterOrder
            // 
            this.dgvPrinterOrder.AllowUserToAddRows = false;
            this.dgvPrinterOrder.AllowUserToDeleteRows = false;
            this.dgvPrinterOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinterOrder.Location = new System.Drawing.Point(320, 12);
            this.dgvPrinterOrder.Name = "dgvPrinterOrder";
            this.dgvPrinterOrder.ReadOnly = true;
            this.dgvPrinterOrder.Size = new System.Drawing.Size(394, 293);
            this.dgvPrinterOrder.TabIndex = 24;
            this.dgvPrinterOrder.SelectionChanged += new System.EventHandler(this.dgvPrinterOrder_SelectionChanged);
            // 
            // Log_Order_Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 339);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrinterOrderID);
            this.Controls.Add(this.dgvPrinterOrder);
            this.Name = "Log_Order_Refund";
            this.Text = "Log_Order_Refund";
            this.Load += new System.EventHandler(this.Log_Order_Refund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrinterOrderID;
        private System.Windows.Forms.DataGridView dgvPrinterOrder;
    }
}