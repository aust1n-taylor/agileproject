﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory newInventory = new Inventory();
            newInventory.Show();

        }
    }
}
