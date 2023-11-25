using Avizura.Domain.Validation;

namespace Avizura.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }
        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id.");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name.");
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(description), "Invalid description.");
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(image), "Invalid image.");
            DomainExceptionValidation.When(price <= 0, "Invalid price amount.");
            DomainExceptionValidation.When(stock <= 0, "Invalid stock amount.");
        }
    }
}
