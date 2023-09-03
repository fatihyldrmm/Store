using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;
        public Cart Cart { get; set; } // IoC kaydı yapılmalı. sepetin içinde ne olduğu bilinmiyor.
        public string ReturnUrl { get; set; } = "/";

        public CartModel(IServiceManager manager, Cart cart)
        {
            _manager = manager;
            Cart = cart;
        }

        
        
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/"; //returnUrl null ise ReturnUrl = "/" olur.
        }

        public IActionResult OnPost(int productId, string returnUrl)
        {
            Product? product = _manager
                .ProductService
                .GetOneProduct(productId,false);

            if (product is not null)
            {
                Cart.AddItem(product,1);
            }

            return Page(); // retrunUrl

        }
        public IActionResult OnPostRemove(int id, string retrunUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Product.ProductId.Equals(id)).Product);
            return Page();
        }
    }
}