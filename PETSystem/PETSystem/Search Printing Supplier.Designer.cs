namespace PETSystem
{
    partial class Search_Printing_Supplier
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
            this.btnAddPrintSupplier = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewPrintSupplier = new System.Windows.Forms.Button();
            this.txtSearchPrintSupplierName = new System.Windows.Forms.TextBox();
            this.btnUpdatePrintSupplier = new System.Windows.Forms.Button();
            this.btnDeletePrintSupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchPrintingSupplier = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPrintingSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPrintSupplier
            // 
            this.btnAddPrintSupplier.Location = new System.Drawing.Point(31, 471);
            this.btnAddPrintSupplier.Name = "btnAddPrintSupplier";
            this.btnAddPrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnAddPrintSupplier.TabIndex = 47;
            this.btnAddPrintSupplier.Text = "Add Print Supplier";
            this.btnAddPrintSupplier.UseVisualStyleBackColor = true;
            this.btnAddPrintSupplier.Click += new System.EventHandler(this.btnAddPrintSupplier_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(13, 204);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(325, 23);
            this.btnPlaceOrder.TabIndex = 42;
            this.btnPlaceOrder.Text = "Place Printing Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnViewPrintSupplier
            // 
            this.btnViewPrintSupplier.Location = new System.Drawing.Point(172, 471);
            this.btnViewPrintSupplier.Name = "btnViewPrintSupplier";
            this.btnViewPrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnViewPrintSupplier.TabIndex = 41;
            this.btnViewPrintSupplier.Text = "View Print Supplier";
            this.btnViewPrintSupplier.UseVisualStyleBackColor = true;
            this.btnViewPrintSupplier.Click += new System.EventHandler(this.btnViewPrintSupplier_Click);
            // 
            // txtSearchPrintSupplierName
            // 
            this.txtSearchPrintSupplierName.Location = new System.Drawing.Point(13, 84);
            this.txtSearchPrintSupplierName.Name = "txtSearchPrintSupplierName";
            this.txtSearchPrintSupplierName.Size = new System.Drawing.Size(326, 20);
            this.txtSearchPrintSupplierName.TabIndex = 38;
            this.txtSearchPrintSupplierName.TextChanged += new System.EventHandler(this.txtSearchPrintSupplierName_TextChanged);
            // 
            // btnUpdatePrintSupplier
            // 
            this.btnUpdatePrintSupplier.Location = new System.Drawing.Point(313, 471);
            this.btnUpdatePrintSupplier.Name = "btnUpdatePrintSupplier";
            this.btnUpdatePrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnUpdatePrintSupplier.TabIndex = 40;
            this.btnUpdatePrintSupplier.Text = "Update Print Supplier";
            this.btnUpdatePrintSupplier.UseVisualStyleBackColor = true;
            this.btnUpdatePrintSupplier.Click += new System.EventHandler(this.btnUpdatePrintSupplier_Click);
            // 
            // btnDeletePrintSupplier
            // 
            this.btnDeletePrintSupplier.Location = new System.Drawing.Point(454, 471);
            this.btnDeletePrintSupplier.Name = "btnDeletePrintSupplier";
            this.btnDeletePrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnDeletePrintSupplier.TabIndex = 39;
            this.btnDeletePrintSupplier.Text = "Delete Print Supplier";
            this.btnDeletePrintSupplier.UseVisualStyleBackColor = true;
            this.btnDeletePrintSupplier.Click += new System.EventHandler(this.btnDeletePrintSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Printing supplier name:";
            // 
            // dgvSearchPrintingSupplier
            // 
            this.dgvSearchPrintingSupplier.AllowUserToAddRows = false;
            this.dgvSearchPrintingSupplier.AllowUserToDeleteRows = false;
            this.dgvSearchPrintingSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPrintingSupplier.Location = new System.Drawing.Point(348, 12);
            this.dgvSearchPrintingSupplier.Name = "dgvSearchPrintingSupplier";
            this.dgvSearchPrintingSupplier.ReadOnly = true;
            this.dgvSearchPrintingSupplier.Size = new System.Drawing.Size(700, 449);
            this.dgvSearchPrintingSupplier.TabIndex = 36;
            this.dgvSearchPrintingSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchPrintingSupplier_CellContentClick);
            this.dgvSearchPrintingSupplier.SelectionChanged += new System.EventHandler(this.dgvSearchPrintingSupplier_SelectionChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(12, 139);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(326, 23);
            this.btnMainMenu.TabIndex = 48;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Location = new System.Drawing.Point(12, 110);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(326, 23);
            this.btnRefreshDGV.TabIndex = 51;
            this.btnRefreshDGV.Text = "Refresh DGV";
            this.btnRefreshDGV.UseVisualStyleBackColor = true;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Location = new System.Drawing.Point(595, 471);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(135, 23);
            this.btnReceiveOrder.TabIndex = 52;
            this.btnReceiveOrder.Text = "Receive Order";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Return Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Refund Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Search_Printing_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddPrintSupplier);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnViewPrintSupplier);
            this.Controls.Add(this.txtSearchPrintSupplierName);
            this.Controls.Add(this.btnUpdatePrintSupplier);
            this.Controls.Add(this.btnDeletePrintSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchPrintingSupplier);
            this.Name = "Search_Printing_Supplier";
            this.Text = "Search_Printing_Supplier";
            this.Load += new System.EventHandler(this.Search_Printing_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPrintingSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPrintSupplier;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewPrintSupplier;
        private System.Windows.Forms.TextBox txtSearchPrintSupplierName;
        private System.Windows.Forms.Button btnUpdatePrintSupplier;
        private System.Windows.Forms.Button btnDeletePrintSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchPrintingSupplier;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRefreshDGV;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}