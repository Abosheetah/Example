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
        
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Products = Product.GetProducts();
            decimal decTotalPrice = shoppingCart.GetTotalPrice();
            string res = string.Format($"Total : {decTotalPrice:C2}");

            Product[] productsArr = new Product[] { new Product(){ Name = "koko"  , Price = 25 }, new Product(){Name = "sdf" , Price = 54}};
            decimal decTotalPrice2 = productsArr.GetTotalPrice();
            
            return View("Index",string.Format($"Total 1 : {decTotalPrice}",$"Total 2 : {decTotalPrice2}"));
        }
    }
}