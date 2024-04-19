using Microsoft.AspNetCore.Mvc;

namespace PlacesTracker.Controllers
{
    public class PlacesController : Controller
    {

      [HttpGet("/places")]
      public ActionResult Index()
      {
        return View();
      }

    }
}