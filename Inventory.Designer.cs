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
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(308, 66);
            this.txtItem.MaxLength = 25;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(257, 38);
            this.txtItem.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(308, 139);
            this.txtCount.MaxLength = 5;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(257, 38);
            this.txtCount.TabIndex = 1;
            this.txtCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(308, 225);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(128, 50);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(148, 71);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(150, 32);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(154, 139);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(151, 32);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Item Count";
            // 
            // lblModifyResult
            // 
            this.lblModifyResult.AutoSize = true;
            this.lblModifyResult.Location = new System.Drawing.Point(40, 313);
            this.lblModifyResult.Name = "lblModifyResult";
            this.lblModifyResult.Size = new System.Drawing.Size(0, 32);
            this.lblModifyResult.TabIndex = 5;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 698);
            this.Controls.Add(this.lblModifyResult);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtItem);
            this.Margin = new System.Windows.Forms.Padding(5);
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
    }
}