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

                switch (privilege)
                {
                    case -1:
                        // User not found
                        // Show error?
                        break;
                    case 0:
                        // Most privileges
                        Home homeGo = new Home();
                        this.Hide();
                        homeGo.ShowDialog();
                        this.Close();
                        break;
                    case 1:
                        // Needs Different Home
                        break;
                    case 2:
                        // Needs Different Home
                        break;
                    case 3:
                        // Needs Different Home
                        // Least privileges
                        break;
                }

            }
            else
            {
                // Tell user to enter something in each box
            }
        }
    }
}
