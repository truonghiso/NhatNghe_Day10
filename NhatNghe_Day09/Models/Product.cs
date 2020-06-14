using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatNghe_Day09.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Quantity { get; set; }
    }
}
