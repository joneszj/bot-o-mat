using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CommonPatterns.Helpers
{
    public class CacheHelper : ICacheHelper
    {
        private IMemoryCache _cache;
        public CacheHelper(IMemoryCache cache) => _cache = cache;
        public V TryGet<K,V>(K Key, out bool IsFound)
        {
            if (IsFound = _cache.TryGetValue(Key, out V value)) return value;
            else return default(V);
        }
        public V Set<K, V>(K Key, V Value) => _cache.Set(Key, Value);
        public static void Configure(IServiceCollection services) => services.AddMemoryCache();
    }
}