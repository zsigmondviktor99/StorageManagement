using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raktar
{
    public partial class frm_Product : Form
    {
        StorageContext context = new StorageContext();
        Product product;
        public Product Product { get => product; set => product = value; }

        public frm_Product()
        {
            InitializeComponent();
            List<Type> types = context.Types.ToList();
            foreach (Type t in types)
            {
                cb_Type.Items.Add(t.Name);
            }
        }

        public frm_Product(Product p) : this()
        {
            product = p;

            tb_productId.Text = product.ProductId;
            tb_Name.Text = product.Name;
            tb_Description.Text = product.Description;
            nud_Quantity.Value = product.Quantity;
            tb_Supplier.Text = product.Supplier;
            cb_Type.SelectedIndex = product.TypeId - 1;
            cb_Available.Checked = product.IsAvailable;
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            if (tb_productId.Text == "" || tb_Name.Text == "" || tb_Description.Text == "" || tb_Supplier.Text == "" || cb_Type.SelectedIndex == -1)
            {
                MessageBox.Show("Fill every input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (product == null)
                {
                    product = new Product();
                }

                product.ProductId = tb_productId.Text;
                product.Name = tb_Name.Text;
                product.Description = tb_Description.Text;
                product.Quantity = (int)nud_Quantity.Value;
                product.Supplier = tb_Supplier.Text;
                product.TypeId = cb_Type.SelectedIndex + 1;
                product.IsAvailable = cb_Available.Checked;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
