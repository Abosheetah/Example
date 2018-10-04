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
       public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> products,decimal minimumPrice){
           foreach (Product item in products)
           {
               if ((item?.Price ?? 0) > minimumPrice)
               {
                   yield return item;
               }
           }
       }  

       public static IEnumerable<Product> FilterByName(this IEnumerable<Product> products ,char firstLetter){
           foreach (Product item in products)
           {
               if (item?.Name[0] == firstLetter)
               {
                   yield return item;
               }
           }
       }     
    }
   
}