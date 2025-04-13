using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    partial class addProductsForm
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
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Label();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdTxtBox1 = new System.Windows.Forms.TextBox();
            this.NameTxtBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.InventoryTextBox1 = new System.Windows.Forms.TextBox();
            this.InventoryLabel1 = new System.Windows.Forms.Label();
            this.PriceTxtBox1 = new System.Windows.Forms.TextBox();
            this.PriceLabel1 = new System.Windows.Forms.Label();
            this.MinLabel1 = new System.Windows.Forms.Label();
            this.MaxLabel1 = new System.Windows.Forms.Label();
            this.MinTxtBox1 = new System.Windows.Forms.TextBox();
            this.MaxTxtBox1 = new System.Windows.Forms.TextBox();
            this.DeleteBtn1 = new System.Windows.Forms.Button();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.SaveBtn2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AllPartsLabel = new System.Windows.Forms.Label();
            this.SearchTxtBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(399, 51);
            this.dgvAllParts.MultiSelect = false;
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.ReadOnly = true;
            this.dgvAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllParts.Size = new System.Drawing.Size(554, 202);
            this.dgvAllParts.TabIndex = 0;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(399, 305);
            this.dgvAssociatedParts.MultiSelect = false;
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(554, 202);
            this.dgvAssociatedParts.TabIndex = 1;
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Location = new System.Drawing.Point(722, 17);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(64, 20);
            this.SearchBtn1.TabIndex = 2;
            this.SearchBtn1.Text = "Search";
            this.SearchBtn1.UseVisualStyleBackColor = true;
            // 
            // AddBtn1
            // 
            this.AddBtn1.Location = new System.Drawing.Point(888, 258);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(64, 20);
            this.AddBtn1.TabIndex = 3;
            this.AddBtn1.Text = "Add";
            this.AddBtn1.UseVisualStyleBackColor = true;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn1_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = true;
            this.AddProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(31, 20);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(117, 25);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "Add Product";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Location = new System.Drawing.Point(31, 68);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(18, 13);
            this.IdLabel1.TabIndex = 5;
            this.IdLabel1.Text = "ID";
            // 
            // IdTxtBox1
            // 
            this.IdTxtBox1.Location = new System.Drawing.Point(97, 66);
            this.IdTxtBox1.Name = "IdTxtBox1";
            this.IdTxtBox1.ReadOnly = true;
            this.IdTxtBox1.Size = new System.Drawing.Size(162, 20);
            this.IdTxtBox1.TabIndex = 6;
            // 
            // NameTxtBox1
            // 
            this.NameTxtBox1.Location = new System.Drawing.Point(97, 104);
            this.NameTxtBox1.Name = "NameTxtBox1";
            this.NameTxtBox1.Size = new System.Drawing.Size(162, 20);
            this.NameTxtBox1.TabIndex = 8;
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(31, 111);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(35, 13);
            this.NameLabel1.TabIndex = 7;
            this.NameLabel1.Text = "Name";
            // 
            // InventoryTextBox1
            // 
            this.InventoryTextBox1.Location = new System.Drawing.Point(97, 150);
            this.InventoryTextBox1.Name = "InventoryTextBox1";
            this.InventoryTextBox1.Size = new System.Drawing.Size(162, 20);
            this.InventoryTextBox1.TabIndex = 10;
            // 
            // InventoryLabel1
            // 
            this.InventoryLabel1.AutoSize = true;
            this.InventoryLabel1.Location = new System.Drawing.Point(31, 153);
            this.InventoryLabel1.Name = "InventoryLabel1";
            this.InventoryLabel1.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel1.TabIndex = 9;
            this.InventoryLabel1.Text = "Inventory";
            // 
            // PriceTxtBox1
            // 
            this.PriceTxtBox1.Location = new System.Drawing.Point(97, 192);
            this.PriceTxtBox1.Name = "PriceTxtBox1";
            this.PriceTxtBox1.Size = new System.Drawing.Size(162, 20);
            this.PriceTxtBox1.TabIndex = 12;
            // 
            // PriceLabel1
            // 
            this.PriceLabel1.AutoSize = true;
            this.PriceLabel1.Location = new System.Drawing.Point(31, 194);
            this.PriceLabel1.Name = "PriceLabel1";
            this.PriceLabel1.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel1.TabIndex = 11;
            this.PriceLabel1.Text = "Price";
            // 
            // MinLabel1
            // 
            this.MinLabel1.AutoSize = true;
            this.MinLabel1.Location = new System.Drawing.Point(215, 240);
            this.MinLabel1.Name = "MinLabel1";
            this.MinLabel1.Size = new System.Drawing.Size(24, 13);
            this.MinLabel1.TabIndex = 13;
            this.MinLabel1.Text = "Min";
            // 
            // MaxLabel1
            // 
            this.MaxLabel1.AutoSize = true;
            this.MaxLabel1.Location = new System.Drawing.Point(31, 240);
            this.MaxLabel1.Name = "MaxLabel1";
            this.MaxLabel1.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel1.TabIndex = 14;
            this.MaxLabel1.Text = "Max";
            // 
            // MinTxtBox1
            // 
            this.MinTxtBox1.Location = new System.Drawing.Point(270, 237);
            this.MinTxtBox1.Name = "MinTxtBox1";
            this.MinTxtBox1.Size = new System.Drawing.Size(86, 20);
            this.MinTxtBox1.TabIndex = 15;
            // 
            // MaxTxtBox1
            // 
            this.MaxTxtBox1.Location = new System.Drawing.Point(97, 233);
            this.MaxTxtBox1.Name = "MaxTxtBox1";
            this.MaxTxtBox1.Size = new System.Drawing.Size(86, 20);
            this.MaxTxtBox1.TabIndex = 16;
            // 
            // DeleteBtn1
            // 
            this.DeleteBtn1.Location = new System.Drawing.Point(888, 512);
            this.DeleteBtn1.Name = "DeleteBtn1";
            this.DeleteBtn1.Size = new System.Drawing.Size(64, 20);
            this.DeleteBtn1.TabIndex = 17;
            this.DeleteBtn1.Text = "Delete";
            this.DeleteBtn1.UseVisualStyleBackColor = true;
            this.DeleteBtn1.Click += new System.EventHandler(this.DeleteBtn1_Click);
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(737, 512);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(64, 20);
            this.CancelBtn1.TabIndex = 18;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // SaveBtn2
            // 
            this.SaveBtn2.Location = new System.Drawing.Point(668, 512);
            this.SaveBtn2.Name = "SaveBtn2";
            this.SaveBtn2.Size = new System.Drawing.Size(64, 20);
            this.SaveBtn2.TabIndex = 19;
            this.SaveBtn2.Text = "Save";
            this.SaveBtn2.UseVisualStyleBackColor = true;
            this.SaveBtn2.Click += new System.EventHandler(this.SaveBtn2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // AllPartsLabel
            // 
            this.AllPartsLabel.AutoSize = true;
            this.AllPartsLabel.Location = new System.Drawing.Point(399, 20);
            this.AllPartsLabel.Name = "AllPartsLabel";
            this.AllPartsLabel.Size = new System.Drawing.Size(45, 13);
            this.AllPartsLabel.TabIndex = 21;
            this.AllPartsLabel.Text = "All Parts";
            // 
            // SearchTxtBox1
            // 
            this.SearchTxtBox1.Location = new System.Drawing.Point(791, 17);
            this.SearchTxtBox1.Name = "SearchTxtBox1";
            this.SearchTxtBox1.Size = new System.Drawing.Size(162, 20);
            this.SearchTxtBox1.TabIndex = 22;
            // 
            // addProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 553);
            this.Controls.Add(this.SearchTxtBox1);
            this.Controls.Add(this.AllPartsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SaveBtn2);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.DeleteBtn1);
            this.Controls.Add(this.MaxTxtBox1);
            this.Controls.Add(this.MinTxtBox1);
            this.Controls.Add(this.MaxLabel1);
            this.Controls.Add(this.MinLabel1);
            this.Controls.Add(this.PriceTxtBox1);
            this.Controls.Add(this.PriceLabel1);
            this.Controls.Add(this.InventoryTextBox1);
            this.Controls.Add(this.InventoryLabel1);
            this.Controls.Add(this.NameTxtBox1);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.IdTxtBox1);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.AddBtn1);
            this.Controls.Add(this.SearchBtn1);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Name = "addProductsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAllParts;
        private DataGridView dgvAssociatedParts;
        private Button SearchBtn1;
        private Button AddBtn1;
        private Label AddProduct;
        private Label IdLabel1;
        private TextBox IdTxtBox1;
        private TextBox NameTxtBox1;
        private Label NameLabel1;
        private TextBox InventoryTextBox1;
        private Label InventoryLabel1;
        private TextBox PriceTxtBox1;
        private Label PriceLabel1;
        private Label MinLabel1;
        private Label MaxLabel1;
        private TextBox MinTxtBox1;
        private TextBox MaxTxtBox1;
        private Button DeleteBtn1;
        private Button CancelBtn1;
        private Button SaveBtn2;
        private Label label8;
        private Label AllPartsLabel;
        private TextBox SearchTxtBox1;
    }
}
