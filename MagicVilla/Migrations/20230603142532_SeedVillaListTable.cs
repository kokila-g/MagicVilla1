using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaList",
                columns: new[] { "Id", "Amenity", "CreatedOn", "ImageURL", "Name", "UpdatedOn", "details", "occupancy", "rate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 6, 3, 19, 55, 32, 130, DateTimeKind.Local).AddTicks(9117), "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "Royal Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 200, 550 },
                    { 2, "", new DateTime(2023, 6, 3, 19, 55, 32, 130, DateTimeKind.Local).AddTicks(9147), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "Premium Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 300, 550 },
                    { 3, "", new DateTime(2023, 6, 3, 19, 55, 32, 130, DateTimeKind.Local).AddTicks(9150), "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "Luxury Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 400, 750 },
                    { 4, "", new DateTime(2023, 6, 3, 19, 55, 32, 130, DateTimeKind.Local).AddTicks(9153), "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "Diamond Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 550, 900 },
                    { 5, "", new DateTime(2023, 6, 3, 19, 55, 32, 130, DateTimeKind.Local).AddTicks(9157), "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "Diamond Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 600, 1100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillaList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VillaList",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VillaList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VillaList",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
