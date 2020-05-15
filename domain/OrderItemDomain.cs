using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class OrderItemDomain :BaseDomain
    {
        public List<OrderItem> Get(int itemId)
        {
            var reader = this.GetReader($"select*from itemid='{itemId}'");
            var orderItems = new List<OrderItem>();
            while (reader.Read())
            {
                var orderItem = new OrderItem();
                orderItem.OrderItemId = reader.GetInt32(0);
                orderItem.UserId = reader.GetInt32(1);
                orderItem.ItemId = reader.GetInt32(2);
                orderItem.PlaceorderId = reader.GetInt32(3);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}
