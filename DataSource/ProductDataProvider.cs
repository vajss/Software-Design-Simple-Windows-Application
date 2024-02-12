using DatabaseBroker;
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
        public ProductDataProvider() { }

        public List<Product> GetAllProducts()
        {
            Broker broker = new Broker();
            broker.OpenConnection();

            try {
                return broker.GetAllProducts(); 
            } 
            finally {
                broker.CloseConnection();
            }

        }

        public void AddProduct(Product newProduct)
        {
            //Products.Add(newProduct);
        }


    }
}
