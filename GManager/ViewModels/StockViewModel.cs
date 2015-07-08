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
    }
}
