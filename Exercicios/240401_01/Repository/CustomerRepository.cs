using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
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