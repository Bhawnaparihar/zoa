using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class PlaceOrderDomain : BaseDomain
    {
        public void Add(PlaceOrder placeOrder)
        {
            this.ExecuteNonQuery($"insert into placeorders (Payment)values({placeOrder.Payment})");
        }
       
        
    }
}
