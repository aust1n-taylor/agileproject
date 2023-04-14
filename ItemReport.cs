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
                label1.Text = "Supplies that are running low:";
                
                txtDisplay.Text = "Supply\t               Quantity\tThreshold" + Environment.NewLine;
                foreach (var item in inventory)
                {
                    /*if(item.Name == "Antibiotics")
                    {
                        txtDisplay.Text = txtDisplay.Text + item.Name + "\t\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                    }*/
                    // Formatting
                    
                    if (item.Name.Length <= 9 && item.Name != "Hand Soap" && item.Name != "Oxycodone")
                    {
                        txtDisplay.Text = txtDisplay.Text + item.Name + "\t\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                    }
                    else if (item.Name == "Antibiotics")
                    {
                        txtDisplay.Text = txtDisplay.Text + item.Name + "\t\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                    }
                    else
                    {
                        txtDisplay.Text = txtDisplay.Text + item.Name + "\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                    }
                }
            }
            // Janitor
            else if (privilege == 3) {


                label1.Text = "Supplies that are running low:";
                txtDisplay.Text = "Supply\t               Quantity\tThreshold" + Environment.NewLine;
                foreach (var item in inventory)
                {
                    // Only Allow for Janitor Items to show.
                    if(janitor.Contains(item.Name))
                    {
                        // Print that items that are low
                        if (item.Quantity <= item.Threshold)
                        {
                            // Formatting 
                            if (item.Name.Length <= 7)
                            {
                                txtDisplay.Text = txtDisplay.Text + item.Name + "\t\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                            }
                            else
                            {
                                txtDisplay.Text = txtDisplay.Text + item.Name + "\t" + item.Quantity + "\t        " + item.Threshold + Environment.NewLine;
                            }
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
