using ACA.Decryptex.Core.DecryptexOrchestrator;
using ACA.Decryptex.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Resolver
{
    public static class RegisterDecryptexOrchestrator
    {
        public static void DecryptexOrchestrator(this IServiceCollection service)
        {
            service.AddTransient<IApplicationConfigurationOrchestrator, ApplicationConfigurationOrchestrator>();
        }
    }
}