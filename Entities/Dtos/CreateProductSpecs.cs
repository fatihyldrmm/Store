using System.ComponentModel.DataAnnotations;
using Entities.Models;

namespace Entities.Dtos
{
    public record CreateProductSpecs
    {
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }

    }
}