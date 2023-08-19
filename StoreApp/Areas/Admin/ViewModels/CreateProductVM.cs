using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.Areas.Admin.ViewModels
{
    public record CreateProductVM : CreateProductRequest
    {
        [Required(ErrorMessage = "Ürün resmi gereklidir.")]
        public IFormFile? ImageFile { get; set; }

        [Required(ErrorMessage = "Kategori seçimi zorunludur.")]
        public int SelectedCategoryId { get; set; }
        
        public SelectList Categories { get; set; }
    }
}


