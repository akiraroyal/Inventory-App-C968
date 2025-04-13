using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.model;

namespace MainForm
{
    public partial class addPartsForm : Form
    {
        private Part existingPart = null;

        public addPartsForm()
        {
            InitializeComponent();
        }
        public addPartsForm(InHouse part)
        {
            InitializeComponent();
            existingPart = part;
            IdTextBox1.Text = part.PartID.ToString();
            NameTextBox1.Text = part.Name;
            InventoryTextBox1.Text = part.Instock.ToString();
            PriceTextBox1.Text = part.Price.ToString();
            MaxTextBox1.Text = part.Max.ToString();
            MinTextBox1.Text = part.Min.ToString();
            CompanyOrMachineLabel.Text = "Machine ID";
            MachineIdTextBox1.Text = part.MachineID.ToString();
            InHouseBtn1.Checked = true;



        }
        public addPartsForm(Outsourced part)
        {
            InitializeComponent();
            existingPart = part;
            IdTextBox1.Text = part.PartID.ToString();
            NameTextBox1.Text = part.Name;
            InventoryTextBox1.Text = part.Instock.ToString();
            PriceTextBox1.Text = part.Price.ToString();
            MaxTextBox1.Text = part.Max.ToString();
            MinTextBox1.Text = part.Min.ToString();
            CompanyOrMachineLabel.Text = "Company Name";
            MachineIdTextBox1.Text = part.CompanyName;
            OutsourcedBtn1.Checked = true;



        }





        private void inHouseBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseBtn1.Checked)
            {
                CompanyOrMachineLabel.Text = "Machine ID";
                MachineIdTextBox1.Text = "";

            }
        }

        private void OutsourcedBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedBtn1.Checked)
            {
                CompanyOrMachineLabel.Text = "Company Name";
                MachineIdTextBox1.Text = "";

            }
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox1.Text) ||
                string.IsNullOrWhiteSpace(InventoryTextBox1.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox1.Text) ||
                string.IsNullOrWhiteSpace(MaxTextBox1.Text) ||
                string.IsNullOrWhiteSpace(MinTextBox1.Text) ||
                string.IsNullOrWhiteSpace(MachineIdTextBox1.Text))
            {
                MessageBox.Show("Please make sure to fill out all available fields!");
                return;


            }
            try
            {
                int inventory = int.Parse(InventoryTextBox1.Text);
                decimal price = decimal.Parse(PriceTextBox1.Text);
                int max = int.Parse(MaxTextBox1.Text);
                int min = int.Parse(MinTextBox1.Text);

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
                


                if (existingPart != null)
                {
                    existingPart.Name = NameTextBox1.Text;
                    existingPart.Instock = inventory;
                    existingPart.Price = price;
                    existingPart.Min = min;
                    existingPart.Max = max;

                    if (existingPart is InHouse inHousePart)

                    {
                        if(!int.TryParse(MachineIdTextBox1.Text, out int machineId))
                        {
                            MessageBox.Show("Enter a number for the Machine ID");
                            return;
                        }
                        inHousePart.MachineID = machineId;
                    }
                    else if (existingPart is Outsourced outsourcedPart)
                    {
                        outsourcedPart.CompanyName = MachineIdTextBox1.Text;
                    }
                }
                else
                {
                    //modifying exsisting part
                    int newId = 1;
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.PartID >= newId)
                        {
                            newId = part.PartID + 1;

                        }
                    }
                    Part newPart = null;


                    if (InHouseBtn1.Checked)
                    {
                        if (!int.TryParse(MachineIdTextBox1.Text, out int machineId))
                        {
                            MessageBox.Show("Enter a number for the Machine ID");
                            return;
                        }
                            
                        newPart = new InHouse(newId, NameTextBox1.Text, price, inventory, min, max, machineId);
                    }
                    else if (OutsourcedBtn1.Checked)
                    {
                        string companyName = MachineIdTextBox1.Text;
                        newPart = new Outsourced(newId, NameTextBox1.Text, price, inventory, min, max, companyName);
                    }
                    if (newPart != null)
                    {
                        Inventory.AddPart(newPart);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid values");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //The cancel button in the add part form will work now
        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


