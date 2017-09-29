namespace PETSystem
{
    partial class PrinterOrderReturn
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
            this.txtSupplierOrderID = new System.Windows.Forms.TextBox();
            this.dgvSuppOrder = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 22);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Location = new System.Drawing.Point(37, 134);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(246, 31);
            this.btnReturnOrder.TabIndex = 15;
            this.btnReturnOrder.Text = "Return Order";
            this.btnReturnOrder.UseVisualStyleBackColor = true;
            this.btnReturnOrder.Click += new System.EventHandler(this.btnReturnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Printer Order ID";
            // 
            // txtSupplierOrderID
            // 
            this.txtSupplierOrderID.Location = new System.Drawing.Point(51, 98);
            this.txtSupplierOrderID.Name = "txtSupplierOrderID";
            this.txtSupplierOrderID.Size = new System.Drawing.Size(140, 20);
            this.txtSupplierOrderID.TabIndex = 13;
            this.txtSupplierOrderID.TextChanged += new System.EventHandler(this.txtPrinterOrderID_TextChanged);
            // 
            // dgvSuppOrder
            // 
            this.dgvSuppOrder.AllowUserToAddRows = false;
            this.dgvSuppOrder.AllowUserToDeleteRows = false;
            this.dgvSuppOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppOrder.Location = new System.Drawing.Point(315, 44);
            this.dgvSuppOrder.Name = "dgvSuppOrder";
            this.dgvSuppOrder.ReadOnly = true;
            this.dgvSuppOrder.Size = new System.Drawing.Size(394, 293);
            this.dgvSuppOrder.TabIndex = 12;
            this.dgvSuppOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinterOrder_CellContentClick);
            this.dgvSuppOrder.SelectionChanged += new System.EventHandler(this.dgvPrinterOrder_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search by field:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reference Number",
            "Date",
            "Order Description"});
            this.comboBox1.Location = new System.Drawing.Point(51, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Location = new System.Drawing.Point(312, 18);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(88, 13);
            this.lblSupplierDetails.TabIndex = 20;
            this.lblSupplierDetails.Text = "Supplier Order ID";
            // 
            // PrinterOrderReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 358);
            this.Controls.Add(this.lblSupplierDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplierOrderID);
            this.Controls.Add(this.dgvSuppOrder);
            this.Name = "PrinterOrderReturn";
            this.Text = "PrinterOrderReturn";
            this.Load += new System.EventHandler(this.PrinterOrderReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierOrderID;
        private System.Windows.Forms.DataGridView dgvSuppOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSupplierDetails;
    }
}