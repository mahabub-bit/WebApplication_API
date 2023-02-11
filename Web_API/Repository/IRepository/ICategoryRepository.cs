using Web_API.Data;
using Web_API.Models;

namespace Web_API.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> UpdateAsync(Category entity);
    }

}
