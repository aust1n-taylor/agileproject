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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryTracker
{
    public partial class Users : Form
    {
        static GetUsers l = new GetUsers();
        List<User> user = l.user;
        public Users()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!StringExtensions.IsNullOrWhiteSpace(Username.Text) && !StringExtensions.IsNullOrWhiteSpace(Password.Text) && !StringExtensions.IsNullOrWhiteSpace(txtLevel.Text) && !StringExtensions.IsNullOrWhiteSpace(txtRole.Text))
            {
                string name = Username.Text;
                string password = Password.Text;
                string temp = txtLevel.Text;
                string role = txtRole.Text;
                int level = 0;
                try
                {
                    int result = Int32.Parse(temp);
                    level = result;
                    Console.WriteLine(result);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{temp}'");
                }

                user.Add(new User(name, password, role, level));

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtDisplay.Visible = true;
            txtDisplay.Text = "";
            foreach (var item in user)
            {
                txtDisplay.Text = txtDisplay.Text + item.Name + "\t" + item.Password + "\t" + item.Title + "\t" + item.Privilege + Environment.NewLine;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
