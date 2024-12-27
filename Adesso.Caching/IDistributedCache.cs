using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adesso.Caching
{
    public interface IDistributedCache<TCacheItem, TCacheKey>
        where TCacheItem : class
        where TCacheKey : notnull
    {
        Task<TCacheItem?> GetOrAddAsync(
     [NotNull] TCacheKey key,
     TCacheItem cacheItem,
     DistributedCacheEntryOptions? expirationTime,
     CancellationToken token = default);

        Task<TCacheItem?> AddAsync(
[NotNull] TCacheKey key,
TCacheItem cacheItem,
     DistributedCacheEntryOptions? expirationTime,
CancellationToken token = default);

        Task<TCacheItem?> RemoveAsync(
[NotNull] TCacheKey key,
CancellationToken token = default);


    }
}
