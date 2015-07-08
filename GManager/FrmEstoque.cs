using GManager.DAL;
using GManager.Models;
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
    public partial class FrmEstoque : Form
    {
        StockViewModel viewModel = new StockViewModel();

        public FrmEstoque()
        {
            InitializeComponent();
            dataGridEstoque.DataBindings.Add("DataSource", viewModel, "Products");
            tbTotalProducts.DataBindings.Add("Text", viewModel, "TotalProducts");
            tbTotalStockValue.DataBindings.Add("Text", viewModel, "TotalStockValue");
            tbTotalPotentialValue.DataBindings.Add("Text", viewModel, "TotalPotentialValue");
        }
    }
}
