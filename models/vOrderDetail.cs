using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class vOrderDetail
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public int ItemId { get; set; }
        public int Price { get; set; }
        public int OrderItemId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
    }
}
