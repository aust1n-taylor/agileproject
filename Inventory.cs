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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only num chars entered for quantity, doesn't prevent illegal ctrl+v
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // If txtCount and txtItem have input, try to modify with modify count, if successful (return not null), inform user. 

        }
    }
}
