using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }

    public String? ProductName { get; set; } = String.Empty;

    public decimal Price { get; set; }

    public String? Summary { get; set; } = String.Empty;

    public String? ImageUrl { get; set; }

    public int? CategoryId { get; set; } // Foreign Key

    public Category? Category { get; set; } // Navigation Property

    public bool ShowCase { get; set; }
    public Product() { }


    public Product(string? name, decimal price, string? summary, string? imageUrl, int categoryId)
    {
        ProductName = name;

        if (string.IsNullOrEmpty(ProductName) || string.IsNullOrWhiteSpace(ProductName))
            throw new Exception("Lütfen ürün ismini giriniz");

        ProductName = ProductName.Trim();

        if (ProductName.Length > 100)
            throw new Exception("Ürün ismi 100 karakterden uzun olamaz.");

        Price = price;

        if (Price <= 0)
            throw new Exception("Ürün fiyatı 0 ve 0'dan küçük olamaz.");

        Summary = summary;
        ImageUrl = imageUrl;
        CategoryId = categoryId;
    }

    public Product(string? name, decimal price, string? summary, string? imageUrl, Category category)
    {
        ProductName = name;

        if (string.IsNullOrEmpty(ProductName) || string.IsNullOrWhiteSpace(ProductName))
            throw new Exception("Lütfen ürün ismini giriniz");

        ProductName = ProductName.Trim();

        if (ProductName.Length > 100)
            throw new Exception("Ürün ismi 100 karakterden uzun olamaz.");

        Price = price;

        if (Price <= 0)
            throw new Exception("Ürün fiyatı 0 ve 0'dan küçük olamaz.");

        Summary = summary;
        ImageUrl = imageUrl;
        CategoryId = category.CategoryId;
        Category = category;
    }


    public void Update(string? name, decimal price, string? summary, string? imageUrl, Category category)
    {
        ProductName = name;

        if (string.IsNullOrEmpty(ProductName) || string.IsNullOrWhiteSpace(ProductName))
            throw new Exception("Lütfen ürün ismini giriniz");

        ProductName = ProductName.Trim();

        if (ProductName.Length > 100)
            throw new Exception("Ürün ismi 100 karakterden uzun olamaz.");

        Price = price;

        if (Price <= 0)
            throw new Exception("Ürün fiyatı 0 ve 0'dan küçük olamaz.");

        Summary = summary;

        if (!string.IsNullOrEmpty(imageUrl))
            ImageUrl = imageUrl;

        CategoryId = category.CategoryId;
        Category = category;
    }
    public void Create(string? name, decimal price, string? summary, string? imageUrl, Category category)
    {
        ProductName = name;

        if (string.IsNullOrEmpty(ProductName) || string.IsNullOrWhiteSpace(ProductName))
            throw new Exception("Lütfen ürün ismini giriniz");

        ProductName = ProductName.Trim();

        if (ProductName.Length > 100)
            throw new Exception("Ürün ismi 100 karakterden uzun olamaz.");

        Price = price;

        if (Price <= 0)
            throw new Exception("Ürün fiyatı 0 ve 0'dan küçük olamaz.");

        Summary = summary;

        if (!string.IsNullOrEmpty(imageUrl))
            ImageUrl = imageUrl;

        CategoryId = category.CategoryId;
        Category = category;
    }


}