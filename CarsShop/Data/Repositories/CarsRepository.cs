

namespace CarsShop.Data.Repositories;

public class CarsRepository(CarsDbContext database)
    : Repository<Cars>(database), ICarsInterface
{
}
