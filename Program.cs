using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            List<InventoryItem> inventory = new List<InventoryItem>();

            inventory.Add(new InventoryItem("Amphetamine", 0));
            inventory.Add(new InventoryItem("Anesthesia", 0));
            inventory.Add(new InventoryItem("Antibiotics", 0));
            inventory.Add(new InventoryItem("Asprin", 0));
            inventory.Add(new InventoryItem("Calcium Chloride", 0));
            inventory.Add(new InventoryItem("Covid Tests", 0));
            inventory.Add(new InventoryItem("Fentanyl", 0));
            inventory.Add(new InventoryItem("Ibuprofen", 0));
            inventory.Add(new InventoryItem("Morphine", 0));
            inventory.Add(new InventoryItem("Oxycodone", 0));


            Console.WriteLine("Inventory Report");
            Console.WriteLine("----------------");

            foreach (var item in inventory)
            {
                Console.WriteLine("{0} - {1} units", item.Name, item.Quantity);
            }

            // Test Data for console log
            inventory[1].Quantity = 1;
            ModifyItem.ModifyCount("Antibiotics", 5, inventory);

            Console.WriteLine("New Inventory Report");
            Console.WriteLine("----------------");

            foreach (var item in inventory)
            {
                Console.WriteLine("{0} - {1} units", item.Name, item.Quantity);
            }


            // Need to save list somehow, serialize to json maybe?
            Console.ReadLine();
        }

        class InventoryItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public InventoryItem(string name, int quantity)
            {
                Name = name;
                Quantity = quantity;
            }
        }

        class ModifyItem 
        {
            public static void ModifyCount(string name, int quantity, List<InventoryItem> inventory)
            {
                // Initial modify function
                int i = 0;
                foreach (var item in inventory)
                {
                    if (item.Name == name)
                    {
                        break;
                    }
                    i++;
                }
                inventory[i].Quantity = quantity;
            }
        }
    }
}
