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
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/laptop.jpeg", ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/keyboard.jpeg", ProductName = "Keyboard", Price = 1_000 },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/mouse.jpeg", ProductName = "Mouse", Price = 500 },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/monitor.jpeg", ProductName = "Monitor", Price = 7_000 },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/default.jpeg", ProductName = "Deck", Price = 1_500 },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/historybook.jpeg", ProductName = "History", Price = 25 },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/hamlet.jpeg", ProductName = "Hamlet", Price = 45 }
            );
        }
    }
}