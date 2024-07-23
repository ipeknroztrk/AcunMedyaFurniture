using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
	public class _DefaultServiceComponents:ViewComponent
	{
        private readonly FurnitureContext _context;

        public _DefaultServiceComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
            var values = _context.Services.ToList();
			return View(values);
		}
	}
}

