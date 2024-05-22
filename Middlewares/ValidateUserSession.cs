using RealEstateApp.Core.Application.Helpers;
using RealEstateApp.Core.Application.Dtos.Account.Response.Authentications;

namespace RealEstateApp.WebApp.Middlewares
{
    public class ValidateUserSession
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ValidateUserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            AuthenticationWResponse user = _httpContextAccessor.HttpContext.Session.Get<AuthenticationWResponse>("user");

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
