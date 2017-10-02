namespace Return_Order
{
    partial class ReturnOrderSupp
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.txtSupplierOrderID = new System.Windows.Forms.TextBox();
            this.dgvSuppOrder = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 22);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Location = new System.Drawing.Point(190, 7);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(88, 13);
            this.lblSupplierDetails.TabIndex = 8;
            this.lblSupplierDetails.Text = "Supplier Order ID";
            // 
            // txtSupplierOrderID
            // 
            this.txtSupplierOrderID.Location = new System.Drawing.Point(19, 99);
            this.txtSupplierOrderID.Name = "txtSupplierOrderID";
            this.txtSupplierOrderID.Size = new System.Drawing.Size(121, 20);
            this.txtSupplierOrderID.TabIndex = 7;
            this.txtSupplierOrderID.TextChanged += new System.EventHandler(this.txtSupplierOrderID_TextChanged);
            // 
            // dgvSuppOrder
            // 
            this.dgvSuppOrder.AllowUserToAddRows = false;
            this.dgvSuppOrder.AllowUserToDeleteRows = false;
            this.dgvSuppOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppOrder.Location = new System.Drawing.Point(193, 38);
            this.dgvSuppOrder.Name = "dgvSuppOrder";
            this.dgvSuppOrder.ReadOnly = true;
            this.dgvSuppOrder.Size = new System.Drawing.Size(394, 237);
            this.dgvSuppOrder.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reference Number",
            "Date",
            "Order Description"});
            this.comboBox1.Location = new System.Drawing.Point(19, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by field:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search Criteria:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(533, 1);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(73, 19);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "Logout In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Logout In:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReturnOrderSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 278);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSupplierDetails);
            this.Controls.Add(this.txtSupplierOrderID);
            this.Controls.Add(this.dgvSuppOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReturnOrderSupp";
            this.Text = "Return Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnOrderSupp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.TextBox txtSupplierOrderID;
        private System.Windows.Forms.DataGridView dgvSuppOrder;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

