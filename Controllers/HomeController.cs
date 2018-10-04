using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EssentialCSharp.Models;

namespace EssentialCSharp.Controllers{
    public class HomeController : Controller{
        public ViewResult Index(){
           List<string> results = new List<string>();
            foreach (Product product in Product.GetProducts())
            {
                string Name = product?.Name ?? "<No Name>";
                string Category = product?.Category.ToString() ;
                decimal? Price = product?.Price ?? 0;
                string RelatedName = product?.Related?.Name ?? "<Not Exist>";
                bool? inStock = product?.InStock ?? false;
                results.Add(string.Format($"Name : {Name} , Category : {Category} , Price : {Price} , Related Name : {RelatedName} , In Stock : {inStock}"));
            }
        
            //filter by price
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Products = Product.GetProducts();
            decimal decTotalPrice = shoppingCart.FilterByPrice(50).GetTotalPrice();
            string res = string.Format($"Total : {decTotalPrice:C2}");

            //filter by first letter in name.
            ShoppingCart shoppingCart1 = new ShoppingCart();
            shoppingCart1.Products = Product.GetProducts();
            decimal decTotalPrice1 = shoppingCart.FilterByName('s').FilterByPrice(200).GetTotalPrice();

            //the reguler position.
            Product[] productsArr = new Product[] { new Product(){ Name = "koko"  , Price = 25 }, new Product(){Name = "sdf" , Price = 54}};
            decimal decTotalPrice2 = productsArr.GetTotalPrice();
            
            return View("Index",string.Format($"Total 1 : {decTotalPrice}",$"Total 2 : {decTotalPrice2}"));
            
            decimal decTotalFilterPrice = shoppingCart1.Filter(i => (i?.Price ?? 0) > 20).GetTotalPrice();
        }
    }
}