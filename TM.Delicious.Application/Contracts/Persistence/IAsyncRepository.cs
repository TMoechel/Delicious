using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TM.Delicious.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetByIdAsync(Guid Id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeletAsync(T entity);
    }
}
