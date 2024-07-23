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
    public class SocialMediaController : Controller
    {
        private readonly FurnitureContext _context;

        public SocialMediaController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Add(socialMedia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public IActionResult EditSocialMedia(int id)
        {
            var socialMedia = _context.SocialMedias.Find(id);
            if (socialMedia == null)
            {
                return NotFound();
            }
            return View(socialMedia);
        }

        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                _context.SocialMedias.Update(socialMedia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialMedia);
        }

        [HttpPost]
        public IActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = _context.SocialMedias.Find(id);
            if (socialMedia != null)
            {
                _context.SocialMedias.Remove(socialMedia);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
