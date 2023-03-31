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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnModify.Location = new System.Drawing.Point(67, 171);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 32);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(84, 46);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(87, 20);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(87, 89);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(88, 20);
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
            this.btnReturn.Location = new System.Drawing.Point(303, 173);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(145, 170);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(150, 35);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Inventory";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(18, 269);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(390, 153);
            this.txtDisplay.TabIndex = 9;
            this.txtDisplay.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // medbuttn
            // 
            this.medbuttn.Location = new System.Drawing.Point(105, 130);
            this.medbuttn.Name = "medbuttn";
            this.medbuttn.Size = new System.Drawing.Size(232, 32);
            this.medbuttn.TabIndex = 12;
            this.medbuttn.Text = "Display Medication";
            this.medbuttn.UseVisualStyleBackColor = true;
            this.medbuttn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 442);
            this.Controls.Add(this.medbuttn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button medbuttn;
    }
}