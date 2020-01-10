using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Core.DecryptexRepository
{
    public interface IApplicationConfigurationRepository
    {
        List<ApplicationConfiguration> GetDetail();

        ApplicationConfiguration GetDetailById(int id);
    }
}