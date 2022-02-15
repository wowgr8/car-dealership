using Microsoft.AspNetCore.Mvc;

namespace Dealership.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}