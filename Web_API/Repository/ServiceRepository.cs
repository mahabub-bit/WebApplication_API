using Web_API.Data;
using Web_API.Models;
using Web_API.Repository.IRepository;

namespace Web_API.Repository
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Service> UpdateAsync(Service entity)
        {
            _db.Services.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
