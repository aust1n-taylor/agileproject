namespace InventoryTracker
{
    partial class Home
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
            this.Inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(14, 14);
            this.Inventory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(201, 82);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Modify Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 698);
            this.Controls.Add(this.Inventory);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inventory;
    }
}