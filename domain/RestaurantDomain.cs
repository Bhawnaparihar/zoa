using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class RestaurantDomain : BaseDomain
    {
        public List<Restaurant> Get()
        {
            var reader = this.GetReader($"select * from Restaurants");
            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                var restaurant = new Restaurant();
                restaurant.RestaurantName = reader.GetString(1);
                restaurant.RestaurantId = reader.GetInt32(0);
                restaurant.Address = reader.GetString(2);
                restaurants.Add(restaurant);
            }
            return restaurants;
        }
    }
}
