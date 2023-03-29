using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryTracker.Program;

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
            //Clear label just in case
            lblModifyResult.Text = "";

            // If txtCount and txtItem have input, try to modify with modify count, if successful (return not null), inform user. 
            if (!StringExtensions.IsNullOrWhiteSpace(txtCount.Text) && !StringExtensions.IsNullOrWhiteSpace(txtItem.Text))
            {
                GetList l = new GetList();
                List<InventoryItem> inventory = l.inventory;

                string name = txtItem.Text;
                string input = txtCount.Text;
                int count = 0;
                try
                {
                    int result = Int32.Parse(input);
                    count = result;
                    Console.WriteLine(result);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{input}'");
                }

                int check = ModifyItem.ModifyCount(name, count, inventory);

                if (check == -1)
                {
                    lblModifyResult.Text = "Item was not found.";
                }
                else 
                {
                    lblModifyResult.Text = "Item has been modified.";
                }

                // Debug
                Console.WriteLine("After Button Inventory Report");
                Console.WriteLine("----------------");

                foreach (var item in inventory)
                {
                    Console.WriteLine("{0} - {1} units", item.Name, item.Quantity);
                }
                //string message = txtItem.Text + " quantity has been updated to " + 
                
            }
            else 
            {
                // One of the text boxes does not contain text, send error message
                lblModifyResult.Text = "Please fill out both text boxes above.";
            }

        }
    }
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsWhiteSpace(value[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
