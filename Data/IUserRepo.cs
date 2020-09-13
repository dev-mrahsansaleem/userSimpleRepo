using System.Collections.Generic;
using userAuth.Models;

namespace userAuth.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();

        User getUserById(int id);

        void CreateUser(User user);

        bool SaveChanges();
    }
}