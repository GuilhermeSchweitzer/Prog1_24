namespace _240401_01.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set;}
        public string Description { get; set;}
        public string WorkAddress { get; set;}
        public bool Validate()
        {
            return true;
        }

        public Product Retrieve()
        {
            return new Product();
        }

        public void Save(Product product)
        {
            
        }
    }
}