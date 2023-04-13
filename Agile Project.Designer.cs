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
            this.Submit.Location = new System.Drawing.Point(153, 224);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(107, 53);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Info;
            this.Username.Location = new System.Drawing.Point(198, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(138, 26);
            this.Username.TabIndex = 1;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Info;
            this.Password.Location = new System.Drawing.Point(198, 165);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(138, 26);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userlbl.Location = new System.Drawing.Point(68, 119);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(124, 29);
            this.userlbl.TabIndex = 3;
            this.userlbl.Text = "Username";
            // 
            // passwdlbl
            // 
            this.passwdlbl.AutoSize = true;
            this.passwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwdlbl.Location = new System.Drawing.Point(72, 161);
            this.passwdlbl.Name = "passwdlbl";
            this.passwdlbl.Size = new System.Drawing.Size(120, 29);
            this.passwdlbl.TabIndex = 4;
            this.passwdlbl.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(96, 76);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(470, 601);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.passwdlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Submit);
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

