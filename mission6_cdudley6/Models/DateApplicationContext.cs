using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_cdudley6.Models
{
    public class DateApplicationContext : DbContext
    {
        // constructor
        public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base(options)
        {
            //blank
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Thriller",
                    Title = "Get Out",
                    Year = 2017,
                    Director = "Keenan Peele",
                    Rating = "R"

                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Thriller",
                    Title = "Fight Club",
                    Year = 1998,
                    Director = "David Fincher",
                    Rating = "R"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Action",
                    Title = "Dark Knight",
                    Year = 2011,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                }
                );
        }
    }
}
