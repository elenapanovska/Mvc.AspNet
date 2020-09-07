using Class04.AspNet.Homework.App.InMemoryDb;
using Class04.AspNet.Homework.App.Models.Domain;
using Class04.AspNet.Homework.App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class04.AspNet.Homework.App.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("Products")]
        public IActionResult Index(string message)
        {
            var productList = new List<ProductVM>();

            foreach (var product in Database.Products)
            {
                var productVM  = new ProductVM()
                {
                    ProductName = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    ProductPrice = product.Price
                };

                productList.Add(productVM);
            }

            var products = new ProductListVM()
            {
                Products = productList
            };

            ViewBag.Message = message;

            return View("Products", products);
        }

        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            
            return View();
        }

        [HttpPost("CreateProduct")] 
        public IActionResult CreateProduct(CreateProductVM createProduct)
        {
            var product = new Product()
            {
                Id = Database.Products.Count + 1,
                Name = createProduct.Name,
                Description = createProduct.Description,
                Category = createProduct.Category,
                Price = createProduct.Price
            };

            if(product.Name == null && product.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "No product was added!" });
            }

            Database.Products.Add(product);

            return RedirectToAction("Index", new { message = "The product was succesfully created!" });
        }

    }
}
