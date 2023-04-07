using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Username.Text = "test";
            //Home homeGo = new Home();
            //this.Hide();
            //homeGo.ShowDialog();
            //this.Close();
        }
    }
}
