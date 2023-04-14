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
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInventory.Location = new System.Drawing.Point(814, 305);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(261, 132);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Modify Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLevel.Location = new System.Drawing.Point(619, 195);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(173, 63);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "label1";
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.SystemColors.Info;
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlert.Location = new System.Drawing.Point(361, 305);
            this.btnAlert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(236, 132);
            this.btnAlert.TabIndex = 1;
            this.btnAlert.Text = "Check Inventory";
            this.btnAlert.UseVisualStyleBackColor = false;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1422, 698);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnInventory);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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