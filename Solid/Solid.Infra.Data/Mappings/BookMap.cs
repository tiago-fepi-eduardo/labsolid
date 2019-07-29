using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Infra.Data.Mappings
{
    public class BookMap : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(c => c.ID);

            builder.Property(c => c.VrBook);

            builder.Property(c => c.CategoryId)
                .IsRequired();

            builder.Property(c => c.NmBook)
                .IsRequired();
            
        }
    }
}
