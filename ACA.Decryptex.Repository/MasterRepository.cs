using System.Collections.Generic;
using System.Linq;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;
using ACA.Decryptex.Core.DecryptexRepository.Interface;
using ACA.Decryptex.Repository.Context;

namespace ACA.Decryptex.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private MasterDBContext masterDBContext;

        public MasterRepository(MasterDBContext _masterDBContext)
        {
            masterDBContext = _masterDBContext;
        }

        public IEnumerable<ClientMaster> GetClientMasters()
        {
            return masterDBContext.ClientMasters.ToList();
        }
    }
}