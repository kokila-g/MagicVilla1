using MagicVilla.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { 
        }
        public DbSet<Villa> VillaList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageURL = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    occupancy = 4,
                    rate = 200,
                    sqft = 550,
                    Amenity = "",
                    CreatedOn = DateTime.Now
                },
               new Villa
               {
                   Id = 2,
                   Name = "Premium Pool Villa",
                   details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                   ImageURL = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                   occupancy = 4,
                   rate = 300,
                   sqft = 550,
                   Amenity = "",
                   CreatedOn = DateTime.Now
               },
               new Villa
               {
                   Id = 3,
                   Name = "Luxury Pool Villa",
                   details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                   ImageURL = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                   occupancy = 4,
                   rate = 400,
                   sqft = 750,
                   Amenity = "",
                   CreatedOn = DateTime.Now
               },
               new Villa
               {
                   Id = 4,
                   Name = "Diamond Villa",
                   details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                   ImageURL = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                   occupancy = 4,
                   rate = 550,
                   sqft = 900,
                   Amenity = "",
                   CreatedOn = DateTime.Now
               },
               new Villa
               {
                   Id = 5,
                   Name = "Diamond Pool Villa",
                   details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                   ImageURL = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                   occupancy = 4,
                   rate = 600,
                   sqft = 1100,
                   Amenity = "",
                   CreatedOn = DateTime.Now
               });
        }
    }
}
