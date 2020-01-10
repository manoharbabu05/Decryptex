using System.Collections.Generic;
using System.Linq;
using ACA.Decryptex.Core.DecryptexRepository;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;
using ACA.Decryptex.Repository.Context;

namespace ACA.Decryptex.Repository
{
    public class ApplicationConfigurationRepository : IApplicationConfigurationRepository
    {
        private ClientDBContext clientDBContext;

        public ApplicationConfigurationRepository(ClientDBContext _clientDBContext)
        {
            clientDBContext = _clientDBContext;
        }

        public List<ApplicationConfiguration> GetDetail()
        {
            return clientDBContext.ApplicationConfigurations.ToList();
        }

        public ApplicationConfiguration GetDetailById(int id)
        {
            return clientDBContext.ApplicationConfigurations.Where(i => i.Id == id).FirstOrDefault();
        }
    }
}