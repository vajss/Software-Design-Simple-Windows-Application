using DataProviders;
using DataSource;
using DataSource.DatabaseRepository;
using Domain;
using System;
using System.Collections.Generic;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        private static object syncRoot = new object();

        public static Controller Instance { 
            get
            {
                if (instance == null)
                {
                    lock (syncRoot) // https://stackoverflow.com/questions/12316406/thread-safe-c-sharp-singleton-pattern
                    {
                        if (instance == null)
                            instance = new Controller();
                    }
                }

                return instance;
            }
        }
        private Controller() { }

        public User CurrentUser { get; set; }

        UserDataProvider userDataProvider = new UserDataProvider();
        ProductDataProvider productDataProvider = new ProductDataProvider();
        ManufacturerDataProvider manufacturerDataProvider = new ManufacturerDataProvider();
        IRepository<Invoice> invoiceDataProvider = new InvoiceDataProvider();

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
                    Console.WriteLine(user.Name + " " + user.Password);
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

        public void SaveInvoice(Invoice invoice)
        {
            invoiceDataProvider.Save(invoice);
        }
    }
}
