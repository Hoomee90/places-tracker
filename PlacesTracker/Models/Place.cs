using System.Collections.Generic;

namespace PlacesTracker.Models
{
	public class Place
	{
		
		public string CityName { get; set; }
		private static List<Place> _instances = new() { };
		
		public Place(string city)
		{
			CityName = city;
			_instances.Add(this);
		}
		
		public static List<Place> GetAll()
		{
			return _instances;
		}
		
		public static void ClearAll()
		{
			_instances.Clear();
		}
	}
}