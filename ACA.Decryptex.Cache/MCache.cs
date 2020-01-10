using System.Collections.Generic;
using ACA.Decryptex.Cache.Model;
using Microsoft.Extensions.Caching.Memory;

namespace ACA.Decryptex.Cache
{
    public class MCache : IMCache
    {
        private readonly IMemoryCache _memoryCache;

        public MCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public string GetClientConnection(string clientName)
        {
            _memoryCache.TryGetValue(clientName, out string returnData);
            return returnData;
        }

        public void InitializeCache(IEnumerable<CacheModel> cacheModels)
        {
            foreach (var cacheModel in cacheModels)
            {
                _memoryCache.Set(cacheModel.ClientName, cacheModel.ConnectionString);
            }
        }
    }
}