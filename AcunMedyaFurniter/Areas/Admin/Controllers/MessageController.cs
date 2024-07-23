using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcunMedyaFurniter.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly FurnitureContext _context;

        public MessageController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values = _context.UserMessages.ToList();
            return View(values);
        }
    }
}

