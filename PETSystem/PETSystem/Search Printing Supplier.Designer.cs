﻿namespace PETSystem
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
            this.txtSearchPrintSupplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewPrintSupplier = new System.Windows.Forms.Button();
            this.txtSearchPrintSupplierName = new System.Windows.Forms.TextBox();
            this.btnUpdatePrintSupplier = new System.Windows.Forms.Button();
            this.btnDeletePrintSupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchPrintingSupplier = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnRefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPrintingSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPrintSupplier
            // 
            this.btnAddPrintSupplier.Location = new System.Drawing.Point(348, 467);
            this.btnAddPrintSupplier.Name = "btnAddPrintSupplier";
            this.btnAddPrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnAddPrintSupplier.TabIndex = 47;
            this.btnAddPrintSupplier.Text = "Add Print Supplier";
            this.btnAddPrintSupplier.UseVisualStyleBackColor = true;
            this.btnAddPrintSupplier.Click += new System.EventHandler(this.btnAddPrintSupplier_Click);
            // 
            // txtSearchPrintSupplierID
            // 
            this.txtSearchPrintSupplierID.Location = new System.Drawing.Point(13, 166);
            this.txtSearchPrintSupplierID.Name = "txtSearchPrintSupplierID";
            this.txtSearchPrintSupplierID.Size = new System.Drawing.Size(326, 20);
            this.txtSearchPrintSupplierID.TabIndex = 45;
            this.txtSearchPrintSupplierID.TextChanged += new System.EventHandler(this.txtSearchPrintSupplierID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Printing Supplier ID:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(913, 467);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(135, 23);
            this.btnPlaceOrder.TabIndex = 42;
            this.btnPlaceOrder.Text = "Place Printing Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnViewPrintSupplier
            // 
            this.btnViewPrintSupplier.Location = new System.Drawing.Point(771, 467);
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
            this.btnUpdatePrintSupplier.Location = new System.Drawing.Point(490, 467);
            this.btnUpdatePrintSupplier.Name = "btnUpdatePrintSupplier";
            this.btnUpdatePrintSupplier.Size = new System.Drawing.Size(135, 23);
            this.btnUpdatePrintSupplier.TabIndex = 40;
            this.btnUpdatePrintSupplier.Text = "Update Print Supplier";
            this.btnUpdatePrintSupplier.UseVisualStyleBackColor = true;
            this.btnUpdatePrintSupplier.Click += new System.EventHandler(this.btnUpdatePrintSupplier_Click);
            // 
            // btnDeletePrintSupplier
            // 
            this.btnDeletePrintSupplier.Location = new System.Drawing.Point(631, 467);
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
            this.dgvSearchPrintingSupplier.SelectionChanged += new System.EventHandler(this.dgvSearchPrintingSupplier_SelectionChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(18, 467);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 48;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnRefreshDGV
            // 
            this.btnRefreshDGV.Location = new System.Drawing.Point(13, 233);
            this.btnRefreshDGV.Name = "btnRefreshDGV";
            this.btnRefreshDGV.Size = new System.Drawing.Size(326, 23);
            this.btnRefreshDGV.TabIndex = 51;
            this.btnRefreshDGV.Text = "Refresh DGV";
            this.btnRefreshDGV.UseVisualStyleBackColor = true;
            this.btnRefreshDGV.Click += new System.EventHandler(this.btnRefreshDGV_Click);
            // 
            // Search_Printing_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 506);
            this.Controls.Add(this.btnRefreshDGV);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddPrintSupplier);
            this.Controls.Add(this.txtSearchPrintSupplierID);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox txtSearchPrintSupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewPrintSupplier;
        private System.Windows.Forms.TextBox txtSearchPrintSupplierName;
        private System.Windows.Forms.Button btnUpdatePrintSupplier;
        private System.Windows.Forms.Button btnDeletePrintSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchPrintingSupplier;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRefreshDGV;
    }
}