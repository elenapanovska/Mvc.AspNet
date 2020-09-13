using Class04.AspNet.Homework.Refactored.Data.DomainModels;
using Class04.AspNet.Homework.Refactored.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Data.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private Database _db;

        public ProductRepository()
        {
            _db = new Database();
        }
        public List<Product> GetAll()
        {
            return _db.Products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Insert(Product entity)
        {
            _db.Products.Add(entity);
            return _db.Products;
        }

        public int Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            //var product = _db.Products.FirstOrDefault(p => p.Id == entity.Id);
            //product = entity;
            _db.Products.Add(entity);
        }
    }
}
