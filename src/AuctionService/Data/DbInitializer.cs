
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class DbInitializer
    {
        public static void SeedData(WebApplication app)
        { 
            var scope = app.Services.CreateScope();
            var  context = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
            Seeding(context);
        }

        private static void Seeding(ApplicationDBContext context)
        {
            context.Database.Migrate();
            if(context.Auctions.Any())
            {
                return; // Data already seeded
            }
            var auctions = new List<Entities.Auction>
            {
                new Entities.Auction
                {
                    Id = Guid.NewGuid(),
                    Status = AuctionStatus.Live,
                    ReservePrice = 55400000,
                    Seller ="Patil",
                    AuctionEnd = DateTime.UtcNow.AddDays(10),
                    
                
                  
                    Property = new Entities.Property
                    {
                        Title ="Row House OneSun",
                        Description = "Description for Auction 1",
                      Bedrooms = 4,
                      Bathrooms = 4,
                      AreaSqFt = 4500,
                        Address = "123 Main St",
                        City = "City A",
                        State = "State A",
                       
                    }
                },
                new Entities.Auction
                {
                    Id = Guid.NewGuid(),
                    Status = AuctionStatus.Finished,
                    ReservePrice = 65400000,
                    Seller ="Chavan",
                    AuctionEnd = DateTime.UtcNow.AddDays(10),
                  
                    Property = new Entities.Property
                    {
                        Title ="Row House OneMoon",
                          Description = "Description for Auction 2",
                           Bedrooms = 6,
                      Bathrooms = 5,
                        AreaSqFt = 5500,
                        Address = "456 Elm St",
                        City = "City B",
                        State = "State B",
                      
                    }
                }
            };
            context.Auctions.AddRange(auctions);
            context.SaveChanges();
        }
    }
}
