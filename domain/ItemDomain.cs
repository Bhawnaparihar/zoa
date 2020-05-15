using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class ItemDomain : BaseDomain
    {
        public List<Item> Get(int restaurantId)
        {
            var items = new List<Item>();
            var reader = this.GetReader($"select*from items where restaurantid='{restaurantId}'");
            while (reader.Read())
            {
                var item = new Item();
                item.ItemId = reader.GetInt32(0);
                item.ItemName = reader.GetString(1);
                item.Price = reader.GetInt32(2);
                item.RestaurantId = reader.GetInt32(3);
                item.FoodCategoryId = reader.GetInt32(4);
                items.Add(item);
            }
            return items;
        }
    }
}
