using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktar
{
    public partial class frm_Main : Form
    {
        StorageContext context = new StorageContext();

        public frm_Main()
        {
            InitializeComponent();
            FreshListBox();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bt_addProduct_Click(object sender, EventArgs e)
        {
            frm_Product frm = new frm_Product();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                context.Products.Add(frm.Product);
                context.SaveChanges();
                FreshListBox();
            }
        }

        private void FreshListBox()
        {
            lb_products.DataSource = null;
            lb_products.DataSource = context.Products.ToList();
        }

        private void lb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex != -1)
            {
                Product p = (Product)lb_products.SelectedItem;

                lb_productDetails.Items.Clear();
                lb_productDetails.Items.Add("Product ID: " + p.ProductId);
                lb_productDetails.Items.Add("Name: " + p.Name);
                lb_productDetails.Items.Add("Description: " + p.Description);
                lb_productDetails.Items.Add("Quantity: " + p.Quantity);
                lb_productDetails.Items.Add("Supplier: " + p.Supplier);
                lb_productDetails.Items.Add("Type: ");
                lb_productDetails.Items.Add("Available: " + ((p.IsAvailable) ? "Yes" : "No"));
            }
        }

        private void bt_modifyProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a product to modify it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Product p = (Product)lb_products.SelectedItem;
                frm_Product frm = new frm_Product(p);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = lb_products.SelectedIndex;
                    context.Products.Update(frm.Product);
                    context.SaveChanges();
                    FreshListBox();
                    lb_products.SelectedIndex = index;
                }
            }
        }

        private void bt_deleteProduct_Click(object sender, EventArgs e)
        {
            if (lb_products.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a product to delete it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(MessageBox.Show("Are you sure do you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Product p = (Product)lb_products.SelectedItem;
                context.Products.Remove(p);
                context.SaveChanges();
                FreshListBox();
            }
        }
    }
}
