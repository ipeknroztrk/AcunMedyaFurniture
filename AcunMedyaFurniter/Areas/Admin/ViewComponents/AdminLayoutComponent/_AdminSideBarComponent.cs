using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.Areas.Admin.ViewComponents.AdminLayoutComponent
{
	public class _AdminSidebarComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}