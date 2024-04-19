using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesTracker.Models;
using System;
using System.Collections.Generic;

namespace PlacesTracker.Tests
{
	[TestClass]
	public class PlaceTests : IDisposable
	{
		public void Dispose()
		{
			Place.ClearAll();
		}
		
		[TestMethod]
		public void PlaceConstructor_CreateInstanceOfPlace_Place()
		{
			Place newPlace = new("Fargo");
			Assert.AreEqual(typeof(Place), newPlace.GetType());
		}
		
		[TestMethod]
		public void GetCityName_ReturnsCityName_IntArray()
		{
			string cityName = "Williston";
			Place newPlace = new(cityName);
			string result = newPlace.CityName;
			Assert.AreEqual(cityName, result);
		}
		
		[TestMethod]
		public void SetCityName_SetsValueOfCityName_Void()
		{
			Place newPlace = new("Minneapolis");
			string newCityName = "Winnipeg";
			newPlace.CityName = newCityName;
			Assert.AreEqual(newCityName, newPlace.CityName);
		}
		
		[TestMethod]
		public void GetAll_ReturnsAllPlaceInstances_List()
		{
			Place place1 = new("Regina");
			Place place2 = new("Saskatoon");
			Place place3 = new("Omaha");
			List<Place> expected = new() { place1, place2, place3 };
			List<Place> actualResult = Place.GetAll();
			CollectionAssert.AreEqual(expected, actualResult);
		}
		
		[TestMethod]
		public void ClearAll_DeletesAllPlaceInList_Void()
		{
			_ = new Place("Bloomington");
			_ = new Place("Woodbury");
			_ = new Place("Hennepin");
			List<Place> expected = new() { };
			Place.ClearAll();
			CollectionAssert.AreEqual(expected, Place.GetAll());
		}
	}
}