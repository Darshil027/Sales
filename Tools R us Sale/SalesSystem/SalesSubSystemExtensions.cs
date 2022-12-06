using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.BLL;
using SalesSystem.DAL;

namespace SalesSystem;
public static class SalesSubSystemExtensions
{
    public static void SalesSubSystemBackendDependencies(this IServiceCollection services,
        Action<DbContextOptionsBuilder> options)
    {
        services.AddDbContext<eTools2021Context>(options);

        services.AddTransient<CategoryServices>((serviceProvider) =>
        {
            var context = serviceProvider.GetRequiredService<eTools2021Context>();

            return new CategoryServices(context);
        });

        services.AddTransient<StockItemServices>((serviceProvider) =>
        {
            var context = serviceProvider.GetRequiredService<eTools2021Context>();

            return new StockItemServices(context);
        });
    }
}
