namespace CarsShop.Data.Entities;

public class Model : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int CarId { get; set; }
    public Cars Car { get; set; } = new();
    public double Narx { get; set; }
}
