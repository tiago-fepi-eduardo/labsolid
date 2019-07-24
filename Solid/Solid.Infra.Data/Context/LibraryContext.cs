using Microsoft. EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Solid.Domain.Entity;
using Solid.Infra.Data.Mappings;

namespace Solid.Infra.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            //Nothing
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>(new CategoryMap().Configure);
            modelBuilder.Entity<BookEntity>(new BookMap().Configure);
        }

        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<BookEntity> Book { get; set; }
    }
}
