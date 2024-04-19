namespace PlacesTracker.Models
{
	public class Place
	{
		
		public string CityName { get; set; }
		public Place(string city)
		{
			CityName = city;
		}
	}
}