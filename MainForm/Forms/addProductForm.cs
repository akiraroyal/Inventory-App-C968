using System.ComponentModel;
using System.Windows.Forms;
using MainForm.model;

namespace MainForm
{
    public partial class addProductsForm : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private Product existingProduct = null;
        public addProductsForm()
        {
            InitializeComponent();

            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts;


        }

        public addProductsForm(Product product) : this()

        {
            existingProduct = product;

            NameTxtBox1.Text = product.Name;
            InventoryTextBox1.Text = product.InStock.ToString();
            PriceTxtBox1.Text = product.Price.ToString();
            MaxTxtBox1.Text = product.Max.ToString();
            MinTxtBox1.Text = product.Min.ToString();

            foreach(Part part in product.AssociatedParts)
            {
                associatedParts.Add(part);
            }
        }

        private void AddBtn1_Click(object sender, System.EventArgs e)
        {
            if (dgvAllParts.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)dgvAllParts.SelectedRows[0].DataBoundItem;

                if (!associatedParts.Contains(selectedPart))
                {
                    associatedParts.Add(selectedPart);
                }
                dgvAssociatedParts.DataSource = null;
                dgvAssociatedParts.DataSource = associatedParts;

            }
        
            else
            {
                MessageBox.Show("Add a part");


            }


        }

        private void DeleteBtn1_Click(object sender, System.EventArgs e)
        {
            if (dgvAssociatedParts.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)dgvAssociatedParts.SelectedRows[0].DataBoundItem;
                associatedParts.Remove(selectedPart);
                dgvAssociatedParts.Refresh();

            }
            else
            {
                MessageBox.Show("Remove a part");
            }
        }

        private void SaveBtn2_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxtBox1.Text) ||
               string.IsNullOrWhiteSpace(InventoryTextBox1.Text) ||
               string.IsNullOrWhiteSpace(PriceTxtBox1.Text) ||
               string.IsNullOrWhiteSpace(MaxTxtBox1.Text) ||
               string.IsNullOrWhiteSpace(MinTxtBox1.Text))

            {
                MessageBox.Show("Please make sure to fill out all available fields!");
                return;


            }
            try
            {
                int inventory = int.Parse(InventoryTextBox1.Text);
                decimal price = decimal.Parse(PriceTxtBox1.Text);
                int max = int.Parse(MaxTxtBox1.Text);
                int min = int.Parse(MinTxtBox1.Text);

                if (min > max)
                {
                    MessageBox.Show("The minimum value cannot be greater than the maximum value!");
                    return;

                }
                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory needs to be between the Minimum and Maximum values!");
                    return;


                }
                if (existingProduct != null)
                {
                    existingProduct.Name = NameTxtBox1.Text;
                    existingProduct.InStock = inventory;
                    existingProduct.Price = price;
                    existingProduct.Max = max;
                    existingProduct.Min = min;

                    existingProduct.AssociatedParts.Clear();
                    foreach (Part part in associatedParts)
                    {
                        existingProduct.addAssociatedPart(part);
                    }
                    //The updated product is being saved to the inventory
                    Inventory.UpdateProduct(existingProduct.ProductID, existingProduct);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {



                    int newId = 1;
                    foreach (Product product in Inventory.Products)
                    {
                        if (product.ProductID >= newId)
                        {
                            newId = product.ProductID + 1;
                        }
                    }
                    Product newProduct = new Product(newId, NameTxtBox1.Text, price, inventory, min, max);

                    foreach (Part part in associatedParts)
                    {
                        newProduct.addAssociatedPart(part);
                    }
                    Inventory.AddProduct(newProduct);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("invalid number");
            }
        }
        

        private void CancelBtn1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

