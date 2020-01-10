using System;
using ACA.Decryptex.Cache.Provider.Interface;

namespace ACA.Decryptex.Cache.Provider
{
    public class TenantProvider : ITenantProvider
    {
        private readonly IMCache _memoryCache;

        private string _currentTenantConnection;

        public TenantProvider(IMCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public string GetCurrentTenantConnectionString()
        {
            return _currentTenantConnection;
        }

        public void SetConnectionString(string clientName)
        {
            _currentTenantConnection = _memoryCache.GetClientConnection(clientName);
            Console.WriteLine("{0},{1}", clientName, _currentTenantConnection);
        }
    }
}