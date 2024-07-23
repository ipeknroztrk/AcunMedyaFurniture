using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
	public class _DefaultFeatureComponents:ViewComponent
	{
		private readonly FurnitureContext _context;

        public _DefaultFeatureComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Features.ToList();
			
			return View(values);
		}
	}
}

