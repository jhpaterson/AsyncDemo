using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading;
using System.Text;

namespace AsyncDemo.Models
{
    public class UserListService : IUserListService
    {
        public List<User> GetUserList()
        {
            List<User> users = new List<User>{
                new User{Firstname="Fernando", Lastname="Alonso"},
                new User{Firstname="Alain", Lastname="Prost"},
                new User{Firstname="Emerson", Lastname="Fittipaldi"}
            };

            Thread.Sleep(5000);

            return users;
        }
    }
}
