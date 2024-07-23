using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AcunMedyaFurniter.DAL.Context;
using AcunMedyaFurniter.DAL.Entities;

namespace AcunMedyaFurniter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class SubscriberController : Controller
    {

        private readonly FurnitureContext _context;

        public SubscriberController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Subscribers.ToList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddSubscriber(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                _context.Subscribers.Add(subscriber);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index", _context.Subscribers.ToList());
        }

        [HttpPost]
        public IActionResult DeleteSubscriber(int id)
        {
            var subscriber = _context.Subscribers.Find(id);
            if (subscriber != null)
            {
                _context.Subscribers.Remove(subscriber);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
