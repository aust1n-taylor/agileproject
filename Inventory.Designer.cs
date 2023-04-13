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
            this.medbuttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(174, 43);
            this.txtItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtItem.MaxLength = 25;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(146, 26);
            this.txtItem.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(174, 89);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCount.MaxLength = 5;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(146, 26);
            this.txtCount.TabIndex = 1;
            this.txtCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Info;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModify.Location = new System.Drawing.Point(11, 155);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 57);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblItem.Location = new System.Drawing.Point(40, 43);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(130, 29);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount.Location = new System.Drawing.Point(42, 86);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(128, 29);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Item Count";
            // 
            // lblModifyResult
            // 
            this.lblModifyResult.AutoSize = true;
            this.lblModifyResult.Location = new System.Drawing.Point(87, 229);
            this.lblModifyResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModifyResult.Name = "lblModifyResult";
            this.lblModifyResult.Size = new System.Drawing.Size(0, 20);
            this.lblModifyResult.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Info;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReturn.Location = new System.Drawing.Point(288, 155);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 57);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDisplay.Location = new System.Drawing.Point(93, 214);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(230, 35);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Inventory";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.Location = new System.Drawing.Point(18, 269);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(390, 249);
            this.txtDisplay.TabIndex = 9;
            this.txtDisplay.Visible = false;
            // 
            // medbuttn
            // 
            this.medbuttn.BackColor = System.Drawing.SystemColors.Info;
            this.medbuttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.medbuttn.Location = new System.Drawing.Point(91, 118);
            this.medbuttn.Name = "medbuttn";
            this.medbuttn.Size = new System.Drawing.Size(232, 32);
            this.medbuttn.TabIndex = 12;
            this.medbuttn.Text = "Display Medication";
            this.medbuttn.UseVisualStyleBackColor = false;
            this.medbuttn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(428, 532);
            this.Controls.Add(this.medbuttn);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblModifyResult);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtItem);
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
        private System.Windows.Forms.Button medbuttn;
    }
}