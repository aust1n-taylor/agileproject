namespace InventoryTracker
{
    partial class Inventory
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblModifyResult = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(116, 28);
            this.txtItem.Margin = new System.Windows.Forms.Padding(1);
            this.txtItem.MaxLength = 25;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(99, 20);
            this.txtItem.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(116, 58);
            this.txtCount.Margin = new System.Windows.Forms.Padding(1);
            this.txtCount.MaxLength = 5;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(99, 20);
            this.txtCount.TabIndex = 1;
            this.txtCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(95, 94);
            this.btnModify.Margin = new System.Windows.Forms.Padding(1);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(48, 21);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(56, 30);
            this.lblItem.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(58, 13);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(58, 58);
            this.lblCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(58, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Item Count";
            // 
            // lblModifyResult
            // 
            this.lblModifyResult.AutoSize = true;
            this.lblModifyResult.Location = new System.Drawing.Point(58, 149);
            this.lblModifyResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblModifyResult.Name = "lblModifyResult";
            this.lblModifyResult.Size = new System.Drawing.Size(0, 13);
            this.lblModifyResult.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(147, 94);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(48, 21);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(95, 121);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 23);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Inventory";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 175);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(261, 101);
            this.txtDisplay.TabIndex = 9;
            this.txtDisplay.Visible = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 287);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblModifyResult);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.Text = "Modify Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblModifyResult;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}