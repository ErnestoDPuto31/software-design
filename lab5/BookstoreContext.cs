using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab5
{
    public class BookstoreContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Book> Books { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Author>? Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}
