using CoinJar.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinJar.Repository
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Delete(Guid id);
    }
}
