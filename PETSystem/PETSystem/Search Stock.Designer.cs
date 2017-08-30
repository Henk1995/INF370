namespace PETSystem
{
    partial class Search_Stock
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
            this.btnWriteoffStock = new System.Windows.Forms.Button();
            this.btnSearchStockID = new System.Windows.Forms.Button();
            this.txtSearchStockID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearcStockDesc = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.txtSearchStockDesc = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchStock = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWriteoffStock
            // 
            this.btnWriteoffStock.Location = new System.Drawing.Point(350, 464);
            this.btnWriteoffStock.Name = "btnWriteoffStock";
            this.btnWriteoffStock.Size = new System.Drawing.Size(135, 23);
            this.btnWriteoffStock.TabIndex = 34;
            this.btnWriteoffStock.Text = "Writeoff Stock";
            this.btnWriteoffStock.UseVisualStyleBackColor = true;
            this.btnWriteoffStock.Click += new System.EventHandler(this.btnWriteoffStock_Click);
            // 
            // btnSearchStockID
            // 
            this.btnSearchStockID.Location = new System.Drawing.Point(15, 190);
            this.btnSearchStockID.Name = "btnSearchStockID";
            this.btnSearchStockID.Size = new System.Drawing.Size(326, 23);
            this.btnSearchStockID.TabIndex = 33;
            this.btnSearchStockID.Text = "Search Stock ID";
            this.btnSearchStockID.UseVisualStyleBackColor = true;
            this.btnSearchStockID.Click += new System.EventHandler(this.btnSearchStockID_Click);
            // 
            // txtSearchStockID
            // 
            this.txtSearchStockID.Location = new System.Drawing.Point(15, 163);
            this.txtSearchStockID.Name = "txtSearchStockID";
            this.txtSearchStockID.Size = new System.Drawing.Size(326, 20);
            this.txtSearchStockID.TabIndex = 32;
            this.txtSearchStockID.TextChanged += new System.EventHandler(this.txtSearchStockID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Stock ID:";
            // 
            // btnSearcStockDesc
            // 
            this.btnSearcStockDesc.Location = new System.Drawing.Point(15, 107);
            this.btnSearcStockDesc.Name = "btnSearcStockDesc";
            this.btnSearcStockDesc.Size = new System.Drawing.Size(326, 23);
            this.btnSearcStockDesc.TabIndex = 30;
            this.btnSearcStockDesc.Text = "Search Stock Description";
            this.btnSearcStockDesc.UseVisualStyleBackColor = true;
            this.btnSearcStockDesc.Click += new System.EventHandler(this.btnSearcStockDesc_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(491, 464);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(135, 23);
            this.btnAddStock.TabIndex = 29;
            this.btnAddStock.Text = "Add Stock Quantity";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(773, 464);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(135, 23);
            this.btnViewStock.TabIndex = 28;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // txtSearchStockDesc
            // 
            this.txtSearchStockDesc.Location = new System.Drawing.Point(15, 81);
            this.txtSearchStockDesc.Name = "txtSearchStockDesc";
            this.txtSearchStockDesc.Size = new System.Drawing.Size(326, 20);
            this.txtSearchStockDesc.TabIndex = 25;
            this.txtSearchStockDesc.TextChanged += new System.EventHandler(this.txtSearchStockDesc_TextChanged);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(915, 464);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateStock.TabIndex = 27;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Location = new System.Drawing.Point(633, 464);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteStock.TabIndex = 26;
            this.btnDeleteStock.Text = "Delete stock";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Stock Description:";
            // 
            // dgvSearchStock
            // 
            this.dgvSearchStock.AllowUserToAddRows = false;
            this.dgvSearchStock.AllowUserToDeleteRows = false;
            this.dgvSearchStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchStock.Location = new System.Drawing.Point(350, 9);
            this.dgvSearchStock.Name = "dgvSearchStock";
            this.dgvSearchStock.ReadOnly = true;
            this.dgvSearchStock.Size = new System.Drawing.Size(700, 449);
            this.dgvSearchStock.TabIndex = 23;
            this.dgvSearchStock.SelectionChanged += new System.EventHandler(this.dgvSearchStock_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add new Stock Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(97, 464);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(105, 23);
            this.btnMainMenu.TabIndex = 36;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // Search_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 497);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWriteoffStock);
            this.Controls.Add(this.btnSearchStockID);
            this.Controls.Add(this.txtSearchStockID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearcStockDesc);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnViewStock);
            this.Controls.Add(this.txtSearchStockDesc);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchStock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search_Stock";
            this.Text = "Search Stock";
            this.Load += new System.EventHandler(this.Search_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteoffStock;
        private System.Windows.Forms.Button btnSearchStockID;
        private System.Windows.Forms.TextBox txtSearchStockID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearcStockDesc;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.TextBox txtSearchStockDesc;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMainMenu;
    }
}