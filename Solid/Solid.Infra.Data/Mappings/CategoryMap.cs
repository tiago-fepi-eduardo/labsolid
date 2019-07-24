using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Infra.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NmCategory)
                .IsRequired()
                .HasColumnName("Category");
        }
    }
}
