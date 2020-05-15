using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int PlaceorderId { get; set; }

        
    }
}
