using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
	public class _DefaultTeamComponent:ViewComponent
	{
		private readonly FurnitureContext _context;

        public _DefaultTeamComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Teams.ToList();
			return View(values);
		}
	}
}

