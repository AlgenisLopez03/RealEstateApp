using Microsoft.AspNetCore.Mvc.Filters;
using RealEstateApp.Core.Application.Dtos.Account.Response.Authentications;
using RealEstateApp.WebApp.Controllers;
using RealEstateApp.Core.Application.Helpers;
using RealEstateApp.Core.Application.Enums;

namespace RealEstateApp.WebApp.Middlewares
{
    public class LoginAuthorize : IAsyncActionFilter
    {
        private readonly ValidateUserSession _userSession;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginAuthorize(ValidateUserSession userSession, IHttpContextAccessor httpContextAccessor)
        {
            _userSession = userSession;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (_userSession.HasUser())
            {
                var controller = (UserController)context.Controller;
                AuthenticationWResponse? User = _httpContextAccessor.HttpContext.Session.Get<AuthenticationWResponse>("user");

                if (User.Roles.Any(role => role == Roles.Admin.ToString()))
                    context.Result = controller.RedirectToAction("Index", "Admin");

                if (User.Roles.Any(role => role == Roles.Agent.ToString()))
                    context.Result = controller.RedirectToAction("Index", "Agent");
            }
            else
            {
                await next();
            }
        }
    }
}
