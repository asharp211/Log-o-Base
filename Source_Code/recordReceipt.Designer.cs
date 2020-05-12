namespace Log_o_Base
{
    partial class recordReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logBaseDataSet = new Log_o_Base.LogBaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.receiptTableAdapter = new Log_o_Base.LogBaseDataSetTableAdapters.ReceiptTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logBaseDataSet1 = new Log_o_Base.LogBaseDataSet1();
            this.receiptBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter1 = new Log_o_Base.LogBaseDataSet1TableAdapters.ReceiptTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBaseDataSet2 = new Log_o_Base.LogBaseDataSet2();
            this.receiptBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter2 = new Log_o_Base.LogBaseDataSet2TableAdapters.ReceiptTableAdapter();
            this.logBaseDataSet6 = new Log_o_Base.LogBaseDataSet6();
            this.tbReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbReceiptTableAdapter = new Log_o_Base.LogBaseDataSet6TableAdapters.tbReceiptTableAdapter();
            this.logBaseDataSet7 = new Log_o_Base.LogBaseDataSet7();
            this.tbReceiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbReceiptTableAdapter1 = new Log_o_Base.LogBaseDataSet7TableAdapters.tbReceiptTableAdapter();
            this.transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodOfPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReceiptBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaction,
            this.date,
            this.itemNumber,
            this.itemName,
            this.prices,
            this.quantities,
            this.MethodOfPay,
            this.Totals});
            this.dataGridView.Location = new System.Drawing.Point(249, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(845, 387);
            this.dataGridView.TabIndex = 0;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.logBaseDataSet;
            // 
            // logBaseDataSet
            // 
            this.logBaseDataSet.DataSetName = "LogBaseDataSet";
            this.logBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(68, 124);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(175, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(68, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(68, 223);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(175, 20);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(68, 280);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(175, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(68, 316);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 47);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Search";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // receiptBindingSource1
            // 
            this.receiptBindingSource1.DataMember = "Receipt";
            this.receiptBindingSource1.DataSource = this.logBaseDataSet;
            // 
            // logBaseDataSet1
            // 
            this.logBaseDataSet1.DataSetName = "LogBaseDataSet1";
            this.logBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource2
            // 
            this.receiptBindingSource2.DataMember = "Receipt";
            this.receiptBindingSource2.DataSource = this.logBaseDataSet1;
            // 
            // receiptTableAdapter1
            // 
            this.receiptTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Date";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Transaction_Number
            // 
            this.Transaction_Number.DataPropertyName = "Transaction_Number";
            this.Transaction_Number.HeaderText = "Transaction_Number";
            this.Transaction_Number.Name = "Transaction_Number";
            // 
            // Item_Number
            // 
            this.Item_Number.DataPropertyName = "Item_Number";
            this.Item_Number.HeaderText = "Item_Number";
            this.Item_Number.Name = "Item_Number";
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // logBaseDataSet2
            // 
            this.logBaseDataSet2.DataSetName = "LogBaseDataSet2";
            this.logBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource3
            // 
            this.receiptBindingSource3.DataMember = "Receipt";
            this.receiptBindingSource3.DataSource = this.logBaseDataSet2;
            // 
            // receiptTableAdapter2
            // 
            this.receiptTableAdapter2.ClearBeforeFill = true;
            // 
            // logBaseDataSet6
            // 
            this.logBaseDataSet6.DataSetName = "LogBaseDataSet6";
            this.logBaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbReceiptBindingSource
            // 
            this.tbReceiptBindingSource.DataMember = "tbReceipt";
            this.tbReceiptBindingSource.DataSource = this.logBaseDataSet6;
            // 
            // tbReceiptTableAdapter
            // 
            this.tbReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // logBaseDataSet7
            // 
            this.logBaseDataSet7.DataSetName = "LogBaseDataSet7";
            this.logBaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbReceiptBindingSource1
            // 
            this.tbReceiptBindingSource1.DataMember = "tbReceipt";
            this.tbReceiptBindingSource1.DataSource = this.logBaseDataSet7;
            // 
            // tbReceiptTableAdapter1
            // 
            this.tbReceiptTableAdapter1.ClearBeforeFill = true;
            // 
            // transaction
            // 
            this.transaction.HeaderText = "Transaction";
            this.transaction.Name = "transaction";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // itemNumber
            // 
            this.itemNumber.HeaderText = "ItemNumber";
            this.itemNumber.Name = "itemNumber";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item_Name";
            this.itemName.Name = "itemName";
            // 
            // prices
            // 
            this.prices.HeaderText = "Price";
            this.prices.Name = "prices";
            // 
            // quantities
            // 
            this.quantities.HeaderText = "Quantity";
            this.quantities.Name = "quantities";
            // 
            // MethodOfPay
            // 
            this.MethodOfPay.HeaderText = "MethodOfPay";
            this.MethodOfPay.Name = "MethodOfPay";
            // 
            // Totals
            // 
            this.Totals.HeaderText = "Total";
            this.Totals.Name = "Totals";
            // 
            // recordReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "recordReceipt";
            this.Size = new System.Drawing.Size(1109, 545);
            this.Load += new System.EventHandler(this.recordReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReceiptBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private LogBaseDataSet logBaseDataSet;
        private LogBaseDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource receiptBindingSource1;
        private System.Windows.Forms.BindingSource receiptBindingSource3;
        private LogBaseDataSet2 logBaseDataSet2;
        private LogBaseDataSet1 logBaseDataSet1;
        private System.Windows.Forms.BindingSource receiptBindingSource2;
        private LogBaseDataSet1TableAdapters.ReceiptTableAdapter receiptTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private LogBaseDataSet2TableAdapters.ReceiptTableAdapter receiptTableAdapter2;
        private System.Windows.Forms.BindingSource tbReceiptBindingSource1;
        private LogBaseDataSet7 logBaseDataSet7;
        private LogBaseDataSet6 logBaseDataSet6;
        private System.Windows.Forms.BindingSource tbReceiptBindingSource;
        private LogBaseDataSet6TableAdapters.tbReceiptTableAdapter tbReceiptTableAdapter;
        private LogBaseDataSet7TableAdapters.tbReceiptTableAdapter tbReceiptTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodOfPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totals;
    }
}
