using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.Property;

namespace RealEstateApp.WebApp.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly ISellTypeService _sellTypeService;
        private readonly IImprovementService _improvementService;

        public PropertyController(IPropertyService propertyService, IPropertyTypeService propertyTypeService, ISellTypeService sellTypeService, IImprovementService improvementService)
        {
            _propertyService = propertyService;
            _propertyTypeService = propertyTypeService;
            _sellTypeService = sellTypeService;
            _improvementService = improvementService;
        }   

        public async Task<IActionResult> Index()
        {
            return View(await _propertyService.GetAllViewModel());
        }

        public async Task<IActionResult> Create()
        {
            var vm = new SavePropertyViewModel()
            {
                PropertyTypes = await _propertyTypeService.GetAllViewModel(),
                SellTypes = await _sellTypeService.GetAllViewModel(),
                Improvements = await _improvementService.GetAllViewModel()
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SavePropertyViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            await _propertyService.Add(vm);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var vm = await _propertyService.GetByIdSaveViewModel(id);
            vm.SellTypes = await _sellTypeService.GetAllViewModel();
            vm.PropertyTypes = await _propertyTypeService.GetAllViewModel();
            return View("Create", vm);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(SavePropertyViewModel vm)
        {
            if (!ModelState.IsValid)
            {

                return View("Create", vm);
            }
            await _propertyService.Update(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vm = await _propertyService.GetByIdSaveViewModel(id);

            await _propertyService.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
