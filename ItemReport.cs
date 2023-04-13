using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryTracker.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryTracker
{
    public partial class ItemReport : Form
    {
        // List of Janitor Supplies
        public List<string> janitor = new List<string>() {
            "Bleach",
            "Paper Towels",
            "Hand Soap",
            "Toilet Paper",
        };



        static GetList l = new GetList();
        List<InventoryItem> inventory = l.inventory;
        public ItemReport(int privilege)
        {
            InitializeComponent();
            Console.WriteLine("----------------");
            Console.WriteLine("Privilege = {0}", privilege);

            

            // Admin
            if (privilege == 0)
            {
                label1.Text = "Item Report.";
                foreach (var item in inventory)
                {
                    txtDisplay.Text = txtDisplay.Text + item.Name + ": " + item.Quantity + Environment.NewLine;
                }
            }
            // Janitor
            else if (privilege == 3) {


                label1.Text = "Supplies that are running low:";
                foreach (var item in inventory)
                {
                    // Only Allow for Janitor Items to show.
                    if(janitor.Contains(item.Name))
                    {
                        // Print that items that are low
                        if (item.Quantity < 5)
                        {
                            txtDisplay.Text = txtDisplay.Text + item.Name + ": " + item.Quantity + Environment.NewLine;
                        }
                        
                    } 
                    
                }

                
            }
        }

        private void ItemReport_Load(object sender, EventArgs e)
        {

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
