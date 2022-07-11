﻿// <auto-generated />
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ECommerceDbContext))]
    partial class ECommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cep Telefonu"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tablet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kulaklık"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductName = "Msi Laptop",
                            UnitPrice = 20000m,
                            UnitsInStock = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ProductName = "Asus Laptop",
                            UnitPrice = 15000m,
                            UnitsInStock = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ProductName = "Oppo Cep Telefonu",
                            UnitPrice = 5200m,
                            UnitsInStock = 32
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ProductName = "IPhone 13 Pro",
                            UnitPrice = 21000m,
                            UnitsInStock = 12
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ProductName = "IPhone 11",
                            UnitPrice = 14000m,
                            UnitsInStock = 8
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ProductName = "Huawei Tablet",
                            UnitPrice = 3500m,
                            UnitsInStock = 11
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}