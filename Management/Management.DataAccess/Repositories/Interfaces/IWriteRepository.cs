using Management.Core.Entities.Base;

namespace Management.DataAccess.Repositories.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChange();
    }
}
