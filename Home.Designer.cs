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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btngenpo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInventory.Location = new System.Drawing.Point(458, 197);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(147, 85);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Modify Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLevel.Location = new System.Drawing.Point(348, 126);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(100, 37);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "label1";
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.SystemColors.Info;
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlert.Location = new System.Drawing.Point(203, 197);
            this.btnAlert.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(133, 85);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "Check Inventory";
            this.btnAlert.UseVisualStyleBackColor = false;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddUser.Location = new System.Drawing.Point(203, 310);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(133, 85);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btngenpo
            // 
            this.btngenpo.BackColor = System.Drawing.SystemColors.Info;
            this.btngenpo.Location = new System.Drawing.Point(458, 310);
            this.btngenpo.Name = "btngenpo";
            this.btngenpo.Size = new System.Drawing.Size(147, 85);
            this.btngenpo.TabIndex = 4;
            this.btngenpo.Text = "Generate Purchase Order";
            this.btngenpo.UseVisualStyleBackColor = false;
            this.btngenpo.Click += new System.EventHandler(this.btngenpo_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngenpo);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnInventory);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btngenpo;
    }
}