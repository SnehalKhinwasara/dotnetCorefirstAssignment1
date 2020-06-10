using System;
using System.Linq;
using EFCore_App.Models;
namespace EFCore_App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MonitorDb();

                var per = new Person()
                {
                     PersonId = 1001,
                     PersonName = "Mahesh Sabnis",
                     Address = "Bavdhan"
                };

                // set values for the private members by calling the public methods
                per.SetContatcNo(992325);
                per.SetIncome(120000);

                using (var ctx =new PersonDbContext())
                {
                    ctx.Persons.Add(per);
                    ctx.SaveChanges();

                    // read the data
                    foreach (var p in ctx.Persons.ToList())
                    {
                        Console.WriteLine($"{p.PersonId} {p.PersonName} {p.Address} {p.GetContactNo()} {p.GetIncome()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message}");
            }
            Console.ReadLine();
        }

        // helper method to Create a database if it is not created. (Note: You can also delete the already created database)
        static void MonitorDb()
        {
            using (var context = new PersonDbContext())
            {
                context.Database.EnsureDeleted(); // Whole DB Delete
                context.Database.EnsureCreated();
            }
        }
    }
}
