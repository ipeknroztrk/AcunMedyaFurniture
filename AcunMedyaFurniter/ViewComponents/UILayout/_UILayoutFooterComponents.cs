using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.UILayout
{
	public class _UILayoutFooterComponents:ViewComponent
	{
		private readonly FurnitureContext _context;

        public _UILayoutFooterComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.SocialMedias.ToList();
			return View(values);
		}
	}
}

