using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OidcDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index");
        }

        [Authorize]
        public IActionResult Secured()
        {
            //var items = HttpContext.AuthenticateAsync().Result.Properties.Items;
            var accessToken = HttpContext.GetTokenAsync("access_token").Result;
            var idToken = HttpContext.GetTokenAsync("id_token").Result;
            return Content($"Secured. accessToken: {accessToken}. idToken: {idToken}");
        }
    }
}