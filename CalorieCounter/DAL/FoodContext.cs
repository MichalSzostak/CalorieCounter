using System;
using CalorieCounter.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CalorieCounter.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(): base ("FoodContext")
        { 
            Database.SetInitializer<FoodContext>(new DropCreateDatabaseIfModelChanges<FoodContext>());
        }

        public DbSet<FoodItem> foodItems { get; set; }
        public DbSet<FoodPhoto> foodPhotos { get; set; }

       
    }
}