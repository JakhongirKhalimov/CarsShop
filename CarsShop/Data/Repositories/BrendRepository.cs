

namespace CarsShop.Data.Repositories;

public class BrendRepository(CarsDbContext database) 
    : Repository<Brend>(database),IBrendInterface
{
}
