using System.Collections.Generic;
namespace EssentialCSharp.Models{
    
    public static class MyExtensionMethods{
        public static decimal GetTotalPrice(this IEnumerable<Product> products){
            //declare a variable for store total price for collection of products.
            decimal decTotalPrice = 0;
            foreach (Product item in products)
            {
                decTotalPrice += item?.Price ?? 0;
            }
            //return total price .
            return decTotalPrice;
        }
       
    }
   
}