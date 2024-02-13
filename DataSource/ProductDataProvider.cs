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
        Broker broker = new Broker();
        public ProductDataProvider() { }

        public List<Product> GetAllProducts()
        {
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
            broker.OpenConnection();

            try
            {
                broker.AddProduct(newProduct);
            }
            finally 
            {
                broker.CloseConnection();
            }
        }

        public void AddMultipleProduct(List<Product> products)
        {
            broker.OpenConnection();
            broker.BeginTransaction();
            try
            {
                foreach (Product product in products)
                {
                    broker.AddProduct(product);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void UpdateProduct(Product newProduct)
        {
            broker.OpenConnection();

            try
            {
                broker.UpdateProduct(newProduct);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
