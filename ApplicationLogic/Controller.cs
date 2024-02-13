using DataProviders;
using DataSource;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;

        public static Controller Instance { 
            get { 
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            } 
        }
        private Controller() { }

        public User CurrentUser { get; private set; }

        UserDataProvider userDataProvider = new UserDataProvider();
        ProductDataProvider productDataProvider = new ProductDataProvider();
        ManufacturerDataProvider manufacturerDataProvider = new ManufacturerDataProvider();


        public User LoginUser(User loginUser)
        {
            if (loginUser == null)
            {
                throw new ArgumentNullException();
            }

            List<User> users = userDataProvider.GetUsers();
            foreach (User user in users)
            {
                if(user.Username == loginUser.Username && user.Password == loginUser.Password)
                {
                    CurrentUser = user;
                    return user;
                }
            }

            return null;
        }

        public void AddProduct(Product newProduct)
        {
            productDataProvider.AddProduct(newProduct);
        }

        public void UpdateProduct(Product newProduct)
        {
            productDataProvider.UpdateProduct(newProduct);
        }

        public void AddMultipleProduct(List<Product> products)
        {
            productDataProvider.AddMultipleProduct(products);
        }

        public List<Manufacturer> GetManufactures()
        {
            return manufacturerDataProvider.GetManufacturers();
        }

        public List<Product> GetAllProducts()
        {
            return productDataProvider.GetAllProducts();
        }

        public Array GetMeasurementUnits()
        {
            return Enum.GetValues(typeof(MeasurementUnit));
        }

    }
}
