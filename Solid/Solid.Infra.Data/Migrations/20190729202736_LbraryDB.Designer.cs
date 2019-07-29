﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Solid.Infra.Data;
using System;

namespace Solid.Infra.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190729202736_LbraryDB")]
    partial class LbraryDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Solid.Domain.Entity.BookEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("NmBook")
                        .IsRequired();

                    b.Property<decimal>("VrBook");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Solid.Domain.Entity.CategoryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NmCategory")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Solid.Domain.Entity.BookEntity", b =>
                {
                    b.HasOne("Solid.Domain.Entity.CategoryEntity", "Category")
                        .WithMany("LstBook")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}