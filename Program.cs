﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
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


            GetList l = new GetList();
            List<InventoryItem> inventory = l.inventory;

            // List of users
            GetUsers temp = new GetUsers();
            List<User> user = temp.user;

            /* List<InventoryItem> inventory = new List<InventoryItem>();

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
             */
            Console.WriteLine("Users");
            Console.WriteLine("----------------");
            foreach (var item in user)
            {
                Console.WriteLine("{0}, {1}, {2}, Privilege - {3}", item.Name, item.Password, item.Title, item.Privilege);
            }
            


            Console.WriteLine("Inventory Report");
            Console.WriteLine("----------------");

            foreach (var item in inventory)
            {
                Console.WriteLine("{0} - {1} units, theshold {2}", item.Name, item.Quantity, item.Threshold);
            }

            // Test Data for console log
            //inventory[1].Quantity = 1;
            ModifyItem.ModifyCount("Antibiotics", 5, inventory);
            ModifyItem.ModifyCount("Asprin", 7, inventory);

            Console.WriteLine("New Inventory Report");
            Console.WriteLine("----------------");

            foreach (var item in inventory)
            {
                Console.WriteLine("{0} - {1} units, theshold {2}", item.Name, item.Quantity, item.Threshold);
            }


            // Need to save list somehow, serialize to json maybe?
            //SaveList.SaveToFile(inventory);


            Console.ReadLine();
        }

        public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string Title { get; set; }
            public int Privilege { get; set; }

            public User(string name, string password, string title, int privilege) 
            {
                Name = name;
                Password = password;
                Title = title;
                Privilege = privilege;
            }
        }

        public class GetUsers
        {
            public List<User> user { get; set; }

            public GetUsers()
            {
                CreateUsers users = new CreateUsers();
                user = users.user;
            }
        }
        public class CreateUsers
        {
            public List<User> user = new List<User>();

            public CreateUsers()
            {
                // Dummy Data
                user.Add(new User("John", "Password", "Manager", 0));
                user.Add(new User("Janitor", "Password", "Janitor", 3));
                user.Add(new User("Dean", "adminpassword", "Admin", 0));
            }
        }

        public partial class CheckUser
        {
            public static int FindUser(string name, string password, List<User> user)
            {
                // Initial find function, returns user privilege
                int i = 0;
                int found = 0;
                foreach (var item in user)
                {
                    if (item.Name == name)
                    {
                        if(item.Password == password)
                        {
                            found = 1; break;
                        }
                    }
                    i++;
                }
                if (found == 1)
                {
                    return user[i].Privilege;
                }
                else
                {
                    // Could not find in list
                    return -1;
                }

            }
        }

        public class InventoryItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public int Threshold { get; set; }

            public InventoryItem(string name, int quantity, int threshold)
            {
                Name = name;
                Quantity = quantity;
                Threshold = threshold;
            }
        }



        public class CreateList
        {
            public List<InventoryItem> inventory = new List<InventoryItem>();

            public CreateList()
            {
                // Dummy Data
                // Not working
                /*
                string folder = @"C:\Users\MyUser\source\repos\agileproject\";
                string fileName = "InventoryDB.json";
                string fullPath = folder + fileName;
                string jsonString = File.ReadAllText(fullPath);
                InventoryItem inventory = JsonSerializer.Deserialize<InventoryItem>(jsonString);*/
                inventory.Add(new InventoryItem("Amphetamine", 10, 10));
                inventory.Add(new InventoryItem("Anesthesia", 20, 5));
                inventory.Add(new InventoryItem("Antibiotics", 20, 5));
                inventory.Add(new InventoryItem("Asprin", 3, 5));
                inventory.Add(new InventoryItem("Bleach", 18, 5));
                inventory.Add(new InventoryItem("Calcium Chloride", 30, 5));
                inventory.Add(new InventoryItem("Covid Tests", 50, 10));
                inventory.Add(new InventoryItem("Fentanyl", 10, 5));
                inventory.Add(new InventoryItem("Hand Soap", 7, 5));
                inventory.Add(new InventoryItem("Ibuprofen", 40, 10));
                inventory.Add(new InventoryItem("Paper Towels", 1, 5));
                inventory.Add(new InventoryItem("Toilet Paper", 3, 5));
                inventory.Add(new InventoryItem("Morphine", 20, 10));
                inventory.Add(new InventoryItem("Oxycodone", 20, 10));
            }
        }

        public class SaveList
        {
            public static void SaveToFile(List<InventoryItem> inventory)
            {
                // temp save location
                string folder = @"C:\Users\MyUser\source\repos\agileproject\";
                string fileName = "InventoryDB.json";
                string fullPath = folder + fileName;
                string jsonString = JsonSerializer.Serialize(inventory);
                File.WriteAllText(fullPath, jsonString);
            }
        }

        public class GetList
        {
            public List<InventoryItem> inventory { get; set; }

            public GetList()
            {
                CreateList l = new CreateList();
                inventory = l.inventory;
            }  
        }
        public partial class ModifyItem
        {
            public static int ModifyCount(string name, int quantity, List<InventoryItem> inventory)
            {
                // Initial modify function
                int i = 0;
                int found = 0;
                foreach (var item in inventory)
                {
                    if (item.Name == name)
                    {
                        found = 1;
                        break;
                    }
                    i++;
                }
                if (found == 1)
                {
                    inventory[i].Quantity = quantity;
                    return 1;
                }
                else
                {
                    // Could not find in list
                    return -1;
                }

            }
        }
    }
}
