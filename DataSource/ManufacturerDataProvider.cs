using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class ManufacturerDataProvider
    {

        public List<Manufacturer> GetManufacturers()
        {
            Broker broker = new Broker();
            try
			{
                broker.OpenConnection();
                return broker.GetAllManufacturers();
			}
			finally
			{
                broker.CloseConnection();
			}
        }
    }
}
