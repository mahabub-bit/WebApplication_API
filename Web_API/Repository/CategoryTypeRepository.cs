using Web_API.Data;
using Web_API.Models;
using Web_API.Repository.IRepository;

namespace Web_API.Repository
{
    public class CategoryTypeRepository : Repository<CategoryType>, ICategoryTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<CategoryType> UpdateAsync(CategoryType entity)
        {
            _db.CategoryTypes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
