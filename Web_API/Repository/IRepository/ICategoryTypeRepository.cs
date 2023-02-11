using Web_API.Models;

namespace Web_API.Repository.IRepository
{
    public interface ICategoryTypeRepository : IRepository<CategoryType>
    {
        Task<CategoryType> UpdateAsync(CategoryType entity);
    }
}
