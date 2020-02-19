using System.Collections.Generic;
using OnlineTourismManagement.Entity;
namespace OnlineTourismManagement.DAL
{
    public class UserRepository
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public static void AddUser(UserDetails user)
        {
            userList.Add(user);
        }
    }
}
