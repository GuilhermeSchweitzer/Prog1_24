namespace _240401_01.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public bool Validate()
        {
            return true;
        }

        public OrderItem orderitem()
        {
            return new OrderItem();
        }

        public void Save(OrderItem orderitem)
        {
            
        }
    }
}