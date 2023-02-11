﻿using Web_API.Models;

namespace Web_API.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> UpdateAsync(Company entity);
    }
}
