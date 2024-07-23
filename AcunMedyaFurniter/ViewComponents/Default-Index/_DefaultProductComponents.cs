using System;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.DefaultIndex
{
	public class _DefaultProductComponents:ViewComponent
	{
		private readonly FurnitureContext _context;

        public _DefaultProductComponents(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Products.OrderByDescending(x=>x.ProductID).Take(3).ToList();
			//en son eklenen 3 ürünü çekmek için takelist kullandık
			return View(values);
		}
	}
}

