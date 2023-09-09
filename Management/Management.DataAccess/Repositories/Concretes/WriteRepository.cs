using Management.Core.Entities.Base;
using Management.DataAccess.Contexts;
using Management.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Repositories.Concretes
{
    public class WriteRepository<T> : IWriteRepository<T> where T:BaseEntity
    {
        public ManagementDbContext _context { get; set; }

        public WriteRepository(ManagementDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
