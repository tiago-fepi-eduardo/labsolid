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

            builder.HasKey(c => c.Id);

            builder.Property(c => c.IdCategory)
                .IsRequired()
                .HasColumnName("Category");

            builder.Property(c => c.NmBook)
                .IsRequired()
                .HasColumnName("Book");

            builder.Property(c => c.VrBook)
                .HasColumnName("Price");
        }
    }
}
