using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
	public class _DefaultTestimonailComponents:ViewComponent
	{
		private readonly FurnitureContext _context;

        public _DefaultTestimonailComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Testimonials.ToList();
			return View(values);
		}
	}
}

