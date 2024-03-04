    

namespace CarsShop.Data;

public class CarsDbContext : DbContext
{
    public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
    { }
    public DbSet<Brend> Brends { get; set; }
    public DbSet<Cars> Cars { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Colour> Colours { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }


}

