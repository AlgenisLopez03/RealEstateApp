using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Dtos.Account.Response;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.Property;

namespace RealEstateApp.WebApp.Controllers
{
    public class AgentController : Controller
    {
        private readonly IPropertyService _propertyService;

        public AgentController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View(new SavePropertyViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePropertyViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(await Error(vm));

            vm.Code = Guid.NewGuid().ToString()[..8].Replace("-", "").ToUpper();

            await _propertyService.Add(vm);
            return RedirectToAction("index");
        }

        private async Task<SavePropertyViewModel> Error(SavePropertyViewModel vm)
        {
            return vm;
        }
    }
}
