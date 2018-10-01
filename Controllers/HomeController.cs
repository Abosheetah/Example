using Microsoft.AspNetCore.Mvc;
namespace EssentialCSharp.Controllers{
    public class HomeController : Controller{
        public ViewResult Index(){
            return View(new string[]{"Mohamed","Salem","Rashaad"});
        }
    }
}