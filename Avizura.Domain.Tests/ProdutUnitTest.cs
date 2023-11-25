using Avizura.Domain.Entities;
using Avizura.Domain.Validation;
using FluentAssertions;
using System;
using Xunit;

namespace Avizura.Domain.Tests
{
    public class ProdutUnitTest
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product name", "Product description", 2, 5, "Image");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCategory_MissingNameValue_DomainExceptionNameValue()
        {
            Action action = () => new Product(1, "", "Product description", 2, 5, "Image");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name.");
        }

        [Fact]
        public void CreateCategory_MissingDescriptionValue_DomainExceptionDescriptionValue()
        {
            Action action = () => new Product(1, "Product name", "", 2, 5, "Image");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description.");
        }

        [Fact]
        public void CreateCategory_MissingImageValue_DomainExceptionImageValue()
        {
            Action action = () => new Product(1, "Product name", "Product description", 2, 5, "");
            action.Should().Throw<DomainExceptionValidation>("Invalid image.");
        }

        [Fact]
        public void CreateCategory_PriceWithNegativeValue_DomainExceptionNegativeValue()
        {
            Action action = () => new Product(1, "Product name", "Product description", -9.99m, 5, "Image");
            action.Should().Throw<DomainExceptionValidation>("Invalid price amount.");
        }

        [Fact]
        public void CreateCategory_StockWithNegativeValue_DomainExceptionNegativeValue()
        {
            Action action = () => new Product(1, "Product name", "Product description", 2, -1, "Image");
            action.Should().Throw<DomainExceptionValidation>("Invalid stock amount.");
        }
    }
}
