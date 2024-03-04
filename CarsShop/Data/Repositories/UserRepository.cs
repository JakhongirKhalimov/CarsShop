

namespace CarsShop.Data.Repositories;

public class UserRepository(CarsDbContext database)
    : Repository<User>(database), IUserInterface
{
}
