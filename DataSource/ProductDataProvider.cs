using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class ProductDataProvider
    {
        List<Product> Products = new List<Product>();
        public ProductDataProvider() { }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }


    }
}
