using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrutor;
using System.Reflection;
namespace Adesso.Caching.Memcached
{
    public static class BuilderExtension
    {
        public static IServiceCollection AddMemCached(this IServiceCollection services,
      Action<MemcachedCacheOptions> setupAction = null)
        {

            //services.AddScoped(typeof(IDistributedCache<,>), typeof(DistributedCache<,>));
            services.AddScoped(typeof(IDistributedCache<,>), typeof(MemcachedService<,>));

            return services;
        }

    }
}
