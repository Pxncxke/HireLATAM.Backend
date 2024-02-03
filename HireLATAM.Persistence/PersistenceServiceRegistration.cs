using HireLATAM.Application.Contracts.Persistence;
using HireLATAM.Persistence.DataBaseContext;
using HireLATAM.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HireLATAMDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HireLATAMConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IItemRepository, ItemRepository>();
            return services;
        }
    }
}
