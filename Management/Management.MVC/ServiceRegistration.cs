using Management.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Management.MVC;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection service)
    {
        var connectionStr = Configuration.ConnectionString;
        service.AddDbContext<ManagementDbContext>(opt =>
        {
            opt.UseSqlServer(connectionStr);
        });
    }
    
}
