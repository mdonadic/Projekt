using System.Collections.Generic;
using System.Data.Entity;

namespace PinWebForms.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Lopte bez reketa"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Lopte za reket"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Nogometna lopta",
                    Description = "Nogometna lopta je rekvizit za nogometnu igru. Sferični oblik lopte, kao i njena veličina, težina i sastav"+
                                "određeni su u drugom zakonu nogometnih pravila koji je donio Međunarodni odbor nogometnih saveza.",
                    ImagePath ="nogometna.jpg",
                    UnitPrice = 250,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Košarkaška lopta",
                    Description = "Košarkaška lopta je lopta za igranje košarke. Vanjska površina lopte napravljena je od prirodne ili vještačke kože, a može biti i od gume." + 
                                 "Površina lopte ne sadrži toksične ili bilo koje druge materijale koji mogu prouzrokovati alergiju.",
                    ImagePath="K.jfif",
                    UnitPrice = 300,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Teniska lopta",
                    Description = "teniske lopte izvorno su bile crne ili bijele," +
                                    "a boja pozadine terena diktirala je koja je lopta bila praktičnija za upotrebu.",
                    ImagePath= "TeniskaLoptica.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Ping-Pong loptica",
                    Description = "To je loptica namjenjena za igranje stolnog tenisa. Njezin promjer je 40 mm i teška 2,7 grama.",
                    ImagePath= "ping-pong.jfif",
                    UnitPrice = 50,
                    CategoryID = 2
                },
            };

            return products;
        }
    }
}