using Avizura.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avizura.Domain.Interfaces
{
    public interface ICatergoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsyc();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> InsertAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Category category);
    }
}
