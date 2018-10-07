using System.Collections;
using System.Collections.Generic;
namespace EssentialCSharp.Models{
    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products{set;get;}

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Products.GetEnumerator();

            
        }
    }
}