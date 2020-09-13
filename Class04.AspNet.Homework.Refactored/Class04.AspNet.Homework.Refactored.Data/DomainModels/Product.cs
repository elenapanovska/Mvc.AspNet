using Class04.AspNet.Homework.Refactored.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Data.DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
    }
}
