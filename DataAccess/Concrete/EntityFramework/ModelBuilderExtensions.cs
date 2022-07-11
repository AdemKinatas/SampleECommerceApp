using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Laptop",
                },
                new Category
                {
                    Id = 2,
                    Name = "Cep Telefonu",
                },
                new Category
                {
                    Id = 3,
                    Name = "Tablet",
                },
                new Category
                {
                    Id = 4,
                    Name = "Kulaklık",
                }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Msi Laptop",
                    UnitPrice = 20000,
                    CategoryId = 1,
                    UnitsInStock = 50,

                },
                new Product
                {
                    Id = 2,
                    ProductName = "Asus Laptop",
                    UnitPrice = 15000,
                    CategoryId = 1,
                    UnitsInStock = 45,

                }, new Product
                {
                    Id = 3,
                    ProductName = "Oppo Cep Telefonu",
                    UnitPrice = 5200,
                    CategoryId = 2,
                    UnitsInStock = 32,

                }, new Product
                {
                    Id = 4,
                    ProductName = "IPhone 13 Pro",
                    UnitPrice = 21000,
                    CategoryId = 2,
                    UnitsInStock = 12,

                }, new Product
                {
                    Id = 5,
                    ProductName = "IPhone 11",
                    UnitPrice = 14000,
                    CategoryId = 2,
                    UnitsInStock = 8,

                }, new Product
                {
                    Id = 6,
                    ProductName = "Huawei Tablet",
                    UnitPrice = 3500,
                    CategoryId = 3,
                    UnitsInStock = 11,

                }
                );         
        }
    }
}
