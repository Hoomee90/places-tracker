using Microsoft.AspNetCore.Mvc;
using PlacesTracker.Models;

namespace PlacesTracker.Controllers
{
		public class HomeController : Controller
		{

			[HttpGet("/")]
			public ActionResult Index()
			{
				return View();
			}

			// [HttpGet("/places/new")]
			// public ActionResult New()
			// {
			// 	return View();
			// }

			// [HttpPost("/places")]
			// public ActionResult Create(string city)
			// {
			// 	Place _ = new(city);
			// 	return RedirectToAction("Index");
			// }
			
			// [HttpGet("/places/{id}")]
			// public ActionResult Show(int id)
			// {
			// 	Place foundPlace = Place.Find(id);
			// 	return View(foundPlace);
			// }
		}
}