using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesTracker.Models;

namespace PlacesTracker.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
		public void PlaceConstructor_CreateInstanceOfPlace_Place()
		{
			Place newPlace = new("Winnipeg");
			Assert.AreEqual(typeof(Place), newPlace.GetType());
		}
		
		[TestMethod]
		public void GetCityName_ReturnsCityName_IntArray()
		{
			string cityName = "Fargo";
			Place newPlace = new(cityName);
			string result = newPlace.CityName;
			Assert.AreEqual(cityName, result);
		}
		
		[TestMethod]
		public void SetCityName_SetsValueOfCityName_Void()
		{
			Place newPlace = new("Williston");
			string newCityName = "Minneapolis";
			newPlace.CityName = newCityName;
			Assert.AreEqual(newCityName, newPlace.CityName);
		}
  }
}