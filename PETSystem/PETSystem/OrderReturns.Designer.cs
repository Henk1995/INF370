namespace PETSystem
{
    partial class OrderReturns
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
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrinterOrderID = new System.Windows.Forms.TextBox();
            this.dgvPrinterOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 22);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(69, 143);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(120, 31);
            this.btnSearchOrder.TabIndex = 22;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Location = new System.Drawing.Point(195, 143);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(120, 31);
            this.btnReturnOrder.TabIndex = 21;
            this.btnReturnOrder.Text = "Return Order";
            this.btnReturnOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID";
            // 
            // txtPrinterOrderID
            // 
            this.txtPrinterOrderID.Location = new System.Drawing.Point(175, 83);
            this.txtPrinterOrderID.Name = "txtPrinterOrderID";
            this.txtPrinterOrderID.Size = new System.Drawing.Size(140, 20);
            this.txtPrinterOrderID.TabIndex = 19;
            // 
            // dgvPrinterOrder
            // 
            this.dgvPrinterOrder.AllowUserToAddRows = false;
            this.dgvPrinterOrder.AllowUserToDeleteRows = false;
            this.dgvPrinterOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinterOrder.Location = new System.Drawing.Point(321, 12);
            this.dgvPrinterOrder.Name = "dgvPrinterOrder";
            this.dgvPrinterOrder.ReadOnly = true;
            this.dgvPrinterOrder.Size = new System.Drawing.Size(394, 293);
            this.dgvPrinterOrder.TabIndex = 18;
            // 
            // OrderReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 339);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.btnReturnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrinterOrderID);
            this.Controls.Add(this.dgvPrinterOrder);
            this.Name = "OrderReturns";
            this.Text = "OrderReturns";
            this.Load += new System.EventHandler(this.OrderReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrinterOrderID;
        private System.Windows.Forms.DataGridView dgvPrinterOrder;
    }
}