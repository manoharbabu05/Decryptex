using System.Collections.Generic;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;

namespace ACA.Decryptex.Core.DecryptexRepository.Interface
{
    public interface IMasterRepository
    {
        IEnumerable<ClientMaster> GetClientMasters();
    }
}