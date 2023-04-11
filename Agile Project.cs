using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryTracker.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryTracker
{
    public partial class Login : Form
    {
        static GetUsers l = new GetUsers();
        List<User> user = l.user;
        public Login()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Only allow if something in user and password box
            if (!StringExtensions.IsNullOrWhiteSpace(Username.Text) && !StringExtensions.IsNullOrWhiteSpace(Password.Text))
            {
                string name = Username.Text;
                string pass = Password.Text;

                int privilege = CheckUser.FindUser(name, pass, user);

                if (privilege == -1)
                {
                    lblError.Text = "Invalid login information.";
                }
                else
                {
                    Home homeGo = new Home(privilege);
                    this.Hide();
                    homeGo.ShowDialog();
                    this.Close();
                }

            }
            else if (StringExtensions.IsNullOrWhiteSpace(Username.Text) && StringExtensions.IsNullOrWhiteSpace(Password.Text))
            {
                lblError.Text = "Please fill out the forms below.";
            }
            else if (StringExtensions.IsNullOrWhiteSpace(Username.Text))
            {
                lblError.Text = "Please enter a username.";
            }
            else if (StringExtensions.IsNullOrWhiteSpace(Password.Text))
            {
                lblError.Text = "Please enter a password";
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
