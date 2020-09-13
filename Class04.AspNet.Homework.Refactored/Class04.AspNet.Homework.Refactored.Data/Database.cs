using Class04.AspNet.Homework.Refactored.Data.DomainModels;
using Class04.AspNet.Homework.Refactored.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Data
{
    public  class Database
    {
        public  List<User> Users;
        public  List<Product> Products;

        public Database()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill Street",
                    Phone = 08006546345
                }
            };

            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "MacBook Pro",
                    Description = "Laptop",
                    Category = Category.Eletronics,
                    Price = 1299.00
                },

                new Product()
                {
                    Id = 2,
                    Name = "The lost symbol",
                    Description = "Book by Dan Brown",
                    Category = Category.Books,
                    Price = 10.00
                },

                new Product()
                {
                    Id = 3,
                    Name = "T-Shirt",
                    Description ="Cotton t-shirt",
                    Category = Category.Clothes,
                    Price = 5.00
                }
            };
        }
    }
}
