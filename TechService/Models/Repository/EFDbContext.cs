using System.Data.Entity;

namespace TechService.Models.Repository
{
    public class EfDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<HashPass> HashPasses { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}