namespace InventoryTracker
{
    partial class Login
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
            this.Submit = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.passwdlbl = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Info;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Submit.Location = new System.Drawing.Point(272, 347);
            this.Submit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(190, 82);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Info;
            this.Username.Location = new System.Drawing.Point(352, 191);
            this.Username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(242, 38);
            this.Username.TabIndex = 1;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Info;
            this.Password.Location = new System.Drawing.Point(352, 256);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(242, 38);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userlbl.Location = new System.Drawing.Point(121, 184);
            this.userlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(203, 46);
            this.userlbl.TabIndex = 3;
            this.userlbl.Text = "Username";
            // 
            // passwdlbl
            // 
            this.passwdlbl.AutoSize = true;
            this.passwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwdlbl.Location = new System.Drawing.Point(128, 250);
            this.passwdlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwdlbl.Name = "passwdlbl";
            this.passwdlbl.Size = new System.Drawing.Size(196, 46);
            this.passwdlbl.TabIndex = 4;
            this.passwdlbl.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(171, 118);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 32);
            this.lblError.TabIndex = 5;
            // 
            // Login
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(836, 932);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.passwdlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Submit);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passwdlbl;
        private System.Windows.Forms.Label lblError;
    }
}

