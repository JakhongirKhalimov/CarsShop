

namespace CarsShop.Data.Repositories;

public class OrderRepository(CarsDbContext database)
    : Repository<Order>(database), IOrderInterface
{
}
