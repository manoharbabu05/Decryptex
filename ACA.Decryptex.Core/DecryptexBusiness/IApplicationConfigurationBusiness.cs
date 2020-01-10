using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Core.DecryptexBusiness
{
    public interface IApplicationConfigurationBusiness
    {
        List<ApplicationConfiguration> GetDetail();

        ApplicationConfiguration GetDetailById(int id);
    }
}