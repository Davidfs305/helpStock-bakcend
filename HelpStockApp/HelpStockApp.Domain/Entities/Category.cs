using HelpStockApp.Domain.Validatio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelpStockApp.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public Category(string name)
        {
            ValidateDomain(name);   
        }

        public Category(int id, string name)
        {
            Id = id;
            ValidateDomain(name);
        }
        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidatio.When(string.IsNullOrEmpty(name), "Invalid name, name is required ");
            DomainExceptionValidatio.When(name.Length < 3, "Invalid name, too short. minimum 3 characteres!");

        }
    }
 
}
