using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexBusiness;
using ACA.Decryptex.Core.DecryptexOrchestrator;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Repository
{
    public class ApplicationConfigurationOrchestrator : IApplicationConfigurationOrchestrator
    {
        private IApplicationConfigurationBusiness iApplicationConfigurationBusiness;

        public ApplicationConfigurationOrchestrator(IApplicationConfigurationBusiness _IApplicationConfigurationBusiness)
        {
            iApplicationConfigurationBusiness = _IApplicationConfigurationBusiness;
        }

        public List<VMApplicationConfiguration> GetDetail()
        {
            var applicationConfigurationEMs = iApplicationConfigurationBusiness.GetDetail();
            var applicationConfigurationVMs = new List<VMApplicationConfiguration>(); ;

            foreach (var acem in applicationConfigurationEMs)
            {
                applicationConfigurationVMs.Add(new VMApplicationConfiguration(acem));
            }

            return applicationConfigurationVMs;
        }

        public VMApplicationConfiguration GetDetailById(int id)
        {
            return new VMApplicationConfiguration(iApplicationConfigurationBusiness.GetDetailById(id));
        }
    }
}