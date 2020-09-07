using Class04.AspNet.Homework.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class04.AspNet.Homework.App.Models.ViewModels
{
    public class ProductVM
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
