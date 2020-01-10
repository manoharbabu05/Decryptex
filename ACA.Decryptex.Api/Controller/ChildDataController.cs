using System.Collections.Generic;
using ACA.Decryptex.Cache;
using ACA.Decryptex.Cache.Provider.Interface;
using ACA.Decryptex.Core.DecryptexOrchestrator;
using ACA.Decryptex.Core.DecryptexRepository.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace ACA.Decryptex.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildDataController : ControllerBase
    {
        private IApplicationConfigurationOrchestrator iApplicationConfigurationOrchestrator;
        private IMCache iMCache;
        private ITenantProvider iTenantProvider;

        public ChildDataController(IApplicationConfigurationOrchestrator _iApplicationConfigurationOrchestrator,
            IMCache _IMCache,
            ITenantProvider _iTenantProvider)
        {
            iApplicationConfigurationOrchestrator = _iApplicationConfigurationOrchestrator;
            iMCache = _IMCache;
            iTenantProvider = _iTenantProvider;
        }

        private string CustomerName
        {
            get
            {
                string customerName = string.Empty;
                var request = Request;

                if (request != null)
                {
                    var header = request.Headers;

                    if (header != null && header.ContainsKey("ClientName"))
                    {
                        header.TryGetValue("ClientName", out var _clientName);
                        customerName = _clientName.ToString();
                    }
                }

                return customerName;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var test = CustomerName;
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetDetail")]
        public List<VMApplicationConfiguration> GetDetails()
        {
            iTenantProvider.SetConnectionString(this.CustomerName);

            return iApplicationConfigurationOrchestrator.GetDetail();
        }

        [HttpGet("GetDetail/{Id}")]
        public VMApplicationConfiguration GetDetailsById(int Id)
        {
            return iApplicationConfigurationOrchestrator.GetDetailById(Id);
        }
    }
}