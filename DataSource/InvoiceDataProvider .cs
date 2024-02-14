using DatabaseBroker;
using DataSource.DatabaseRepository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class InvoiceDataProvider : IRepository<Invoice>
    {
        Broker broker = new Broker();
        public void Delete(Invoice obj)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Invoice invoice)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                int inoiceId = broker.AddInvoice(invoice); // TODO return id???

                foreach (InvoiceItem invoiceItem in invoice.InvoiceItems)
                {
                    invoiceItem.InvoiceId = inoiceId;
                    broker.AddInvoiceItem(invoiceItem);
                }

                broker.Commit();
            }
            catch (Exception error)
            {
                broker.Rollback();
                Console.WriteLine($">>>> saving invoice error: {error.Message}");
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Invoice> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice obj)
        {
            throw new NotImplementedException();
        }
    }
}
