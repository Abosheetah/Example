
namespace EssentialCSharp.Models{
    public class Product{
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public static Product[] GetProducts(){
            
            Product AllVit = new Product(){Name ="AllVit",Price = 520};
            Product Phose = new Product(){Name = "Phose" , Price = 90};
            Product MycoB = new Product() { Name="MycoB" ,Price = 495};
            
            return new Product[]{AllVit,Phose,MycoB,null};
        }

    }
}