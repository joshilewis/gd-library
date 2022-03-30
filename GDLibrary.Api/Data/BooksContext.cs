using GDLibrary.Api.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace GDLibrary.Api.Data
{
    public class BooksContext: DbContext
    {
        protected BooksContext()
        {
        }

        public BooksContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Book>().HasData(new []
            {
                new Book(1, "Book Title 1"),
                new Book(2, "Book Title 2"),
                new Book(3, "Book Title 3"),
                new Book(4, "Book Title 4"),
            });
        }

    }
}
