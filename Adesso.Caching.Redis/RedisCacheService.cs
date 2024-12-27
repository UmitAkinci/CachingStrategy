using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.Caching.Redis
{
    public class RedisCacheService<TCacheItem, TCacheKey> : IDistributedCache<TCacheItem, TCacheKey> where TCacheItem : class where TCacheKey : notnull
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cacheItem"></param>
        /// <param name="expirationTime"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TCacheItem?> AddAsync([NotNull] TCacheKey key, TCacheItem cacheItem, DistributedCacheEntryOptions? expirationTime, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TCacheItem?> GetOrAddAsync([NotNull] TCacheKey key, TCacheItem cacheItem, DistributedCacheEntryOptions? expirationTime, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<TCacheItem?> RemoveAsync([NotNull] TCacheKey key, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }

}
