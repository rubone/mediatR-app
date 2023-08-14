namespace MediatR.Api.Data;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
{
    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
