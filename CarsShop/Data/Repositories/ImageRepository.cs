namespace CarsShop.Data.Repositories;

public class ImageRepository(CarsDbContext database)
    : Repository<Image>(database), IImageInterface
{
}
