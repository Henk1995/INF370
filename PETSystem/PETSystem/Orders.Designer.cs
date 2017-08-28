namespace PETSystem
{
    partial class Orders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.tnViewOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnLogDamagedStock = new System.Windows.Forms.Button();
            this.btnLogPayment = new System.Windows.Forms.Button();
            this.btnLogRefund = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(233, 30);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(844, 478);
            this.dgvOrders.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(48, 150);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(121, 23);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // tnViewOrder
            // 
            this.tnViewOrder.Location = new System.Drawing.Point(48, 179);
            this.tnViewOrder.Name = "tnViewOrder";
            this.tnViewOrder.Size = new System.Drawing.Size(121, 23);
            this.tnViewOrder.TabIndex = 2;
            this.tnViewOrder.Text = "View Order";
            this.tnViewOrder.UseVisualStyleBackColor = true;
            this.tnViewOrder.Click += new System.EventHandler(this.tnViewOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(48, 208);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateOrder.TabIndex = 3;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnLogDamagedStock
            // 
            this.btnLogDamagedStock.Location = new System.Drawing.Point(48, 237);
            this.btnLogDamagedStock.Name = "btnLogDamagedStock";
            this.btnLogDamagedStock.Size = new System.Drawing.Size(121, 23);
            this.btnLogDamagedStock.TabIndex = 4;
            this.btnLogDamagedStock.Text = "Log Damaged Stock";
            this.btnLogDamagedStock.UseVisualStyleBackColor = true;
            this.btnLogDamagedStock.Click += new System.EventHandler(this.btnLogDamagedStock_Click);
            // 
            // btnLogPayment
            // 
            this.btnLogPayment.Location = new System.Drawing.Point(48, 266);
            this.btnLogPayment.Name = "btnLogPayment";
            this.btnLogPayment.Size = new System.Drawing.Size(121, 23);
            this.btnLogPayment.TabIndex = 5;
            this.btnLogPayment.Text = "Log Payment";
            this.btnLogPayment.UseVisualStyleBackColor = true;
            this.btnLogPayment.Click += new System.EventHandler(this.btnLogPayment_Click);
            // 
            // btnLogRefund
            // 
            this.btnLogRefund.Location = new System.Drawing.Point(48, 295);
            this.btnLogRefund.Name = "btnLogRefund";
            this.btnLogRefund.Size = new System.Drawing.Size(121, 23);
            this.btnLogRefund.TabIndex = 6;
            this.btnLogRefund.Text = "Log Refund";
            this.btnLogRefund.UseVisualStyleBackColor = true;
            this.btnLogRefund.Click += new System.EventHandler(this.btnLogRefund_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 520);
            this.Controls.Add(this.btnLogRefund);
            this.Controls.Add(this.btnLogPayment);
            this.Controls.Add(this.btnLogDamagedStock);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tnViewOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Orders";
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button tnViewOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnLogDamagedStock;
        private System.Windows.Forms.Button btnLogPayment;
        private System.Windows.Forms.Button btnLogRefund;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}