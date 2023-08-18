using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        private readonly IMapper _mapper;
        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDtoForInsertion productDto)
        {
            Category category = _manager.Category.FindAll(false).First(c => c.CategoryId == productDto.CategoryId);

            ProductDtoForInsertion r = productDto; //constructor daha kısa olsun diye
            Product product2 = new Product(r.ProductName, r.Price, r.Summary, r.ImageUrl, category);

            Product product = _mapper.Map<Product>(productDto);
            _manager.Product.Create(product);
            _manager.Save();
        }

        public void DeleteOneProduct(int id)
        {
            var product = GetOneProduct(id, false);
            if (product is not null)
            {
                _manager.Product.DeleteOneProduct(product);
                _manager.Save();
            }
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _manager.Product.GetOneProduct(id, trackChanges);
            if (product is null)
                throw new Exception("Product not found!");
            return product;
        }

        public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
        {
            var product = GetOneProduct(id, trackChanges);
            var productDto = _mapper.Map<ProductDtoForUpdate>(product);
            return productDto;
        }

        public void UpdateOneProduct(ProductDtoForUpdate productDto)
        {
            try
            {
                var entity = _mapper.Map<Product>(productDto);
                _manager.Product.UpdateOneProduct(entity);
                _manager.Save();
            }
            catch (Exception e)
            {

                //var response = new UpdateProductResponse(false, e.Message);
            }
            // var entity = _manager.Product.GetOneProduct(productDto.ProductId, true);
            // entity.ProductName = productDto.ProductName;
            // entity.Price = productDto.Price;
            // entity.CategoryId = productDto.CategoryId;

        }

        public void UpdateProduct(UpdateProductRequest request)
        {
            var product = GetOneProduct(request.ProductId, true);

            Category category = _manager.Category.FindAll(false).First(c => c.CategoryId == request.CategoryId);


            product.Update(request.ProductName, request.Price, request.Summary, request.ImageUrl, category);

            _manager.Product.UpdateOneProduct(product);
            _manager.Save();
        }

        public UpdateProductSpecs GetUpdateProductSpecs(int id){
            
            var product = GetOneProduct(id, false);
            var categories = _manager.Category.FindAll(false).ToList();

            UpdateProductSpecs specs = new UpdateProductSpecs{Product = product, Categories = categories};

            return specs;
        }
    }
}