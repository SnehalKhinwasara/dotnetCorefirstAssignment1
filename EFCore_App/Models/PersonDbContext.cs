using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_App.Models
{
    /// <summary>
    /// 1. DbContext --> Manage DbConnection and Db Transaction
    /// 2. Manage Mapping between CLR Objects and Db Tables
    /// 3. Manages the Cursor in Applicaiton Server that is used
    /// for performing CRUD operations using DbSet<T>
    /// DbSet<T> --> T is the CLR class that is mapped with table of name
    /// T
    /// </summary>
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MVAORKB;Initial Catalog=VodafoneDb; Integrated Security=SSPI");
        }

        /// <summary>
        /// Set the mapping  of Private member of the class to the Table Column using 
        /// public Property name e.g. _ContatNo will be mapped to ContactNo
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // define the mapping of private members of the Person Class with the table
            modelBuilder.Entity<Person>().Property<int>("ContactNo").HasField("ContactNo");
            modelBuilder.Entity<Person>().Property<int>("Income").HasField("Income");

        }
    }
}
