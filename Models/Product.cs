
namespace EssentialCSharp.Models{
    public class Product{
        public string Name { get; set; }
        public Category Category { get; set; }  = Category.Antiputic;
        public decimal? Price { get; set; }
        public Product Related{get;set;}
        public bool InStock {get;}

        public Product(bool stock = true){
            InStock = stock;
        }
        public static Product[] GetProducts(){
            
            Product AllVit = new Product(){Name ="AllVit",Price = 520,Category = Category.Vitamin};
            Product Phose = new Product(){Name = "Phose" , Price = 90,Related = AllVit};
            Product MycoB = new Product(){ Name="MycoB" ,Price = 495,Related = Phose,Category= Category.Antiputic};
            Product VitE = new Product(){ Name="VitE",Related = MycoB};
            Product Curasoul = new Product(false){ Name = "Curasoul" , Price = 365 , Related = MycoB ,Category = Category.Phose };
            return new Product[]{AllVit,Phose,MycoB,VitE,null};
        }

    }
    
    //this enumerator for select one category for every product.
    public enum Category{
        Vitamin = 0,
        Antiputic =1,
        Phose = 2
    }
}
