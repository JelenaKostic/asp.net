using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Models
{
    public class SessionRequirementFilter : IAuthorizationFilter
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SessionRequirementFilter(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
              var paramsValue = _httpContextAccessor.HttpContext!.Request.Headers["X-session-params"];
              if (!paramsValue.Equals("Bajina Basta je najlepsa na svetu!"))
                {
                context.Result = new UnauthorizedObjectResult(string.Empty);
                return;
            }
        }
    }
}
