namespace _240401_01.Controllers;
using _240401_01.Models;
using _240401_01.Repository;


    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }
        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }
        public Customer Get(int id)
        {
            return customerRepository.Retrieve(id);
        }
        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }
    }
