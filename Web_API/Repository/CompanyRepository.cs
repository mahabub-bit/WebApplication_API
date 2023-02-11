using Web_API.Data;
using Web_API.Models;
using Web_API.Repository.IRepository;

namespace Web_API.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Company> UpdateAsync(Company entity)
        {
            entity.CC2 = DateTime.Now;
            _db.Companies.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
