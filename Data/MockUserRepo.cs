using System.Collections.Generic;
using userAuth.Models;

namespace userAuth.Data
{
    public class MockUserRepo : IUserRepo
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var allUsers = new List<User> {
            new User { id = 0, email = "ahsan0@temp.com", username = "admin0", password = "admin" },
            new User { id = 1, email = "ahsan1@temp.com", username = "admin1", password = "admin" },
            new User { id = 2, email = "ahsan2@temp.com", username = "admin2", password = "admin" },
            new User { id = 3, email = "ahsan3@temp.com", username = "admin3", password = "admin" }
            };

            return allUsers;
        }

        public User getUserById(int id)
        {
            return new User { id = 0, email = "ahsan@temp.com", username = "admin", password = "admin" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}