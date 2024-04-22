namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set;}
        public string EmailAddress { get; set;}
        public List<Address> Addresses { get; set; }
        public Customer()
        {
            
        }
        public Customer(int id)
        {
            CustomerID = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public void Save(Customer customer)
        {

        }
    }
}