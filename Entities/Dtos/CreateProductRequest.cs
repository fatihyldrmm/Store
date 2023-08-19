using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record CreateProductRequest
    {
        public int ProductId { get; init; }

        public string ProductName { get; init; } = String.Empty;
        public decimal Price { get; init; }

        public string? Summary { get; init; } = String.Empty;

        public string? ImageUrl { get; set; }

        public int? CategoryId { get; init; }

    }
}