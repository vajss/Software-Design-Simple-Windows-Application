using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        SqlConnection connection;


        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D1;Integrated Security=True;Connect Timeout=30;");
        }

        public void OpenConnection()
        {
            connection?.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string query =
                "SELECT * FROM product p " +
                "JOIN Manufacturer m ON p.ManufacturerId = m.id";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        Id = reader.GetInt32(0), // alt solution, better in general is to have named columnds with 'as' in query
                        Name = reader.GetString(1),
                        Description = reader.GetString(2),
                        Price = reader.GetDouble(3),
                        MeasurementUnit = (MeasurementUnit)reader.GetInt32(4),
                    };
                    Manufacturer manufacturer = new Manufacturer()
                    {
                        Id = reader.GetInt32(5),
                        Name = reader.GetString(7),
                    };
                    product.Manufacturer = manufacturer;
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
