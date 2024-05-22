using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Dtos.Account.Response;
using RealEstateApp.Core.Application.Dtos.Account.Response.Authentications;
using RealEstateApp.Core.Application.Enums;
using RealEstateApp.Core.Application.Helpers;
using RealEstateApp.Core.Application.Interfaces.Helpers;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.User;
using RealEstateApp.WebApp.Middlewares;

namespace RealEstateApp.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [ServiceFilter(typeof(LoginAuthorize))]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [ServiceFilter(typeof(LoginAuthorize))]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            AuthenticationWResponse userVm = await _userService.LoginAsync(vm);
            if (userVm != null && userVm.HasError != true)
            {
                if (userVm.Roles.Any(r => r == Roles.Developer.ToString()))
                    return RedirectToRoute(new { controller = "User", action = "AccessDenied" });

                HttpContext.Session.Set<AuthenticationWResponse>("user", userVm);

                if (userVm.Roles.Any(r => r == Roles.Client.ToString()))
                    return RedirectToRoute(new { controller = "Home", action = "Index" });

                if (userVm.Roles.Any(r => r == Roles.Admin.ToString()))
                    return RedirectToRoute(new { controller = "Admin", action = "Index" });

                if (userVm.Roles.Any(r => r == Roles.Agent.ToString()))
                    return RedirectToRoute(new { controller = "Agent", action = "Index" });

                if (userVm.Roles.Any(r => r == Roles.Developer.ToString()))
                {
                    vm.HasError = true;
                    vm.Error = "Los desarrolladores no tienen acceso a la web app";
                }

                vm.HasError = userVm.HasError;
                vm.Error = "No cuenta con un rol dentro de la aplicacion";
                return View(vm);
            }
            else
            {
                vm.HasError = userVm.HasError;
                vm.Error = userVm.Error;
                return View(vm);
            }
        }

        [ServiceFilter(typeof(LoginAuthorize))]
        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [ServiceFilter(typeof(LoginAuthorize))]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            vm.Status = false; 
            RegisterResponse response = new RegisterResponse();

            if (vm.TypeUser == Roles.Client)
            {
                var origin = Request.Headers["origin"];

                response = await _userService.RegisterAsync(vm, origin);

            }
            else if(vm.TypeUser == Roles.Agent)
            {
                response = await _userService.RegisterAsync(vm);
            }

            if (response.HasError)
            {
                return View(vm);
            }

            return RedirectToRoute(new { controller = "User", action = "Login" });
        }

        [ServiceFilter(typeof(LoginAuthorize))]
        public async Task<IActionResult> ConfirmAccount(string userId, string token)
        {
            string response = await _userService.ConfirmAccountAsync(userId, token);
            return View(response);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _userService.SignOutAsync();
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
