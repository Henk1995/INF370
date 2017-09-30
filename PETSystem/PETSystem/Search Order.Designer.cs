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
            this.components = new System.ComponentModel.Container();
            this.btnLogRefund = new System.Windows.Forms.Button();
            this.btnLogPayment = new System.Windows.Forms.Button();
            this.btnReturnOder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.tnViewOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // 
            // btnLogPayment
            // 
            this.btnLogPayment.Location = new System.Drawing.Point(766, 496);
            this.btnLogPayment.Name = "btnLogPayment";
            this.btnLogPayment.Size = new System.Drawing.Size(121, 23);
            this.btnLogPayment.TabIndex = 13;
            this.btnLogPayment.Text = "Log Payment";
            this.btnLogPayment.UseVisualStyleBackColor = true;
            // 
            // btnReturnOder
            // 
            this.btnReturnOder.Location = new System.Drawing.Point(639, 496);
            this.btnReturnOder.Name = "btnReturnOder";
            this.btnReturnOder.Size = new System.Drawing.Size(121, 23);
            this.btnReturnOder.TabIndex = 12;
            this.btnReturnOder.Text = "Return Order";
            this.btnReturnOder.UseVisualStyleBackColor = true;
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
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(258, 26);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(844, 464);
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
            this.txtSearchOrderID.TextChanged += new System.EventHandler(this.txtSearchOrderID_TextChanged);
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
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(1054, 4);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 19);
            this.lblTimer.TabIndex = 22;
            this.lblTimer.Text = "Logout In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1004, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Search_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.txtSearchOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogRefund);
            this.Controls.Add(this.btnLogPayment);
            this.Controls.Add(this.btnReturnOder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tnViewOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Search_Order";
            this.Text = "Search_Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Order_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.Button btnRefreshDGV;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}