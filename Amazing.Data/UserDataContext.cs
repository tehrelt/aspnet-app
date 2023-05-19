using Microsoft.EntityFrameworkCore;

namespace Amazing.Data
{
    public class UserDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }
    }
}
