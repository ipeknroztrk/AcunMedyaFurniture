using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcunMedyaFurniter.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurniter.Controllers
{
    public class ServicesController : Controller
    {
        

        public IActionResult Index()
        {

           
            return View();
        }
    }
}

