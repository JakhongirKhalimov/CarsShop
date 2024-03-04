

namespace CarsShop.Data.Repositories;

public class ColourRepository(CarsDbContext database)
    : Repository<Colour>(database), IColorInterface
{
}
