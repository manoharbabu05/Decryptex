namespace ACA.Decryptex.Cache.Provider.Interface
{
    public interface ITenantProvider
    {
        string GetCurrentTenantConnectionString();

        void SetConnectionString(string clientName);
    }
}