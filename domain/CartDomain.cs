using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class CartDomain : BaseDomain
    {
        public void Add(Cart cart)
        {
            this.ExecuteNonQuery($"insert into carts (ItemId,UserId,Quantity)values({cart.ItemId},{cart.UserId},{cart.Quantity})");
        }
        public List<vCartItem> Get(int userId)
        {
            var cartItems = new List<vCartItem>();
            var reader = this.GetReader($"select * from vCart where userid={userId}");
            while(reader.Read())
            {
                var cartItem = new vCartItem();
                cartItem.ItemName = reader.GetString(0);
                cartItem.Price = reader.GetInt32(1);
                cartItem.Quantity = reader.GetInt32(2);
                cartItems.Add(cartItem);
            }
            return cartItems;
        }
    }
}
