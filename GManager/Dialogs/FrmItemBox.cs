using GManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GManager.Dialogs
{
    public partial class FrmItemBox : Form
    {
        public Product Product { get; set; }

        public enum ItemOperation
        {
            Add,
            Edit
        }

        public FrmItemBox(ItemOperation operation, Product product = null)
        {
            InitializeComponent();

            Product = product;
            if (operation == ItemOperation.Add)
            {
                Product = new Product();
            }
            else
            {
                if (Product == null)
                {
                    throw new ApplicationException("Produto não pode ser nulo em modo de edição.");
                }
                this.Text = "Editar Item";
            }
            this.tbName.DataBindings.Add("Text", this.Product, "Name");
            this.tbBuyingPrice.DataBindings.Add("Text", this.Product, "BuyingPrice");
            this.tbSellingPrice.DataBindings.Add("Text", this.Product, "SellingPrice");
            btnConfirm.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void setValidationError(Control sender, CancelEventArgs e, string message)
        {
            string error = null;
            if (sender.Text.Length == 0)
            {
                error = message;
                e.Cancel = true;
            }
            else if (sender.Name.Equals("tbBuyingPrice") || sender.Name.Equals("tbSellingPrice"))
            {
                try
                {
                    decimal.Parse(sender.Text);
                }
                catch (FormatException)
                {
                    error = "Digite um valor válido.";
                    e.Cancel = true;
                }
            }
            errorProvider.SetError((Control)sender, error);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            setValidationError((Control)sender, e, "Digite um nome para o produto.");
        }

        private void tbBuyingPrice_Validating(object sender, CancelEventArgs e)
        {
            setValidationError((Control)sender, e, "Digite um valor de compra para o produto.");
        }

        private void tbSellingPrice_Validating(object sender, CancelEventArgs e)
        {
            setValidationError((Control)sender, e, "Digite um valor de venda para o produto.");
        }
    }
}
