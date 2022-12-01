using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using User.Infrastructure.Configurations;
using User.Infrastructure.DbContext;

namespace User.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(DatabaseConfigurations.CONNECTIONSTRING));

        return services;
    }
}