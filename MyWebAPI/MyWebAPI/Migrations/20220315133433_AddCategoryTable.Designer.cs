﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebAPI.Data;

namespace MyWebAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220315133433_AddCategoryTable")]
    partial class AddCategoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebAPI.Data.CategoryEntity", b =>
                {
                    b.Property<int>("CategoryCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryCode");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MyWebAPI.Data.ProductEntity", b =>
                {
                    b.Property<Guid>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CategoryCode")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<byte>("Promotion")
                        .HasColumnType("tinyint");

                    b.HasKey("Code");

                    b.HasIndex("CategoryCode");

                    b.ToTable("ProductTable");
                });

            modelBuilder.Entity("MyWebAPI.Data.ProductEntity", b =>
                {
                    b.HasOne("MyWebAPI.Data.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryCode");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MyWebAPI.Data.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
