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
    public class ContactController : Controller
    {
        private readonly FurnitureContext _context;

        public ContactController(FurnitureContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var values = _context.ContactInfos.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContact(ContactInfo Contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Contact);
        }


        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var Contact = await _context.ContactInfos.FindAsync(id);
            if (Contact == null)
            {
                return NotFound();
            }
            return View(Contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var Contact = await _context.ContactInfos.FindAsync(id);

            if (Contact == null)
            {
                return NotFound();
            }

            _context.ContactInfos.Remove(Contact);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateContact(ContactInfo Contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.ContactInfos.Update(Contact);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Lütfen Tekrar Deneyiniz.");
                }
            }
            return View(Contact);
        }
    }
}

