using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Models
{
    public class SessionRequirementAttribute : TypeFilterAttribute
    {
        public SessionRequirementAttribute() : base(typeof(SessionRequirementFilter))
        {
        }
    }
}
