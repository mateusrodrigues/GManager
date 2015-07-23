using GManager.DAL;
using GManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GManager.ViewModels
{
    public class StockViewModel : INotifyPropertyChanged
    {
        private GManagerContext context = new GManagerContext();

        private bool refreshing = false;

        private List<Product> _products;

        public List<Product> Products
        {
            get { RefreshItems(); return _products; }
            set
            {
                _products = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Products"));
            }
        }

        private int _totalProducts;

        public int TotalProducts
        {
            get { RefreshItems(); return _totalProducts; }
            set
            {
                _totalProducts = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TotalProducts"));
            }
        }

        private decimal _totalStockValue;

        public decimal TotalStockValue
        {
            get { RefreshItems(); return _totalStockValue; }
            set
            {
                _totalStockValue = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TotalStockValue"));
            }
        }

        private decimal _totalPotentialValue;

        public decimal TotalPotentialValue
        {
            get { RefreshItems(); return _totalPotentialValue; }
            set
            {
                _totalPotentialValue = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TotalPotentialValue"));
            }
        }
        
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        #endregion
        
        private void RefreshItems()
        {
            if (!refreshing)
            {
                refreshing = true;
                Products = context.Products.OrderBy(m => m.Name).ToList();

                TotalProducts = 0;
                TotalStockValue = 0;
                TotalPotentialValue = 0;
                Products.ForEach(m =>
                {
                    TotalProducts += m.AvailableQuantity;
                    TotalStockValue += m.AvailableQuantity * m.BuyingPrice;
                    TotalPotentialValue += m.AvailableQuantity * m.SellingPrice;
                });
                refreshing = false;
            }
        }

        public int AddProduct(string name, decimal buyingPrice, decimal sellingPrice)
        {
            Product product = new Product()
            {
                Name = name,
                AvailableQuantity = 0,
                SellingPrice = sellingPrice,
                BuyingPrice = buyingPrice
            };
            
            try
            {
                context.Products.Add(product);
                return context.SaveChanges();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Não foi possível adicionar o produto.");
            }
            finally
            {
                RefreshItems();
            }
        }

        public int RemoveProduct(int id)
        {
            try
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                return context.SaveChanges();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Não foi possível remover o produto.");
            }
            finally
            {
                RefreshItems();
            }
        }

        public int EditProduct(Product product)
        {
            try
            {
                context.Entry<Product>(product).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Não foi possível editar o produto.");
            }
            finally
            {
                RefreshItems();
            }
        }
    }
}
