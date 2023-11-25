using Avizura.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avizura.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(int id);
        Task<Product> GetProductCategoryAsync(int id);
        Task<Product> InsertAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Product product);
    }
}
