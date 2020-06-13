using NhatNghe_Day09.Models.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatNghe_Day09.Models.Service.Implements
{
    public class BasicProductService : IProductsService
    {
        public static List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int masp)
        {
            var product = products.SingleOrDefault(p => p.ProductID == masp);
                if (product != null)
                {
                    products.Remove(product);
                }
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
