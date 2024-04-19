using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesTracker.Models;

namespace PlacesTracker.Controllers
{
	public class PlacesController : Controller
	{
		[HttpGet("/places")]
		public ActionResult Index()
		{
			List<Place> places = Place.GetAll();
			return View(places);
		}

		[HttpGet("/places/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/places")]
		public ActionResult Create(string city)
		{
			Place _ = new(city);
			return RedirectToAction("Index");
		}
		
		[HttpGet("/places/{id}")]
		public ActionResult Show(int id)
		{
			Place foundPlace = Place.Find(id);
			return View(foundPlace);
		}
	}
}