using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private LocalBusinessContext _db;
    public ShopsController(LocalBusinessContext db)
    {
      _db = db;
    }
    //GET /api/shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get()
    {
      return _db.Shops.ToList();
    }
    //POST api/shops
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }
  }
}