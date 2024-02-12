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
        private List<Manufacturer> manufacturers = new List<Manufacturer>
        {
            new Manufacturer{ Name = "Delhaize", Id = 1},
            new Manufacturer{ Name = "Delta", Id = 2},
            new Manufacturer{ Name = "Mercedes", Id = 3},

        };

        public List<Manufacturer> GetManufacturers()
        {
            return manufacturers;
        }
    }
}
