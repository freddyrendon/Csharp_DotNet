using models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UserContext : Dbcontext
    {
        public UserContext(DbcontextOptions<UserContext> options) : base(options)
        {
        }
        
        public Dbset<User> Users { get; set; }
    }
}