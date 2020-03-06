using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OidcDemo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index OidcDemo2");
        }

        [Authorize]
        //home/secured
        public IActionResult Secured()
        {
            return Content($"Secured. OidcDemo2");
        }
    }
}