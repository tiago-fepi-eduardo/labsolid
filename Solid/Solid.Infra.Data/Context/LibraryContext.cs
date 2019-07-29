using Microsoft.EntityFrameworkCore;
using Solid.Domain.Entity;
using Solid.Infra.Data.Mappings;

namespace Solid.Infra.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
            //Nothing
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<BookEntity> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CategoryEntity>(new CategoryMap().Configure);
            modelBuilder.Entity<BookEntity>(new BookMap().Configure);
            base.OnModelCreating(modelBuilder);


        }
    }
}
