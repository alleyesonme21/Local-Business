using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private LocalBusinessContext _db;
    public RestaurantsController(LocalBusinessContext db)
    {
      _db = db;
    }
    //GET /api/restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get( string name, string address, string phone, string cuisine, string city)
    {
      var query = _db.Restaurants.AsQueryable();

      if (name != null)
      {
        query = query.Where(x => x.Name == name);
      }

      if (address != null)
      {
        query = query.Where(x => x.Address == address);
      }

      if (phone != null)
      {
        query = query.Where(x => x.Phone == phone);
      }

      if (cuisine != null)
      {
        query = query.Where(x => x.Cuisine == cuisine);
      }

      if (city != null)
      {
        query = query.Where(x => x.city == city);
      }
  
      return query.ToList();
    }
    //POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }
    // GET/api/restaurants/4
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(x => x.RestaurantId == id);
    }
    //PUT /api/restaurants
    [HttpPut("id")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE / api/restaurants/4
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurant = _db.Restaurants.FirstOrDefault(x => x.RestaurantId == id);
      _db.Restaurants.Remove(restaurant);
      _db.SaveChanges();
    }
  }
}
