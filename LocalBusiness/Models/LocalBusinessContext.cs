using Microsoft.EntityFrameworkCore;
namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    { 
    }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Shop> Shops { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Restaurant>()
      .HasData(
        new Restaurant { RestaurantId = 1, Name = "Pizza Heaven", Address = "286 West MAin St. Meriden", Phone = "203-235-2626", Cuisine = "Italian", city = "Meriden", rates = 7 },

        new Restaurant { RestaurantId = 2, Name = "Chili's Grill & Bar", Address = "1085 N Colony Rd, CT 06492", Phone = "203-235-2626", Cuisine = "American", city = "Wallingford", rates = 4 },

        new Restaurant { RestaurantId = 3, Name = "Family Restaurant", Address = "Address: 744 Murdock Ave # 1, CT 06450", Phone = " (203) 235-8161", Cuisine = "American", city = "Meriden", rates = 5 },

        new Restaurant { RestaurantId = 4, Name = "The Neighborhood Cafe", Address = " 947 State St, CT 06511", Phone = " (203) 691-8067", Cuisine = "American", city = "New Haven", rates = 5 },

        new Restaurant { RestaurantId = 5, Name = "Mezcal", Address = " 14 Mechanic St,CT 06511", Phone = "(203)782-4828", Cuisine = "Mexican", city = "New Haven", rates = 5 },

        new Restaurant { RestaurantId = 6, Name = "Ronald's Haitian Cuisine", Address = " 1147 Madison Ave A, Bridgeport, CT 06606", Phone = " (203) 873-0400", Cuisine = "Haitian", city = "Bridgeport", rates = 5 },

        new Restaurant { RestaurantId = 7, Name = "Jackie’s Gourmet Restaurant", Address = "1483 Corbin Ave, CT 06053", Phone = "(860) 224-1467", Cuisine = "Caribbean", city = "New Britain", rates = 5 }
      );


      builder.Entity<Shop>()
      .HasData(
        new Shop { ShopId = 1, Name = "Blue Back Square", Address = "65 Memorial Rd, CT 06107", Phone = "860) 882-0678", Types= "Shopping mall", city = "West Hartford", rates = "Good" },

        new Shop { ShopId = 2, Name = "Perrotti's Country Barn", Address = "288 Baileyville Rd, CT 06455", Phone = " (860) 349-0082", Types= "Gift Shop", city = "Middlefield", rates = "Good" },

        new Shop { ShopId = 3, Name = "CT Gun Broker", Address = "439 Main St, CT 06492", Phone = "  (203) 535-9345", Types= "Gun Shop", city = "Wallingford", rates = " Good" },

        new Shop { ShopId = 4, Name = "Christmas Tree Shops andThat!", Address = "120 Hale Rd, CT 06040", Phone = "(860) 648-9390", Types= "Boutique", city = "Manchester,", rates = "Good" },

        new Shop { ShopId = 5, Name = "Alpine Haus", Address = " 942 Silas Deane Hwy, CT 06109", Phone = "(860) 563-2244", Types= "Mexican", city = "Wethersfield", rates = "Good" }
      );
    }
  }
}