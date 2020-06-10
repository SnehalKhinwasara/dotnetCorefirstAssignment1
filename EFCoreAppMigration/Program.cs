using System;
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
                var cat = new Category()
                {
                     CategoryId = "Cat0003",BasePrice=20
                };
                cat = await obj.CreateAsync(cat);
                Console.WriteLine(JsonSerializer.Serialize(cat));
                Console.ReadLine();

                var cats = await obj.GetAsync();
                Console.WriteLine(JsonSerializer.Serialize(cats));


            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message} {ex.InnerException}");
            }
            Console.ReadLine();
        }
    }
}
