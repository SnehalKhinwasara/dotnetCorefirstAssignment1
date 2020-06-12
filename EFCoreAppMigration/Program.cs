using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreAppMigration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var ctx = new CatPrdDbContext();
                #region Commented
                //var cat = new Category()
                //{ 
                //    CategoryId = "Cat0001",
                //    CategoryName = "Electronics",
                //    BasePrice = 12000
                //};

                //ctx.Categories.Add(cat);

                //var prd = new Product() 
                //{
                //   ProductId = "Prd0001",
                //   ProductName = "Laptop",
                //   Manufacturer = "IBM",
                //   Description = "Gaming",
                //   Price = 340000,
                //   CategoryRowId = 1
                //};

                //ctx.Products.Add(prd);
                //ctx.SaveChanges(); 
                #endregion


                var obj = new DalLayer();
                /* var cat = new Category()
                 {
                      CategoryId = "Cat0003",BasePrice=20
                 };
                 cat = await obj.CreateAsync(cat);
                 Console.WriteLine(JsonSerializer.Serialize(cat));
                 Console.ReadLine();
                */

                /* var cats = await obj.GetAsync();
                 Console.WriteLine(JsonSerializer.Serialize(cats));

                 bool inserted = false;
                 List<Category> lstCategory = new List<Category>();
                 lstCategory.Add(new Category { CategoryId = "Cat0001", BasePrice = 20, CategoryName="A" });
                 lstCategory.Add(new Category { CategoryId = "Cat0002", BasePrice = 50, CategoryName = "B" });
                 lstCategory.Add(new Category { CategoryId = "Cat0003", BasePrice = 40, CategoryName = "C" });
                 lstCategory.Add(new Category { CategoryId = "Cat0004", BasePrice = 40, CategoryName = "D" });
                 lstCategory.Add(new Category { CategoryId = "Cat0005", BasePrice = 40, CategoryName = "E" });
                 inserted = await obj.CreateBulkCategoryAsync(lstCategory);
                if(inserted)
                 Console.WriteLine("inserted Categories");
                 Console.ReadLine();
                 */
                bool inserted = false;
                List<Product> lstProduct = new List<Product>();
                lstProduct.Add(new Product { ProductId= "Prod0001", CategoryRowId=2, ProductName="A1", Price=100, Description= "A1", Manufacturer="AA" });
                lstProduct.Add(new Product { ProductId = "Prod0002", CategoryRowId = 2, ProductName = "A2", Price = 100, Description = "A2", Manufacturer = "AA" });
                lstProduct.Add( new Product { ProductId = "Prod0003", CategoryRowId = 3, ProductName = "B1", Price = 80, Description = "B1", Manufacturer = "BB" });
                lstProduct.Add(new Product { ProductId = "Prod0004", CategoryRowId = 3, ProductName = "B2", Price = 10, Description = "B2", Manufacturer = "BB" });
                lstProduct.Add(new Product { ProductId = "Prod0005", CategoryRowId = 4, ProductName = "C1", Price = 60, Description = "C1", Manufacturer = "CC" });
                inserted = await obj.CreateBulkProductAsync(lstProduct);
                if (inserted)
                    Console.WriteLine("inserted Products");
                Console.ReadLine();
                lstProduct = await obj.GetProductListByCategoryNameAsync("A");
                foreach (var p in lstProduct)
                {
                    Console.WriteLine($"{p.ProductId} {p.ProductName} {p.Price} {p.Manufacturer} {p.Description}");
                    Console.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message} {ex.InnerException}");
            }
            Console.ReadLine();
        }
    }
}
