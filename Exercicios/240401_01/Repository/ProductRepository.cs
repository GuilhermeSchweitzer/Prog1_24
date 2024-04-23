using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            DataSet.Products.Add(product);
        }
        public Product Retrieve(int id)
        {
            foreach(var p in DataSet.Products)
            {
                if( p.ProductID == id)
                    return p;
            }
            return null;
        }
    }
}