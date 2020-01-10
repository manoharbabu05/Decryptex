using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexBusiness;
using ACA.Decryptex.Core.DecryptexRepository;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Repository
{
    public class ApplicationConfigurationBusiness : IApplicationConfigurationBusiness
    {
        public IApplicationConfigurationRepository iApplicationConfigurationRepository;

        public ApplicationConfigurationBusiness(IApplicationConfigurationRepository _IApplicationConfigurationRepository)
        {
            iApplicationConfigurationRepository = _IApplicationConfigurationRepository;
        }

        public List<ApplicationConfiguration> GetDetail()
        {
            return iApplicationConfigurationRepository.GetDetail();
        }

        public ApplicationConfiguration GetDetailById(int id)
        {
            return iApplicationConfigurationRepository.GetDetailById(id);
        }
    }
}