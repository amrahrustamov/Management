using Management.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    public DbSet<T> Table { get; }
}
