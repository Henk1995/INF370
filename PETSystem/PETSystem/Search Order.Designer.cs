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
            this.btnLogDamagedStock = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.tnViewOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogRefund
            // 
            this.btnLogRefund.Location = new System.Drawing.Point(981, 496);
            this.btnLogRefund.Name = "btnLogRefund";
            this.btnLogRefund.Size = new System.Drawing.Size(121, 23);
            this.btnLogRefund.TabIndex = 14;
            this.btnLogRefund.Text = "Log Refund";
            this.btnLogRefund.UseVisualStyleBackColor = true;
            // 
            // btnLogPayment
            // 
            this.btnLogPayment.Location = new System.Drawing.Point(854, 496);
            this.btnLogPayment.Name = "btnLogPayment";
            this.btnLogPayment.Size = new System.Drawing.Size(121, 23);
            this.btnLogPayment.TabIndex = 13;
            this.btnLogPayment.Text = "Log Payment";
            this.btnLogPayment.UseVisualStyleBackColor = true;
            // 
            // btnLogDamagedStock
            // 
            this.btnLogDamagedStock.Location = new System.Drawing.Point(727, 496);
            this.btnLogDamagedStock.Name = "btnLogDamagedStock";
            this.btnLogDamagedStock.Size = new System.Drawing.Size(121, 23);
            this.btnLogDamagedStock.TabIndex = 12;
            this.btnLogDamagedStock.Text = "Log Damaged Stock";
            this.btnLogDamagedStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(600, 496);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // tnViewOrder
            // 
            this.tnViewOrder.Location = new System.Drawing.Point(473, 496);
            this.tnViewOrder.Name = "tnViewOrder";
            this.tnViewOrder.Size = new System.Drawing.Size(121, 23);
            this.tnViewOrder.TabIndex = 10;
            this.tnViewOrder.Text = "View Order";
            this.tnViewOrder.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(346, 496);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Search_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogRefund);
            this.Controls.Add(this.btnLogPayment);
            this.Controls.Add(this.btnLogDamagedStock);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tnViewOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Search_Order";
            this.Text = "Search_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogRefund;
        private System.Windows.Forms.Button btnLogPayment;
        private System.Windows.Forms.Button btnLogDamagedStock;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button tnViewOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button button1;
    }
}