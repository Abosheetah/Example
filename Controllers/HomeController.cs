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
                decimal? Price = product?.Price ?? 0;
                string RelatedName = product?.Related?.Name ?? "<Not Exist>";
                results.Add(string.Format("Name : {0} , Price : {1} , Related Name : {2}",Name,Price,RelatedName ));
            }
            return View(results);
        }
    }
}