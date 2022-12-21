namespace Restaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Address { get; set; }
    public int CuisineId { get; set; }
    public Cuisine Cuisine { get; set; }
  }
}