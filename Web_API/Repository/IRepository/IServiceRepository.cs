using Web_API.Models;

namespace Web_API.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        Task<Service> UpdateAsync(Service entity);
    }
}
