using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationApp17._01.Models
{
    public class UserData
    {
       private static readonly List<User> Users = new List<User>();

        static UserData()
        {
            Users.Add(new User { Id = 1, Name = "Sorin", Email = "sorin@yahoo.com" });
            Users.Add(new User { Id = 2, Name = "Gabi", Email = "gabin@yahoo.com" });
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        public UserData()
        {
        }

      

        public User GetUser(int id)
        {
            return Users.Find(x => x.Id == id);
        }
    }

}
