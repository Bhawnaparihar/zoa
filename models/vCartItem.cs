using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class vCartItem
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}
