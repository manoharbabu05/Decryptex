using System.Collections.Generic;
using System.Linq;
using ACA.Decryptex.Cache;
using ACA.Decryptex.Cache.Model;
using ACA.Decryptex.Core.DecryptexRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ACA.Decryptex.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private IMasterRepository iMasterRepository;
        private IMCache iMCache;

        public MasterDataController(IMasterRepository _iMasterRepository, IMCache _iMCache)
        {
            iMasterRepository = _iMasterRepository;
            iMCache = _iMCache;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            iMCache.InitializeCache(iMasterRepository.GetClientMasters().Select(i => new CacheModel() { ClientName = i.ClientName, ConnectionString = i.ClientConnectionString }));

            return new string[] { "value1", "value2" };
        }
    }
}