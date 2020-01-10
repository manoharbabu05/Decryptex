using ACA.Decryptex.Core.DecryptexRepository.Interface;
using ACA.Decryptex.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Resolver
{
    public static class RegisterDecryptexMasterRepository
    {
        public static void DecryptexMasterRepository(this IServiceCollection service)
        {
            service.AddTransient<IMasterRepository, MasterRepository>();
        }
    }
}