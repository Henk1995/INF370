﻿namespace Refund_Order
{
    partial class RefundOrderSupp
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
           
            this.supplier_ORderBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.supplierOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.supplier_ORderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 22);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Search Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refund Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Supplier Order ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierOrderIDDataGridViewTextBoxColumn,
            this.supplierOrderDateDataGridViewTextBoxColumn,
            this.supplierOrderDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplier_ORderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 293);
            this.dataGridView1.TabIndex = 12;
            // 
            // voorbeeldInstruDataSet
            // 
           
            // supplier_ORderBindingSource
            // 
      
            // 
            // supplier_ORderTableAdapter
            // 
           
            // supplierOrderIDDataGridViewTextBoxColumn
            // 
            this.supplierOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.HeaderText = "SupplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.Name = "supplierOrderIDDataGridViewTextBoxColumn";
            // 
            // supplierOrderDateDataGridViewTextBoxColumn
            // 
            this.supplierOrderDateDataGridViewTextBoxColumn.DataPropertyName = "SupplierOrderDate";
            this.supplierOrderDateDataGridViewTextBoxColumn.HeaderText = "SupplierOrderDate";
            this.supplierOrderDateDataGridViewTextBoxColumn.Name = "supplierOrderDateDataGridViewTextBoxColumn";
            // 
            // supplierOrderDescriptionDataGridViewTextBoxColumn
            // 
            this.supplierOrderDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SupplierOrderDescription";
            this.supplierOrderDescriptionDataGridViewTextBoxColumn.HeaderText = "SupplierOrderDescription";
            this.supplierOrderDescriptionDataGridViewTextBoxColumn.Name = "supplierOrderDescriptionDataGridViewTextBoxColumn";
            this.supplierOrderDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Refund Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.supplier_ORderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
     
        private System.Windows.Forms.BindingSource supplier_ORderBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderDescriptionDataGridViewTextBoxColumn;
    }
}

