using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=Ericsouza.123;Persist Security Info=True;User ID=rafael;Initial Catalog=booklistmvc;Data Source=rafaelmb.database.windows.net");

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        
    }
}
