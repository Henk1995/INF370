namespace PETSystem
{
    partial class Search_Order
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
            this.btnLogRefund = new System.Windows.Forms.Button();
            this.btnLogPayment = new System.Windows.Forms.Button();
            this.btnReturnOder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.tnViewOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogRefund
            // 
            this.btnLogRefund.Location = new System.Drawing.Point(893, 496);
            this.btnLogRefund.Name = "btnLogRefund";
            this.btnLogRefund.Size = new System.Drawing.Size(121, 23);
            this.btnLogRefund.TabIndex = 14;
            this.btnLogRefund.Text = "Log Refund";
            this.btnLogRefund.UseVisualStyleBackColor = true;
            this.btnLogRefund.Click += new System.EventHandler(this.btnLogRefund_Click);
            // 
            // btnLogPayment
            // 
            this.btnLogPayment.Location = new System.Drawing.Point(766, 496);
            this.btnLogPayment.Name = "btnLogPayment";
            this.btnLogPayment.Size = new System.Drawing.Size(121, 23);
            this.btnLogPayment.TabIndex = 13;
            this.btnLogPayment.Text = "Log Payment";
            this.btnLogPayment.UseVisualStyleBackColor = true;
            this.btnLogPayment.Click += new System.EventHandler(this.btnLogPayment_Click);
            // 
            // btnReturnOder
            // 
            this.btnReturnOder.Location = new System.Drawing.Point(639, 496);
            this.btnReturnOder.Name = "btnReturnOder";
            this.btnReturnOder.Size = new System.Drawing.Size(121, 23);
            this.btnReturnOder.TabIndex = 12;
            this.btnReturnOder.Text = "Return Order";
            this.btnReturnOder.UseVisualStyleBackColor = true;
            this.btnReturnOder.Click += new System.EventHandler(this.btnReturnOder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(512, 496);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // tnViewOrder
            // 
            this.tnViewOrder.Location = new System.Drawing.Point(385, 496);
            this.tnViewOrder.Name = "tnViewOrder";
            this.tnViewOrder.Size = new System.Drawing.Size(121, 23);
            this.tnViewOrder.TabIndex = 10;
            this.tnViewOrder.Text = "View Order";
            this.tnViewOrder.UseVisualStyleBackColor = true;
            this.tnViewOrder.Click += new System.EventHandler(this.tnViewOrder_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(258, 496);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(121, 23);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(258, 12);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(844, 478);
            this.dgvOrders.TabIndex = 8;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(4, 467);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(248, 23);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(131, 496);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateInvoice.TabIndex = 17;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Location = new System.Drawing.Point(4, 496);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateReceipt.TabIndex = 18;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Order Number:";
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.Location = new System.Drawing.Point(4, 91);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(248, 20);
            this.txtSearchOrderID.TabIndex = 20;
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Location = new System.Drawing.Point(4, 117);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(248, 23);
            this.btnRefreshDGV.TabIndex = 21;
            this.btnRefreshDGV.Text = "Refresh DGV";
            this.btnRefreshDGV.UseVisualStyleBackColor = true;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // Search_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 527);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.txtSearchOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReceipt);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogRefund);
            this.Controls.Add(this.btnLogPayment);
            this.Controls.Add(this.btnReturnOder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tnViewOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Search_Order";
            this.Text = "Search_Order";
            this.Load += new System.EventHandler(this.Search_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogRefund;
        private System.Windows.Forms.Button btnLogPayment;
        private System.Windows.Forms.Button btnReturnOder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button tnViewOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.Button btnRefreshDGV;
    }
}