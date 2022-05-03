
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Eazy.Tours.Controllers
{
    public class RoleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}, {Constants.Roles.ExcursionOwner}")]
        public IActionResult ExcursionOwner()
        {
            return View();
        }


        //[Authorize(Policy = "RequireAdmin")]
        [Authorize(Roles = Constants.Roles.Administrator)]
        public IActionResult Admin()
        {
            return View();
        }


    }
}
