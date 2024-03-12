using KKInventorySystem.Models;
using System;
using System.Windows.Forms;

namespace KKInventorySystem
{    
    public partial class PartForm : Form
    {

        private bool isEditMode = false;
        private Part currentPart = null;

        public PartForm(Part partToEdit = null)
        {
            InitializeComponent();

            if (partToEdit != null)
            {
                isEditMode = true;
                currentPart = partToEdit;
                PopulateFields(partToEdit);
            }
        }

        private void PopulateFields(Part part)
        {
            txtBoxID.Text = part.PartID.ToString();
            txtBoxName.Text = part.Name;
            txtBoxPrice.Text = part.Price.ToString();
            txtBoxInventory.Text = part.InStock.ToString();
            txtBoxMac.Text = part.Max.ToString();
            txtBoxMin.Text = part.Min.ToString();

            if (part is Inhouse inhousePart)
            {
                radioInHouse.Checked = true;
                txtBoxDynamic.Text = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                radioOutSourced.Checked = true;
                txtBoxDynamic.Text = outsourcedPart.CompanyName;
            }
        }

        private bool validateFields()
        {
            return true;
        }

        private void updateProduct() 
        {
            try
            {
                currentPart.Name = txtBoxName.Text;
                //currentPart.inStock = txtBoxInventory.Text;
                //currentPart
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveProduct()
        {
            try
            {
                var partID = GeneratePartID();
                
                var name = txtBoxName.Text;
                var price = decimal.Parse(txtBoxPrice.Text);
                var inStock = int.Parse(txtBoxInventory.Text);
                var min = int.Parse(txtBoxMin.Text);
                var max = int.Parse(txtBoxMac.Text);

                if (radioInHouse.Checked)
                {
                    var machineID = int.Parse(txtBoxDynamic.Text);
                    var inhousePart = new Inhouse(partID, name, price, inStock, min, max, machineID);
                    Inventory.AddPart(inhousePart);
                }
                else
                {
                    var companyName = txtBoxDynamic.Text;
                    var outsourcedPart = new Outsourced(partID, name, price, inStock, min, max, companyName);
                    Inventory.AddPart(outsourcedPart);
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GeneratePartID()
        {
            return 9;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isValid = validateFields();
            if (!isValid) 
            {
                return;
            }
            if (isEditMode)
            {
                updateProduct();
            }
            else 
            {
                saveProduct();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
