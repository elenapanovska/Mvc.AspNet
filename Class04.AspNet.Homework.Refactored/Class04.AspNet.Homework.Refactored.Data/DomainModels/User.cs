using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.AspNet.Homework.Refactored.Data.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
}
