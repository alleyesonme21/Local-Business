﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    partial class LocalBusinessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cuisine");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("city");

                    b.Property<int>("rates");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "286 West MAin St. Meriden",
                            Cuisine = "Italian",
                            Name = "Pizza Heaven",
                            Phone = "203-235-2626",
                            city = "Meriden",
                            rates = 7
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "1085 N Colony Rd, CT 06492",
                            Cuisine = "American",
                            Name = "Chili's Grill & Bar",
                            Phone = "203-235-2626",
                            city = "Wallingford",
                            rates = 4
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "Address: 744 Murdock Ave # 1, CT 06450",
                            Cuisine = "American",
                            Name = "Family Restaurant",
                            Phone = " (203) 235-8161",
                            city = "Meriden",
                            rates = 5
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = " 947 State St, CT 06511",
                            Cuisine = "American",
                            Name = "The Neighborhood Cafe",
                            Phone = " (203) 691-8067",
                            city = "New Haven",
                            rates = 5
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = " 14 Mechanic St,CT 06511",
                            Cuisine = "Mexican",
                            Name = "Mezcal",
                            Phone = "(203)782-4828",
                            city = "New Haven",
                            rates = 5
                        },
                        new
                        {
                            RestaurantId = 6,
                            Address = " 1147 Madison Ave A, Bridgeport, CT 06606",
                            Cuisine = "Haitian",
                            Name = "Ronald's Haitian Cuisine",
                            Phone = " (203) 873-0400",
                            city = "Bridgeport",
                            rates = 5
                        },
                        new
                        {
                            RestaurantId = 7,
                            Address = "1483 Corbin Ave, CT 06053",
                            Cuisine = "Caribbean",
                            Name = "Jackie’s Gourmet Restaurant",
                            Phone = "(860) 224-1467",
                            city = "New Britain",
                            rates = 5
                        });
                });

            modelBuilder.Entity("LocalBusiness.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Types");

                    b.Property<string>("city");

                    b.Property<string>("rates");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Address = "65 Memorial Rd, CT 06107",
                            Name = "Blue Back Square",
                            Phone = "860) 882-0678",
                            Types = "Shopping mall",
                            city = "West Hartford",
                            rates = "Good"
                        },
                        new
                        {
                            ShopId = 2,
                            Address = "288 Baileyville Rd, CT 06455",
                            Name = "Perrotti's Country Barn",
                            Phone = " (860) 349-0082",
                            Types = "Gift Shop",
                            city = "Middlefield",
                            rates = "Good"
                        },
                        new
                        {
                            ShopId = 3,
                            Address = "439 Main St, CT 06492",
                            Name = "CT Gun Broker",
                            Phone = "  (203) 535-9345",
                            Types = "Gun Shop",
                            city = "Wallingford",
                            rates = " Good"
                        },
                        new
                        {
                            ShopId = 4,
                            Address = "120 Hale Rd, CT 06040",
                            Name = "Christmas Tree Shops andThat!",
                            Phone = "(860) 648-9390",
                            Types = "Boutique",
                            city = "Manchester,",
                            rates = "Good"
                        },
                        new
                        {
                            ShopId = 5,
                            Address = " 942 Silas Deane Hwy, CT 06109",
                            Name = "Alpine Haus",
                            Phone = "(860) 563-2244",
                            Types = "Mexican",
                            city = "Wethersfield",
                            rates = "Good"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
