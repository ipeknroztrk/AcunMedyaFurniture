using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AcunMedyaFurniter.Controllers
{
    public class ProductController : Controller
    {
        private readonly FurnitureContext _context;

        public ProductController(FurnitureContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _context.Products.ToList();
            return View(values);
        }
    }
}

