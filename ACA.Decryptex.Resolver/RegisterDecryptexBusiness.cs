using ACA.Decryptex.Core.DecryptexBusiness;
using ACA.Decryptex.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Resolver
{
    public static class RegisterDecryptexBusiness
    {
        public static void DecryptexBusiness(this IServiceCollection service)
        {
            service.AddTransient<IApplicationConfigurationBusiness, ApplicationConfigurationBusiness>();
        }
    }
}