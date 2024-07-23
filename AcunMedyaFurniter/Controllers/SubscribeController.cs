using Microsoft.AspNetCore.Mvc;
using AcunMedyaFurniter.DAL.Entities;
using AcunMedyaFurniter.DAL.Context;

namespace AcunMedyaFurniter.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly FurnitureContext _context;

        public SubscribeController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(); // Bu, Subscribe.cshtml'i döndürecek
        }

        [HttpGet]
        public IActionResult Subscribe()
        {
            var subscriber = new Subscriber();
            return PartialView("Subscribe", subscriber); // PartialView ve model
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                _context.Subscribers.Add(subscriber);
                await _context.SaveChangesAsync();
                TempData["SubscriptionSuccess"] = true;
                return RedirectToAction("Index");
            }
            TempData["SubscriptionSuccess"] = false;
            return View(subscriber);
        }
    }
}
