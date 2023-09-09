using Management.Core.Entities.Base;

namespace Management.DataAccess.Repositories.Interfaces;

public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(params string[] includes);
}
