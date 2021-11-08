using CoinJar.Model;
using CoinJar.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoinJar.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IGenericRepository<TEntity>
    {
        protected readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }
    }
}
