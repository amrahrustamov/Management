using Management.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Contexts;

public class ManagementDbContext:DbContext
{
    public ManagementDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Department> Departments { get; set; } = null!;
}
