using Microsoft.EntityFrameworkCore;
using userAuth.Models;

namespace userAuth.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}