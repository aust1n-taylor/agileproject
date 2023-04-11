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
    public partial class ItemReport : Form
    {

        static GetList l = new GetList();
        List<InventoryItem> inventory = l.inventory;
        public ItemReport(int privilege)
        {
            InitializeComponent();
            Console.WriteLine("----------------");
            Console.WriteLine("Privilege = {0}", privilege);

            // Janitor
            if (privilege == 0)
            {
                //txtDisplay.Text = "Test";
                foreach (var item in inventory)
                {
                    txtDisplay.Text = txtDisplay.Text + item.Name + ": " + item.Quantity + Environment.NewLine;
                }
            }
            else if (privilege == 3) {
                foreach (var item in inventory)
                {
                    if(item.Quantity < 5)
                    {
                        txtDisplay.Text = txtDisplay.Text + item.Name + ": " + item.Quantity + Environment.NewLine;
                    }
                    
                }
            }
        }

        private void ItemReport_Load(object sender, EventArgs e)
        {

            
        }
    }
}
