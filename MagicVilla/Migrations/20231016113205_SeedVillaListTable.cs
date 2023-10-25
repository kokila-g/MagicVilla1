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
            migrationBuilder.CreateTable(
                name: "VillaList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    occupancy = table.Column<int>(type: "int", nullable: false),
                    sqft = table.Column<int>(type: "int", nullable: false),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rate = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VillaList",
                columns: new[] { "Id", "Amenity", "CreatedOn", "ImageURL", "Name", "UpdatedOn", "details", "occupancy", "rate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 10, 16, 17, 2, 5, 860, DateTimeKind.Local).AddTicks(4389), "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "Royal Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 200, 550 },
                    { 2, "", new DateTime(2023, 10, 16, 17, 2, 5, 860, DateTimeKind.Local).AddTicks(4405), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "Premium Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 300, 550 },
                    { 3, "", new DateTime(2023, 10, 16, 17, 2, 5, 860, DateTimeKind.Local).AddTicks(4406), "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "Luxury Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 400, 750 },
                    { 4, "", new DateTime(2023, 10, 16, 17, 2, 5, 860, DateTimeKind.Local).AddTicks(4408), "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "Diamond Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 550, 900 },
                    { 5, "", new DateTime(2023, 10, 16, 17, 2, 5, 860, DateTimeKind.Local).AddTicks(4409), "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "Diamond Pool Villa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", 4, 600, 1100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaList");
        }
    }
}
