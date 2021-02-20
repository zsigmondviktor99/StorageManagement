
namespace Raktar
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_addProduct = new System.Windows.Forms.Button();
            this.bt_modifyProduct = new System.Windows.Forms.Button();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_searchById = new System.Windows.Forms.Button();
            this.gb_manageProducts = new System.Windows.Forms.GroupBox();
            this.gb_searchProducts = new System.Windows.Forms.GroupBox();
            this.bt_serachByType = new System.Windows.Forms.Button();
            this.bt_seearchByQuantity = new System.Windows.Forms.Button();
            this.bt_searchByName = new System.Windows.Forms.Button();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.lb_productDetails = new System.Windows.Forms.ListBox();
            this.gb_manageProducts.SuspendLayout();
            this.gb_searchProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_addProduct
            // 
            this.bt_addProduct.Location = new System.Drawing.Point(6, 22);
            this.bt_addProduct.Name = "bt_addProduct";
            this.bt_addProduct.Size = new System.Drawing.Size(223, 23);
            this.bt_addProduct.TabIndex = 1;
            this.bt_addProduct.Text = "Add product";
            this.bt_addProduct.UseVisualStyleBackColor = true;
            this.bt_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // bt_modifyProduct
            // 
            this.bt_modifyProduct.Location = new System.Drawing.Point(6, 51);
            this.bt_modifyProduct.Name = "bt_modifyProduct";
            this.bt_modifyProduct.Size = new System.Drawing.Size(223, 23);
            this.bt_modifyProduct.TabIndex = 2;
            this.bt_modifyProduct.Text = "Modify product";
            this.bt_modifyProduct.UseVisualStyleBackColor = true;
            this.bt_modifyProduct.Click += new System.EventHandler(this.bt_modifyProduct_Click);
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.Location = new System.Drawing.Point(6, 82);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(223, 23);
            this.bt_deleteProduct.TabIndex = 3;
            this.bt_deleteProduct.Text = "Delete product";
            this.bt_deleteProduct.UseVisualStyleBackColor = true;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_deleteProduct_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(12, 470);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(485, 23);
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_searchById
            // 
            this.bt_searchById.Location = new System.Drawing.Point(6, 22);
            this.bt_searchById.Name = "bt_searchById";
            this.bt_searchById.Size = new System.Drawing.Size(222, 23);
            this.bt_searchById.TabIndex = 5;
            this.bt_searchById.Text = "Search by ID";
            this.bt_searchById.UseVisualStyleBackColor = true;
            // 
            // gb_manageProducts
            // 
            this.gb_manageProducts.Controls.Add(this.bt_addProduct);
            this.gb_manageProducts.Controls.Add(this.bt_modifyProduct);
            this.gb_manageProducts.Controls.Add(this.bt_deleteProduct);
            this.gb_manageProducts.Location = new System.Drawing.Point(262, 194);
            this.gb_manageProducts.Name = "gb_manageProducts";
            this.gb_manageProducts.Size = new System.Drawing.Size(235, 114);
            this.gb_manageProducts.TabIndex = 6;
            this.gb_manageProducts.TabStop = false;
            this.gb_manageProducts.Text = "Manage products";
            // 
            // gb_searchProducts
            // 
            this.gb_searchProducts.Controls.Add(this.bt_serachByType);
            this.gb_searchProducts.Controls.Add(this.bt_seearchByQuantity);
            this.gb_searchProducts.Controls.Add(this.bt_searchByName);
            this.gb_searchProducts.Controls.Add(this.bt_searchById);
            this.gb_searchProducts.Location = new System.Drawing.Point(263, 323);
            this.gb_searchProducts.Name = "gb_searchProducts";
            this.gb_searchProducts.Size = new System.Drawing.Size(234, 144);
            this.gb_searchProducts.TabIndex = 7;
            this.gb_searchProducts.TabStop = false;
            this.gb_searchProducts.Text = "Search products";
            // 
            // bt_serachByType
            // 
            this.bt_serachByType.Location = new System.Drawing.Point(5, 82);
            this.bt_serachByType.Name = "bt_serachByType";
            this.bt_serachByType.Size = new System.Drawing.Size(223, 23);
            this.bt_serachByType.TabIndex = 8;
            this.bt_serachByType.Text = "Search by type";
            this.bt_serachByType.UseVisualStyleBackColor = true;
            // 
            // bt_seearchByQuantity
            // 
            this.bt_seearchByQuantity.Location = new System.Drawing.Point(5, 111);
            this.bt_seearchByQuantity.Name = "bt_seearchByQuantity";
            this.bt_seearchByQuantity.Size = new System.Drawing.Size(223, 23);
            this.bt_seearchByQuantity.TabIndex = 7;
            this.bt_seearchByQuantity.Text = "Search by quantity";
            this.bt_seearchByQuantity.UseVisualStyleBackColor = true;
            // 
            // bt_searchByName
            // 
            this.bt_searchByName.Location = new System.Drawing.Point(5, 51);
            this.bt_searchByName.Name = "bt_searchByName";
            this.bt_searchByName.Size = new System.Drawing.Size(223, 23);
            this.bt_searchByName.TabIndex = 6;
            this.bt_searchByName.Text = "Search by name";
            this.bt_searchByName.UseVisualStyleBackColor = true;
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.ItemHeight = 15;
            this.lb_products.Location = new System.Drawing.Point(12, 10);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(235, 454);
            this.lb_products.TabIndex = 8;
            this.lb_products.SelectedIndexChanged += new System.EventHandler(this.lb_products_SelectedIndexChanged);
            // 
            // lb_productDetails
            // 
            this.lb_productDetails.FormattingEnabled = true;
            this.lb_productDetails.ItemHeight = 15;
            this.lb_productDetails.Location = new System.Drawing.Point(262, 10);
            this.lb_productDetails.Name = "lb_productDetails";
            this.lb_productDetails.Size = new System.Drawing.Size(235, 169);
            this.lb_productDetails.TabIndex = 9;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 505);
            this.Controls.Add(this.lb_productDetails);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.gb_searchProducts);
            this.Controls.Add(this.gb_manageProducts);
            this.Controls.Add(this.bt_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            this.gb_manageProducts.ResumeLayout(false);
            this.gb_searchProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_addProduct;
        private System.Windows.Forms.Button bt_modifyProduct;
        private System.Windows.Forms.Button bt_deleteProduct;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_searchById;
        private System.Windows.Forms.GroupBox gb_manageProducts;
        private System.Windows.Forms.GroupBox gb_searchProducts;
        private System.Windows.Forms.Button bt_serachByType;
        private System.Windows.Forms.Button bt_seearchByQuantity;
        private System.Windows.Forms.Button bt_searchByName;
        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.ListBox lb_productDetails;
    }
}

