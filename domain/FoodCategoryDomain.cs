using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class FoodCategoryDomain : BaseDomain
    {
        public List<FoodCategory> Get(int restaurantId)
        {
            var foodCategories = new List<FoodCategory>();
            var reader = this.GetReader($"select*from items where restaurantid='{restaurantId}'");
            while (reader.Read())
            {
                var foodCategory = new FoodCategory();
                foodCategory.FoodCategoryId = reader.GetInt32(0);
                foodCategory.FoodCategoryName = reader.GetString(1);
                foodCategory.Ammount = reader.GetInt32(2);
                foodCategories.Add(foodCategory);
            }
            return foodCategories;
        }
    }
}
