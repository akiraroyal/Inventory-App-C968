using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.model;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdatePartsGrid();


        }
        private void UpdatePartsGrid()
        {
            dvgParts.DataSource = new BindingList<Part>(Inventory.AllParts);
            dvgParts.Refresh();

            dvgProducts.DataSource = new BindingList<Product>(Inventory.Products);
            dvgProducts.Refresh();


        }

        private void MainAddBtn1_Click(object sender, EventArgs e)
        {
            // new PartsForm().ShowDialog();
            addPartsForm addPartForm = new addPartsForm();
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                UpdatePartsGrid();
            }

        }

        private void MainModifyBtn1_Click(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a part to modify");
                return;
            }

            Part selectedPart = (Part)dvgParts.CurrentRow.DataBoundItem;

            if (selectedPart == null)
            {
                MessageBox.Show("Unable to retrieve the selected part");
                return;
            }

            addPartsForm modifyPartForm;
            if (selectedPart is InHouse inHousePart)
            {
                modifyPartForm = new addPartsForm(inHousePart);
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                modifyPartForm = new addPartsForm(outsourcedPart);
            }
            else
            {
                return;
            }
            if (modifyPartForm.ShowDialog() == DialogResult.OK)
            {
                dvgParts.Refresh();
            }


        }

        private void MainAddProductbtn_Click(object sender, EventArgs e)
        {
            addProductsForm addProductsForm = new addProductsForm();
            if (addProductsForm.ShowDialog() == DialogResult.OK)
            {
                UpdateProducutsGrid();
            }
        }

        private void UpdateProducutsGrid()
        {
            dvgProducts.DataSource = null;
            dvgProducts.DataSource = new BindingList<Product>(Inventory.Products);
            dvgProducts.Refresh();
        }

        private void MainDeleteBtn1_Click(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count == 0) return;

            Part selectedPart = (Part)dvgParts.CurrentRow.DataBoundItem;

            Inventory.AllParts.Remove(selectedPart);
            UpdatePartsGrid();
        }

        private void MainModifyBtn2_Click(object sender, EventArgs e)
        {
            if (dvgProducts.SelectedRows.Count == 0) return;

            Product selectedProduct = (Product)dvgProducts.CurrentRow.DataBoundItem;

            if(selectedProduct == null)
            {
                MessageBox.Show("Select a product");
            }

            addProductsForm modifyProductForm = new addProductsForm(selectedProduct);
            DialogResult result = modifyProductForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateProducutsGrid();
            }


        }

        private void MainDeleteBtn2_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dvgProducts.CurrentRow.DataBoundItem;

            if (selectedProduct == null) return;

            if (selectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Product with an associated part CANNOT be deleted");
                return;
            }


            DialogResult result = MessageBox.Show("Do you want to delete this product?", "Confirm Delete ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Inventory.Products.Remove(selectedProduct);
                UpdateProducutsGrid();
            }


           
        }

        private void serachPartsBtn1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPartSearch.Text, out int partId))
            {
                Part partFound = Inventory.LookupPart(partId);
                if (partFound != null)
                {
                    foreach (DataGridViewRow row in dvgParts.Rows)
                    {
                        Part part = row.DataBoundItem as Part;
                        if (part.PartID == partFound.PartID)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }

            }

            MessageBox.Show("Part not found");

        }

        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductSearch.Text, out int productId))
            {
                Product productFound = Inventory.LookupProduct(productId);
                if (productFound != null)
                {
                    foreach (DataGridViewRow row in dvgProducts.Rows)
                    {
                        Product product = row.DataBoundItem as Product;
                        if (product.ProductID == productFound.ProductID)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                    
                }
            }
            MessageBox.Show("Product not found");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}

