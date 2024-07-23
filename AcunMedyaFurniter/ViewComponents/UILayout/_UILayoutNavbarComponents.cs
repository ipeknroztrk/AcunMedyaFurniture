using System;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.ViewComponents.UILayout
{
    
    public class _UILayoutNavbarComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
