﻿using Class04.AspNet.Homework.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class04.AspNet.Homework.App.Models.ViewModels
{
    public class CreateProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category  { get; set; }
        public double Price { get; set; }
    }
}
