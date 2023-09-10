using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/laptop.jpeg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/keyboard.jpeg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/mouse.jpeg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/monitor.jpeg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/default.jpeg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/historybook.jpeg", ProductName = "History", Price = 25, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/hamlet.jpeg", ProductName = "Hamlet", Price = 45, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/hamlet.jpeg", ProductName = "Xp-Pen", Price = 1145, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 2, ImageUrl = "/images/hamlet.jpeg", ProductName = "Galaxy Fun Edition", Price = 4445, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl = "/images/hamlet.jpeg", ProductName = "Hp Mouse", Price = 545, ShowCase = true }
            );
        }
    }
}