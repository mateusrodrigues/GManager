using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GManager.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int AvailableQuantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal BuyingPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal SellingPrice { get; set; }
    }
}
