namespace InventoryTracker
{
    partial class PurchaseOrder
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
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.producttxtbox = new System.Windows.Forms.TextBox();
            this.quantitytxtbox = new System.Windows.Forms.TextBox();
            this.pricetxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostlbl = new System.Windows.Forms.Label();
            this.totalCosttxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(593, 763);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(165, 44);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ship To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(573, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 26);
            this.textBox4.TabIndex = 8;
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AllowUserToResizeColumns = false;
            this.orderGrid.AllowUserToResizeRows = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumber,
            this.quantity,
            this.unitPrice,
            this.total});
            this.orderGrid.Location = new System.Drawing.Point(55, 200);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersWidth = 62;
            this.orderGrid.RowTemplate.Height = 28;
            this.orderGrid.Size = new System.Drawing.Size(661, 327);
            this.orderGrid.TabIndex = 9;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(405, 763);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(165, 44);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // producttxtbox
            // 
            this.producttxtbox.Location = new System.Drawing.Point(94, 644);
            this.producttxtbox.Name = "producttxtbox";
            this.producttxtbox.Size = new System.Drawing.Size(100, 26);
            this.producttxtbox.TabIndex = 11;
            // 
            // quantitytxtbox
            // 
            this.quantitytxtbox.Location = new System.Drawing.Point(255, 644);
            this.quantitytxtbox.Name = "quantitytxtbox";
            this.quantitytxtbox.Size = new System.Drawing.Size(100, 26);
            this.quantitytxtbox.TabIndex = 12;
            // 
            // pricetxtbox
            // 
            this.pricetxtbox.Location = new System.Drawing.Point(405, 644);
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(100, 26);
            this.pricetxtbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price/item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(573, 644);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 26);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // itemNumber
            // 
            this.itemNumber.HeaderText = "ITEM ";
            this.itemNumber.MinimumWidth = 8;
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QTY";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "UNIT PRICE";
            this.unitPrice.MinimumWidth = 8;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.Width = 150;
            // 
            // TotalCostlbl
            // 
            this.TotalCostlbl.AutoSize = true;
            this.TotalCostlbl.Location = new System.Drawing.Point(506, 555);
            this.TotalCostlbl.Name = "TotalCostlbl";
            this.TotalCostlbl.Size = new System.Drawing.Size(81, 20);
            this.TotalCostlbl.TabIndex = 18;
            this.TotalCostlbl.Text = "Total Cost";
            // 
            // totalCosttxtbox
            // 
            this.totalCosttxtbox.Location = new System.Drawing.Point(593, 549);
            this.totalCosttxtbox.Name = "totalCosttxtbox";
            this.totalCosttxtbox.Size = new System.Drawing.Size(100, 26);
            this.totalCosttxtbox.TabIndex = 19;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 834);
            this.Controls.Add(this.totalCosttxtbox);
            this.Controls.Add(this.TotalCostlbl);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pricetxtbox);
            this.Controls.Add(this.quantitytxtbox);
            this.Controls.Add(this.producttxtbox);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsubmit);
            this.Name = "PurchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox producttxtbox;
        private System.Windows.Forms.TextBox quantitytxtbox;
        private System.Windows.Forms.TextBox pricetxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label TotalCostlbl;
        private System.Windows.Forms.TextBox totalCosttxtbox;
    }
}