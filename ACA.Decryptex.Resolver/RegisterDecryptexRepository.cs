using ACA.Decryptex.Core.DecryptexRepository;
using ACA.Decryptex.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Resolver
{
    public static class RegisterDecryptexRepository
    {
        public static void DecryptexRepository(this IServiceCollection service)
        {
            service.AddTransient<IApplicationConfigurationRepository, ApplicationConfigurationRepository>();
        }
    }
}