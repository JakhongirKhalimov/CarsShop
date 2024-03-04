namespace CarsShop.Data.Repositories;

public class UnitOfWork(CarsDbContext database) : IUnitOfWork
{
    public IBrendInterface Brends => new BrendRepository(database);

    public ICarsInterface Cars => new CarsRepository(database);

    public ICategoryInterface Categories => new CategoryRepository(database);

    public IColorInterface Colors => new ColourRepository(database);

    public IImageInterface Images => new ImageRepository(database);

    public IModelInterface Models => new ModelRepository(database);

    public IOrderInterface Orders => new OrderRepository(database);

    public IUserInterface Users => new UserRepository(database);
}
