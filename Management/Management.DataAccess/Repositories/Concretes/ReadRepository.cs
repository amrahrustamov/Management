using Management.Core.Entities.Base;
using Management.DataAccess.Contexts;
using Management.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Repositories.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    public ManagementDbContext _context { get; set; }

    public ReadRepository(ManagementDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(params string[] includes)
    {
        var query = Table.AsQueryable();

        /*if(includes is not null && includes.Length != 0)
        {

            foreach(var include in includes)
            {

                query = query.Include(include);
            }
        }*/

        return query;
    }
}
