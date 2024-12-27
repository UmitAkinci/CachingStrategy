using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.Caching.Memcached
{
    public class MemcachedService<TCacheItem, TCacheKey> : IDistributedCache<TCacheItem, TCacheKey> where TCacheItem : class where TCacheKey : notnull
    {
        
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
