using _240401_01.Models;

namespace _240401_01.Data
{
    public static class DataSet
    {
        public static List<Address> Addresses { get; set; }
            = new List<Address>();
        public static List<Customer> Customers { get; set; }
            = new List<Customer>();
        public static List<Product> Products { get; set; }
            = new List<Product>();
    }
}