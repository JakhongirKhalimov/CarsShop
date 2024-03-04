namespace CarsShop.Data.Interfaces;

public interface IUnitOfWork
{
    IBrendInterface Brends { get; }
    ICarsInterface Cars { get; }
    ICategoryInterface Categories { get; }
    IColorInterface Colors { get; }
    IImageInterface Images { get; }
    IModelInterface Models { get; }
    IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
