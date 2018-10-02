using System.Collections.Generic;
namespace EssentialCSharp.Models{
    
    public static class MyExtensionMethods{
        public static decimal GetTotalPrice(this ShoppingCart shoppingCart){
            //declare a variable for store total price for collection of products.
            decimal decTotalPrice = 0;
            foreach (Product item in shoppingCart.Products)
            {
                decTotalPrice += item?.Price ?? 0;
            }
            //return total price .
            return decTotalPrice;
        }
    }
   
}