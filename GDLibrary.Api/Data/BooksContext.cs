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
                new Book {Id = 1, Title = "Book Title 1"},
                new Book {Id = 2, Title = "Book Title 2"},
                new Book {Id = 3, Title = "Book Title 3"},
                new Book {Id = 4, Title = "Book Title 4"},
            });
        }

    }
}
