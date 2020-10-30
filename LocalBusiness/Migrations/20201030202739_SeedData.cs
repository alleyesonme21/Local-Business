using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Cuisine", "Name", "Phone", "city", "rates" },
                values: new object[,]
                {
                    { 1, "286 West MAin St. Meriden", "Italian", "Pizza Heaven", "203-235-2626", "Meriden", 7 },
                    { 2, "1085 N Colony Rd, CT 06492", "American", "Chili's Grill & Bar", "203-235-2626", "Wallingford", 4 },
                    { 3, "Address: 744 Murdock Ave # 1, CT 06450", "American", "Family Restaurant", " (203) 235-8161", "Meriden", 5 },
                    { 4, " 947 State St, CT 06511", "American", "The Neighborhood Cafe", " (203) 691-8067", "New Haven", 5 },
                    { 5, " 14 Mechanic St,CT 06511", "Mexican", "Mezcal", "(203)782-4828", "New Haven", 5 },
                    { 6, " 1147 Madison Ave A, Bridgeport, CT 06606", "Haitian", "Ronald's Haitian Cuisine", " (203) 873-0400", "Bridgeport", 5 },
                    { 7, "1483 Corbin Ave, CT 06053", "Caribbean", "Jackie’s Gourmet Restaurant", "(860) 224-1467", "New Britain", 5 }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Address", "Name", "Phone", "Types", "city", "rates" },
                values: new object[,]
                {
                    { 1, "65 Memorial Rd, CT 06107", "Blue Back Square", "860) 882-0678", "Shopping mall", "West Hartford", "Good" },
                    { 2, "288 Baileyville Rd, CT 06455", "Perrotti's Country Barn", " (860) 349-0082", "Gift Shop", "Middlefield", "Good" },
                    { 3, "439 Main St, CT 06492", "CT Gun Broker", "  (203) 535-9345", "Gun Shop", "Wallingford", " Good" },
                    { 4, "120 Hale Rd, CT 06040", "Christmas Tree Shops andThat!", "(860) 648-9390", "Boutique", "Manchester,", "Good" },
                    { 5, " 942 Silas Deane Hwy, CT 06109", "Alpine Haus", "(860) 563-2244", "Mexican", "Wethersfield", "Good" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);
        }
    }
}
