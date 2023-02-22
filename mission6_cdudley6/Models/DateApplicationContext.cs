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
        public DbSet<Category> Categorys { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName="Thriller"},
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Comedy" }
                );
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title = "Get Out",
                    Year = 2017,
                    Director = "Keenan Peele",
                    Rating = "R"

                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 2,
                    Title = "Fight Club",
                    Year = 1998,
                    Director = "David Fincher",
                    Rating = "R"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 2,
                    Title = "Dark Knight",
                    Year = 2011,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                }
                );
        }
    }
}
