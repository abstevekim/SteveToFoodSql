using Microsoft.EntityFrameworkCore;
using SteveToFoodSql.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteveToFoodSql.Data
{
    public class SteveToFoodDbContext : DbContext
    {
        public SteveToFoodDbContext(DbContextOptions<SteveToFoodDbContext> options)
            : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
