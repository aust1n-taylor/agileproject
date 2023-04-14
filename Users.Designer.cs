namespace InventoryTracker
{
    partial class Users
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.passwdlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(298, 667);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 57);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDisplay.Location = new System.Drawing.Point(25, 302);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(848, 347);
            this.txtDisplay.TabIndex = 14;
            // 
            // passwdlbl
            // 
            this.passwdlbl.AutoSize = true;
            this.passwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwdlbl.Location = new System.Drawing.Point(74, 102);
            this.passwdlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwdlbl.Name = "passwdlbl";
            this.passwdlbl.Size = new System.Drawing.Size(196, 46);
            this.passwdlbl.TabIndex = 20;
            this.passwdlbl.Text = "Password";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userlbl.Location = new System.Drawing.Point(67, 36);
            this.userlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(203, 46);
            this.userlbl.TabIndex = 18;
            this.userlbl.Text = "Username";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Info;
            this.Password.Location = new System.Drawing.Point(298, 108);
            this.Password.Margin = new System.Windows.Forms.Padding(5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(242, 38);
            this.Password.TabIndex = 17;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Info;
            this.Username.Location = new System.Drawing.Point(298, 43);
            this.Username.Margin = new System.Windows.Forms.Padding(5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(242, 38);
            this.Username.TabIndex = 16;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Info;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Submit.Location = new System.Drawing.Point(649, 82);
            this.Submit.Margin = new System.Windows.Forms.Padding(5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(190, 82);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Add";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(74, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Level";
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.SystemColors.Info;
            this.txtLevel.Location = new System.Drawing.Point(298, 171);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(5);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(242, 38);
            this.txtLevel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(74, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.Info;
            this.txtRole.Location = new System.Drawing.Point(298, 231);
            this.txtRole.Margin = new System.Windows.Forms.Padding(5);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(242, 38);
            this.txtRole.TabIndex = 23;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(439, 667);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(135, 57);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(902, 736);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.passwdlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Users";
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label passwdlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnShow;
    }
}