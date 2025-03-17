
using Microsoft.Extensions.DependencyInjection;
using EventEase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EventEase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventEaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EventEaseContext>>()))
            {
                // Look for any venues.
                if (context.Venue.Any())
                {
                    return;   // DB has been seeded
                }
                context.Venue.AddRange(
                    new Venue
                    {
                        //VenueId = 1,
                        VenueName = "",
                        Location = "",
                        Capacity = 20,

                    },
                    new Venue
                    {
                        //VenueId = 2,
                        VenueName = "",
                        Location = "",
                        Capacity = 20,
                    },
                    new Venue
                    {
                        //VenueId = 3,
                        VenueName = "",
                        Location = "",
                        Capacity = 20,
                    },
                    new Venue
                    {
                        //VenueId = 4,
                        VenueName = "",
                        Location = "",
                        Capacity = 20,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}



  