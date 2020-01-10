using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Resolver
{
    public static class BaseRegisterResolver
    {
        public static void BaseRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.DecryptexRepository();
            serviceCollection.DecryptexMasterRepository();

            serviceCollection.DecryptexOrchestrator();
            serviceCollection.DecryptexBusiness();
        }
    }
}