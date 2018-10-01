
namespace EssentialCSharp.Models{
    public class Product{
        public string Name { get; set; }
        public string Category { get; set; } = "";
        public decimal? Price { get; set; }
        public Product Related{get;set;}
        public static Product[] GetProducts(){
            
            Product AllVit = new Product(){Name ="AllVit",Price = 520};
            Product Phose = new Product(){Name = "Phose" , Price = 90,Related = AllVit};
            Product MycoB = new Product(){ Name="MycoB" ,Price = 495,Related = Phose};
            Product VitE = new Product(){ Name="VitE",Related = MycoB};
            return new Product[]{AllVit,Phose,MycoB,VitE,null};
        }

    }
}