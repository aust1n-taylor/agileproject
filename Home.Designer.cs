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
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(32, 71);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(201, 82);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Modify Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(26, 21);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(92, 32);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "label1";
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(32, 191);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(201, 85);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "Check Inventory";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 698);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnInventory);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnAlert;
    }
}