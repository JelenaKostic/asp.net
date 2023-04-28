using Microsoft.AspNetCore.Authorization;

namespace TodoApi.Models
{
    public class TextToAuthorizeRequirement : IAuthorizationRequirement
    {
        public TextToAuthorizeRequirement(string textToAuthorize) =>
            TextToAuthorize = textToAuthorize;

        public string TextToAuthorize { get; }
    }
}
