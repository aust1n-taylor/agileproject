using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    public partial class Home : Form 
    {
        int globalpriv = -1;
        public Home(int privilege)
        {
            InitializeComponent();
            globalpriv = privilege;
            switch (privilege)
            {
                case 0:
                    // Most privileges
                    btnInventory.Enabled = true;
                    lblLevel.Text = "Admin";
                    break;
                case 1:
                    lblLevel.Text = "Doctor";
                    break;
                case 2:
                    lblLevel.Text = "Nurse";
                    break;
                case 3:
                    // Example of how to hide things
                    btnInventory.Enabled = false;
                    btnAlert.Enabled = true;
                    lblLevel.Text = "Janitor";
                    break;

            }
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory newInventory = new Inventory();
            newInventory.Show();

        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            ItemReport itemReport = new ItemReport(globalpriv);
            itemReport.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btngenpo_Click(object sender, EventArgs e)
        {
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrder.Show();
        }
    }
}
