using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.ViewModels.SellType;

namespace RealEstateApp.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SellTypeController : Controller
    {
        private readonly ISellTypeService _sellTypeService;

        public SellTypeController(ISellTypeService sellTypeService)
        {
            _sellTypeService = sellTypeService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _sellTypeService.GetAllViewModel());
        }

        public async Task<IActionResult> Create(SaveSellTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            await _sellTypeService.Add(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _sellTypeService.GetByIdSaveViewModel(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveSellTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            await _sellTypeService.Update(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vm = await _sellTypeService.GetByIdSaveViewModel(id);

            await _sellTypeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
