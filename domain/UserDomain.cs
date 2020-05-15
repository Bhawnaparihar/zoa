using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.domain
{
    public class UserDomain : BaseDomain
    {
        public bool IsLogIn(User user)
        {
            var reader=this.GetReader($"select * from users where username='{user.UserName}' and password='{user.Password}'");
            bool isLoggedIn = false;
            while (reader.Read())
            {
                isLoggedIn = true;
            }
            return isLoggedIn;
        }

        public void IsDelete(int userId)
        {
            /* bool deleteItems = false;
             var reader = this.GetReader($"delete from users where UserId={userId}");
             while (reader.Read())
             {
                 deleteItems = true;
             }
             return deleteItems;*/
            this.ExecuteNonQuery($"delete from users where UserId={userId}");
        }
        
    }
}
