using Microsoft.AspNetCore.Mvc.Filters;

namespace ACA.Decryptex.Api.Controller
{
    public class TestFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;

            if (request != null)
            {
                var header = request.Headers;

                if (header != null && header.ContainsKey("ClientName"))
                {
                    header.TryGetValue("ClientName", out var _clientName);
                    _clientName.ToString();
                }
            }
        }
    }
}