using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalorieCounter.Models
{
    public class FoodItem
    {

        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Calories")]
        public int calories { get; set; }
        [Display(Name = "Category")]
        public string category { get; set; }
        [Display(Name = "photoID")]
        public int? photoID { get; set; }

        public FoodItem()
        {

        }
    

        public FoodItem(int iD, string name, int calories, string category, int? photoID)
        {
            ID = iD;
            this.name = name;
            this.calories = calories;
            this.category = category;
            this.photoID = photoID;
        }
    }
}