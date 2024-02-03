using HireLATAM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : Item
    {
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
