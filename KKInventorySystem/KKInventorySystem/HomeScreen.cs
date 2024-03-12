using KKInventorySystem.Models;
using System;
using System.Windows.Forms;

namespace KKInventorySystem
{
    public partial class HomeScreen : Form
    {

        public HomeScreen()
        {
            InitializeComponent();
            resetGridViews();
            setupPartsGrid();
            setupProductsGrid();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewProducts.DataSource = Inventory.Products;
        }

        private void setupPartsGrid()
        {

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Part ID",
                DataPropertyName = "PartID"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Part Name",
                DataPropertyName = "Name"
            });
            dataGridViewParts.ClearSelection();
        }

        private void setupProductsGrid()
        {

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product ID",
                DataPropertyName = "PartID"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product Name",
                DataPropertyName = "Name"
            });
        }

        private void resetGridViews()
        {
            dataGridViewParts.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(DataGridViewParts_DataBindingComplete);

            dataGridViewParts.RowHeadersVisible = false;
            dataGridViewParts.AutoGenerateColumns = false;

            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AutoGenerateColumns = false;
        }

        private void DataGridViewParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewParts.ClearSelection();
        }


        private void btnPartsAdd_Click(object sender, EventArgs e)
        {
            PartForm addPartForm = new PartForm(null);
            addPartForm.ShowDialog();
        }

        private void btnPartsEdit_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dataGridViewParts.CurrentRow.DataBoundItem;
            if (selectedPart != null)
            {
                PartForm addPartForm = new PartForm(selectedPart);
                addPartForm.ShowDialog();
            }
        }

        private void btnPartsDelete_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)dataGridViewParts.CurrentRow.DataBoundItem;
            if (selectedPart != null)
            {
                Inventory.DeletePart(selectedPart);
            }
        }

        private void btnPartsSearch_Click(object sender, EventArgs e)
        {

        }


        private Part getSelectedProduct()
        {
            if (dataGridViewParts.SelectedRows.Count > 0)
            {
                int partID = Convert.ToInt32(dataGridViewParts.SelectedRows[0].Cells["PartID"].Value);
                Part selectedPart = Inventory.LookupPart(partID);
                return selectedPart;
            }
            else
            { return null; }
        }

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnProductsEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
