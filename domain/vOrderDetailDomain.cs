using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class vOrderDetailDomain : BaseDomain
    {
        public void Add(vOrderDetail orderDetail)
        {
            this.ExecuteNonQuery($"insert into vCartOrderDetails(UserId,UserName,Mobile,Address,ItemId,Price,OrderItemId,CartId,Quantity) values ({orderDetail.UserId},{orderDetail.UserName},{orderDetail.Mobile},{orderDetail.Address},{orderDetail.ItemId},{orderDetail.Price},{orderDetail.OrderItemId},{orderDetail.CartId},{orderDetail.Quantity}");
        }
        public List<vOrderDetail> Get(int userId)
        {
            var orderDetails = new List<vOrderDetail>();
            var reader = this.GetReader($"select*from vOrderDetails where UserId={userId}");
            while (reader.Read())
            {
                var orderDetail = new vOrderDetail();
                orderDetail.UserId = reader.GetInt32(0);
                orderDetail.UserName = reader.GetString(1);
                orderDetail.Mobile = reader.GetInt32(2);
                orderDetail.Address = reader.GetString(3);
                orderDetail.ItemId = reader.GetInt32(4);
                orderDetail.Price = reader.GetInt32(5);
                orderDetail.OrderItemId = reader.GetInt32(6);
                orderDetail.CartId = reader.GetInt32(7);
                orderDetail.Quantity = reader.GetInt32(8);
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }

    }
}
