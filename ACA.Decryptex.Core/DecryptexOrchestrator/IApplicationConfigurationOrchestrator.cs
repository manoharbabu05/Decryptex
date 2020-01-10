using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Core.DecryptexOrchestrator
{
    public interface IApplicationConfigurationOrchestrator
    {
        List<VMApplicationConfiguration> GetDetail();

        VMApplicationConfiguration GetDetailById(int id);
    }
}