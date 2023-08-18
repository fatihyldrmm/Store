using System.ComponentModel.DataAnnotations;
using Entities.Models;

namespace Entities.Dtos
{
    public record UpdateProductSpecs
    {
        public Product Product {get;set;}

        public List<Category> Categories {get;set;}

    }
}