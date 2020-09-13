using Class04.AspNet.Homework.Refactored.Business.ViewModels;
using Class04.AspNet.Homework.Refactored.Data.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Business.Interfaces
{
    public interface IProductService
    {
        List<ProductVM> GetAllProducts();
        void CreateNewProduct(ProductVM createdProduct);
        void EditProduct(ProductVM editedProduct);
    }
}
