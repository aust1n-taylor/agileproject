using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    
    public partial class PurchaseOrder : Form
    {
        double Total = 0;
        int rowCount = 0;
        public PurchaseOrder()
        {
            
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            var product = "0";
            var quantity = 0;
            var costtxt = "0";

            if (rowCount == 8)
            {
                return;
            }

            else
            {
                rowCount++;
            }

            product = producttxtbox.Text;
            quantity = int.Parse(quantitytxtbox.Text);
            costtxt = pricetxtbox.Text;

            var cost = double.Parse(costtxt);

            orderGrid.Rows.Add(producttxtbox.Text, quantitytxtbox.Text, cost);

            Total += cost*quantity;
            totalCosttxtbox.Text = Total.ToString();
            
        }
    }
}
