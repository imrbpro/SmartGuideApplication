using Microsoft.Extensions.DependencyInjection;
using Repository.Helpers.Implementations;
using Repository.Helpers.Interfaces;
using Repository.Implementations;
using Repository.Interfaces;
using Services.Impementations;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.Helpers
{
    public static class ActivationHelper
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            #region Services
            services.AddSingleton<IShopService, ShopService>();
            services.AddSingleton<IEventService, EventService>();
            #endregion
            #region REPOSITORIES
            services.AddSingleton<IShopRepository, ShopRepository>();
            services.AddSingleton<IEventRepository, EventRepository>();
            #endregion
            #region DB
            services.AddSingleton<IDBhelper, Dbhelper>();
            #endregion
            return services;
        }
    }
}
