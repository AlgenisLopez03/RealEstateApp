using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Interfaces.Services;
using RealEstateApp.Core.Application.Services;
using RealEstateApp.Core.Application.ViewModels.Improvement;
using RealEstateApp.Core.Application.ViewModels.PropertyType;

namespace RealEstateApp.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ImprovementController : Controller
    {
        private readonly IImprovementService _improvementService;

        public ImprovementController(IImprovementService improvementService)
        {
            _improvementService = improvementService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _improvementService.GetAllViewModel());
        }

        public async Task<IActionResult> Create(SaveImprovementViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            await _improvementService.Add(vm);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var model = await _improvementService.GetByIdSaveViewModel(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveImprovementViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            
            await _improvementService.Update(vm);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vm = await _improvementService.GetByIdSaveViewModel(id);

            await _improvementService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
