using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AcunMedyaFurniter.DAL.Context;
using AcunMedyaFurniter.DAL.Entities;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
    public class _DefaultPopulerProductComponents : ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultPopulerProductComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var latestProducts = _context.Products
                                         .OrderByDescending(p => p.ProductID)
                                         .Take(3)
                                         .ToList();

            return View(latestProducts);
        }
    }
}
