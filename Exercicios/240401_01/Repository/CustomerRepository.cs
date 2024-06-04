using _240401_01.Models;
using _240401_01.Data;
using _240401_01.Utils;
using _240401_01.Controllers;
using _240401_01.Views;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            DataSet.Customers.Add(customer);
        }
         public void Save(Customer customer, bool autoGenerateId)
        {
            if(autoGenerateId)
                customer.CustomerID = this.GetNextId();

            DataSet.Customers.Add(customer);
        }
        public Customer Retrieve(int id)
        {
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerID == id)
                    return c;
            }
            return null;
        }

        public List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }

        public List<Customer> RetrieveByName(string name)
        {
            List<Customer> retorno = new List<Customer>();
            foreach(var c in DataSet.Customers)
            {
                if(c.Name.Contains(name))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }

        public bool ImportFromTxt(string line, string delimiter)
        {
            if(string.IsNullOrWhiteSpace(line))
                return false;
            string[] data = line.Split(delimiter);

            if(data.Count() < 1)
                return false;

            Customer c = new Customer{
                CustomerID = Convert.ToInt32(data[0] == null ? string.Empty : data[0]),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = (data[2] == null ? string.Empty : data[2])
            };

            Save(c, false);

            return true;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerID > n)
                    n = c.CustomerID;
            }

            return ++n;
        }
    }
}