using System;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.UILayout
{
	public class _UILayoutHeadComponents:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

