
namespace Raktar
{
    partial class frm_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_productId = new System.Windows.Forms.TextBox();
            this.la_productId = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.la_Name = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.la_Description = new System.Windows.Forms.Label();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.la_Quantity = new System.Windows.Forms.Label();
            this.tb_Supplier = new System.Windows.Forms.TextBox();
            this.la_Supplier = new System.Windows.Forms.Label();
            this.la_Type = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.la_Available = new System.Windows.Forms.Label();
            this.cb_Available = new System.Windows.Forms.CheckBox();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_productId
            // 
            this.tb_productId.Location = new System.Drawing.Point(172, 12);
            this.tb_productId.Name = "tb_productId";
            this.tb_productId.Size = new System.Drawing.Size(208, 23);
            this.tb_productId.TabIndex = 0;
            // 
            // la_productId
            // 
            this.la_productId.AutoSize = true;
            this.la_productId.Location = new System.Drawing.Point(9, 15);
            this.la_productId.Name = "la_productId";
            this.la_productId.Size = new System.Drawing.Size(66, 15);
            this.la_productId.TabIndex = 1;
            this.la_productId.Text = "Product ID:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(172, 41);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(208, 23);
            this.tb_Name.TabIndex = 2;
            // 
            // la_Name
            // 
            this.la_Name.AutoSize = true;
            this.la_Name.Location = new System.Drawing.Point(12, 44);
            this.la_Name.Name = "la_Name";
            this.la_Name.Size = new System.Drawing.Size(42, 15);
            this.la_Name.TabIndex = 3;
            this.la_Name.Text = "Name:";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(172, 70);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(208, 80);
            this.tb_Description.TabIndex = 4;
            // 
            // la_Description
            // 
            this.la_Description.AutoSize = true;
            this.la_Description.Location = new System.Drawing.Point(9, 73);
            this.la_Description.Name = "la_Description";
            this.la_Description.Size = new System.Drawing.Size(70, 15);
            this.la_Description.TabIndex = 5;
            this.la_Description.Text = "Description:";
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(172, 156);
            this.nud_Quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(208, 23);
            this.nud_Quantity.TabIndex = 6;
            // 
            // la_Quantity
            // 
            this.la_Quantity.AutoSize = true;
            this.la_Quantity.Location = new System.Drawing.Point(9, 158);
            this.la_Quantity.Name = "la_Quantity";
            this.la_Quantity.Size = new System.Drawing.Size(56, 15);
            this.la_Quantity.TabIndex = 7;
            this.la_Quantity.Text = "Quantity:";
            // 
            // tb_Supplier
            // 
            this.tb_Supplier.Location = new System.Drawing.Point(172, 185);
            this.tb_Supplier.Name = "tb_Supplier";
            this.tb_Supplier.Size = new System.Drawing.Size(208, 23);
            this.tb_Supplier.TabIndex = 8;
            // 
            // la_Supplier
            // 
            this.la_Supplier.AutoSize = true;
            this.la_Supplier.Location = new System.Drawing.Point(12, 188);
            this.la_Supplier.Name = "la_Supplier";
            this.la_Supplier.Size = new System.Drawing.Size(53, 15);
            this.la_Supplier.TabIndex = 9;
            this.la_Supplier.Text = "Supplier:";
            // 
            // la_Type
            // 
            this.la_Type.AutoSize = true;
            this.la_Type.Location = new System.Drawing.Point(12, 222);
            this.la_Type.Name = "la_Type";
            this.la_Type.Size = new System.Drawing.Size(34, 15);
            this.la_Type.TabIndex = 10;
            this.la_Type.Text = "Type:";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(172, 219);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(208, 23);
            this.cb_Type.TabIndex = 11;
            // 
            // la_Available
            // 
            this.la_Available.AutoSize = true;
            this.la_Available.Location = new System.Drawing.Point(12, 265);
            this.la_Available.Name = "la_Available";
            this.la_Available.Size = new System.Drawing.Size(58, 15);
            this.la_Available.TabIndex = 12;
            this.la_Available.Text = "Available:";
            // 
            // cb_Available
            // 
            this.cb_Available.AutoSize = true;
            this.cb_Available.Checked = true;
            this.cb_Available.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Available.Location = new System.Drawing.Point(172, 264);
            this.cb_Available.Name = "cb_Available";
            this.cb_Available.Size = new System.Drawing.Size(74, 19);
            this.cb_Available.TabIndex = 13;
            this.cb_Available.Text = "Available";
            this.cb_Available.UseVisualStyleBackColor = true;
            // 
            // bt_Ok
            // 
            this.bt_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ok.Location = new System.Drawing.Point(305, 327);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 14;
            this.bt_Ok.Text = "Ok";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(305, 356);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 388);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.cb_Available);
            this.Controls.Add(this.la_Available);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.la_Type);
            this.Controls.Add(this.la_Supplier);
            this.Controls.Add(this.tb_Supplier);
            this.Controls.Add(this.la_Quantity);
            this.Controls.Add(this.nud_Quantity);
            this.Controls.Add(this.la_Description);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.la_Name);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.la_productId);
            this.Controls.Add(this.tb_productId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_productId;
        private System.Windows.Forms.Label la_productId;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label la_Name;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label la_Description;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.Label la_Quantity;
        private System.Windows.Forms.TextBox tb_Supplier;
        private System.Windows.Forms.Label la_Supplier;
        private System.Windows.Forms.Label la_Type;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label la_Available;
        private System.Windows.Forms.CheckBox cb_Available;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}