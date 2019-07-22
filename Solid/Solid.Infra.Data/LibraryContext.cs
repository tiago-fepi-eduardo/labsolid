using Microsoft.EntityFrameworkCore;
using Solid.Domain.Entity;

namespace Solid.Infra.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            //Nothing
        }

        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<BookEntity> Book { get; set; }
    }
}
