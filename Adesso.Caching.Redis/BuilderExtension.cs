using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrutor;
using System.Reflection;
namespace Adesso.Caching.Redis
{
    public static class BuilderExtension
    {
        public static IServiceCollection AddRedisCache(this IServiceCollection services,
      Action<RedisCacheOptions> setupAction = null)
        {

            //services.AddScoped(typeof(IDistributedCache<,>), typeof(DistributedCache<,>));
            services.AddScoped(typeof(IDistributedCache<,>), typeof(RedisCacheService<,>));

            return services;
        }

    }
}
