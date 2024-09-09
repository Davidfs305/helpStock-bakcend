using HelpStockApp.Domain.Validatio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpStockApp.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidatio.When(price < 0, "Invalid Price, price nagative value is unlikely!");
            DomainExceptionValidatio.When(string.IsNullOrEmpty(name), "Invalid Name,name Required");
            DomainExceptionValidatio.When(name.Length < 3, "Invalid name, too short. minimum 3 characteres!");
            DomainExceptionValidatio.When(description.Length < 5, "Invalid name, too short. minimum 5 characteres!");
            DomainExceptionValidatio.When(string.IsNullOrEmpty(description),"Invalid description,description required!");
            DomainExceptionValidatio.When(stock < 0,"Invalid stock,stock negative value is unlikely!");
            DomainExceptionValidatio.When(image.Length > 250, "Invalid image too long.maximum 250 characteres!");


        }
        
    }
}
