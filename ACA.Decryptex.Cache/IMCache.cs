using System.Collections.Generic;
using ACA.Decryptex.Cache.Model;

namespace ACA.Decryptex.Cache
{
    public interface IMCache
    {
        string GetClientConnection(string clientName);

        void InitializeCache(IEnumerable<CacheModel> cacheModels);
    }
}