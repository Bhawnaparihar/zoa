using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Mobile { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
