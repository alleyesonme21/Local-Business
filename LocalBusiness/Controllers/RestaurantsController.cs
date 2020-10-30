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
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      return _db.Restaurants.ToList();
    }
    //POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }
  }
}
