using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatNghe_Day09.Models.Service.Interfaces
{
    public interface IProductsService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product? FindById(int productId);
        IEnumerable<Product> GetAll();
    }
}
