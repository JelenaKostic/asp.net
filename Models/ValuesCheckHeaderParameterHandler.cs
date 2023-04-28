using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ValuesCheckHeaderParameterHandler : AuthorizationHandler<TextToAuthorizeRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ValuesCheckHeaderParameterHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TextToAuthorizeRequirement requirement)
        {
            
            var paramsValue = _httpContextAccessor.HttpContext!.Request.Headers["Test-header-requrements"];         

            if (paramsValue.ToString() == "Bajina Basta je najlepsa na svetu!")
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

}
