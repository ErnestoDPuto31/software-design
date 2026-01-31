using Microsoft.EntityFrameworkCore;

namespace Lab7
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(a => a.AuthorId);
            modelBuilder.Entity<Book>().HasKey(b => b.BookId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}