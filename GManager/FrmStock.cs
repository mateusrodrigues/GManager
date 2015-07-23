using GManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GManager
{
    public partial class FrmStock : Form
    {
        StockViewModel viewModel = new StockViewModel();

        public FrmStock()
        {
            InitializeComponent();
            dataGridEstoque.DataBindings.Add("DataSource", viewModel, "Products");
            tbTotalProducts.DataBindings.Add("Text", viewModel, "TotalProducts");
            tbTotalStockValue.DataBindings.Add("Text", viewModel, "TotalStockValue");
            tbTotalPotentialValue.DataBindings.Add("Text", viewModel, "TotalPotentialValue");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Dialogs.FrmItemBox dialog = new Dialogs.FrmItemBox(Dialogs.FrmItemBox.ItemOperation.Add);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var product = dialog.Product;
                viewModel.AddProduct(product.Name, product.BuyingPrice, product.SellingPrice);
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Certeza que deseja excluir esta entrada?", "Excluir Entrada", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridEstoque.SelectedRows[0].Cells[0].Value.ToString());
                viewModel.RemoveProduct(id);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridEstoque.SelectedRows[0].Cells[0].Value.ToString());
            var product = viewModel.Products.Find(m => m.ProductID == id);
            Dialogs.FrmItemBox dialog = new Dialogs.FrmItemBox(Dialogs.FrmItemBox.ItemOperation.Edit, product);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                viewModel.EditProduct(dialog.Product);
            }
        }
    }
}
