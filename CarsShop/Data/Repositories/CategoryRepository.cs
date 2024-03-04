

namespace CarsShop.Data.Repositories;

public class CategoryRepository(CarsDbContext database) :
    Repository<Category>(database),ICategoryInterface
{
   
}
