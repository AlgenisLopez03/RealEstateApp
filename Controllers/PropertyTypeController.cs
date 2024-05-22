using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Interfaces.Services;

using RealEstateApp.Core.Application.ViewModels.PropertyType;

namespace RealEstateApp.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PropertyTypeController : Controller
    {
        private readonly IPropertyTypeService _propertyTypeService;

        public PropertyTypeController(IPropertyTypeService propertyTypeService)
        {
            _propertyTypeService = propertyTypeService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _propertyTypeService.GetAllViewModel());
        }

        public async Task<IActionResult> Create(SavePropertyTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            await _propertyTypeService.Add(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _propertyTypeService.GetByIdSaveViewModel(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SavePropertyTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            await _propertyTypeService.Update(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vm = await _propertyTypeService.GetByIdSaveViewModel(id);

            await _propertyTypeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
