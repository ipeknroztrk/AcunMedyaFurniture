using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcunMedyaFurniter.DAL.Context;
using AcunMedyaFurniter.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcunMedyaFurniter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ServiceController : Controller
    {
        private readonly FurnitureContext _context;

        public ServiceController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Services = _context.Services.ToList();
            return View(Services);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var Service = await _context.Services.FindAsync(id);
            if (Service == null)
            {
                return NotFound();
            }
            return View(Service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateService(Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Services.Update(service);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Lütfen Tekrar Deneyiniz.");
                }
            }
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteService(int id)
        {
            var Service = await _context.Services.FindAsync(id);

            if (Service == null)
            {
                return NotFound();
            }

            _context.Services.Remove(Service);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
