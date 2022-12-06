using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchasingSystem.BLL;

#region Additional Namespaces
using PurchasingSystem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
#endregion

namespace PurchasingSystem
{
    public static class PurchasingExtensions
    {
        public static void PurchasingBackendDependencies(this IServiceCollection services,
            Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<eTools2021Context>(options);
        }
    }
}