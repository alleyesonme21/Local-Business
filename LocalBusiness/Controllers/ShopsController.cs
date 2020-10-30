using Microsoft.EntityFrameworkCore;
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
    public ActionResult<IEnumerable<Shop>> Get( string name, string address, string phone, string types, string city, string rate)
    {
      var query = _db.Shops.AsQueryable();

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

      if (types != null)
      {
        query = query.Where(x => x.Types == types);
      }

      if (city != null)
      {
        query = query.Where(x => x.city == city);
      }
      if (rate != null)
      {
        query = query.Where(x => x.rates == rate);
      }
  
      return query.ToList();
    }
    //POST api/shops
    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(x => x.ShopId == id);
    }
    //PUT /api/shops
    [HttpPut("id")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE / api/shops/4
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shop = _db.Shops.FirstOrDefault(x => x.ShopId == id);
      _db.Shops.Remove(shop);
      _db.SaveChanges();
    }
  }
}