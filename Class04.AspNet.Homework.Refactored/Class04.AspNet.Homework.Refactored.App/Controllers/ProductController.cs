using Class04.AspNet.Homework.Refactored.Business.Interfaces;
using Class04.AspNet.Homework.Refactored.Business.Services;
using Class04.AspNet.Homework.Refactored.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class04.AspNet.Homework.Refactored.App.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public IActionResult Index(string message)
        {
            var products = _productService.GetAllProducts();
            ViewBag.Message = message;
            ViewBag.Error = TempData["Error"];
            return View("Products", products);
        }

        [HttpGet("createProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("createProduct")]
        public IActionResult CreateProduct(ProductVM productVM)
        {
            if (productVM.ProductName == null && productVM.ProductPrice == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "No product was added!" });
            }

            _productService.CreateNewProduct(productVM);
            return RedirectToAction("Index", new { message = "The product was succesfully added!" });
        }

        [HttpGet("details")]
        public IActionResult Details(int id)
        {
            var product = _productService.GetAllProducts().FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                TempData["Error"] = $"The product with id: {id} does not exist!";
                return RedirectToAction("Index");
            }

            return View("Details", product);
        }

        [HttpGet("editProduct")]
        public IActionResult Edit(int id)
        {
            var product = _productService.GetAllProducts().FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        [HttpPost("editProduct")]
        public IActionResult Edit(ProductVM editedProduct)
        {
            _productService.EditProduct(editedProduct);

            return RedirectToAction("Index");
        }
    }
}
