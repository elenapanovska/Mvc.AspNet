using Class04.AspNet.Homework.Refactored.Business.Interfaces;
using Class04.AspNet.Homework.Refactored.Business.ViewModels;
using Class04.AspNet.Homework.Refactored.Data.DomainModels;
using Class04.AspNet.Homework.Refactored.Data.Interfaces;
using Class04.AspNet.Homework.Refactored.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Class04.AspNet.Homework.Refactored.Business.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductVM> GetAllProducts()
        {
            var productList = new List<ProductVM>();

            foreach (var product in _productRepository.GetAll())
            {
                var productVM = new ProductVM()
                {
                    Id = product.Id,
                    ProductName = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    ProductPrice = product.Price
                };

                productList.Add(productVM);
            }

            return productList;

        }

        public void CreateNewProduct(ProductVM createdProduct)
        {
            var product = new Product()
            {
                Id = _productRepository.GetAll().Count + 1,
                Name = createdProduct.ProductName,
                Description = createdProduct.Description,
                Category = createdProduct.Category,
                Price = createdProduct.ProductPrice
            };

            _productRepository.Insert(product);
        }

        public void EditProduct(ProductVM editedProduct)
        {
            var product = _productRepository.GetAll().FirstOrDefault(p => p.Id == editedProduct.Id);

            product.Name = editedProduct.ProductName;
            product.Description = editedProduct.Description;
            product.Category = editedProduct.Category;
            product.Price = editedProduct.ProductPrice;
        }
    }
}
