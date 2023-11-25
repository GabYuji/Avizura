using Avizura.Domain.Validation;
using System.Collections.Generic;

namespace Avizura.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category(string name)
        {
            ValidateDomain(name);
            Name = name;
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id <= 0, "Invalid Id.");
            ValidateDomain(name);
            Id = id;
        }

        public string Name { get; private set; }
        
        public ICollection<Product> Products { get; set; }
        public void Update(string name)
        {
            ValidateDomain(name);
        }
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Name is too short.");
        }
    }
}
