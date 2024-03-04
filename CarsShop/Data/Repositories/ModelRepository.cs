

namespace CarsShop.Data.Repositories;

public class ModelRepository(CarsDbContext database)
    : Repository<Model>(database), IModelInterface
{
}
