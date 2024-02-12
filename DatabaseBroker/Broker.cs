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
                "SELECT * FROM products p " +
                "JOIN manufacturers m ON p.ManufacturerId = m.id";
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
                        DateCreated = DateTimeOffset.FromUnixTimeSeconds(reader.GetInt32(6)).LocalDateTime,
                    };


                    Manufacturer manufacturer = new Manufacturer()
                    {
                        Id = reader.GetInt32(7),
                        Name = reader.GetString(8),
                    };

                    product.Manufacturer = manufacturer;
                    products.Add(product);
                }
            }
            return products;
        }

        public int AddProduct(Product product)
        {
            string query =
                "INSERT INTO products " +
                $"VALUES(@pId, @pName ,@pDesc, @pPrice, @pUnit, @pManufacturerId, @pDateCreated)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@pId", product.Id);
            command.Parameters.AddWithValue("@pName", product.Name);
            command.Parameters.AddWithValue("@pDesc", product.Description);
            command.Parameters.AddWithValue("@pPrice", product.Price);
            command.Parameters.AddWithValue("@pUnit", (int)product.MeasurementUnit);
            command.Parameters.AddWithValue("@pManufacturerId", product.Manufacturer.Id);
            command.Parameters.AddWithValue("@pDateCreated", ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds());

            int rowsAdded = command.ExecuteNonQuery();
            return rowsAdded;
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            string query = "SELECT * FROM manufacturers";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Manufacturer manufacturer = new Manufacturer()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    };
                    manufacturers.Add(manufacturer);
                }
            }
            return manufacturers;
        }
    }
}
