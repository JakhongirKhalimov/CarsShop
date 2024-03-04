namespace CarsShop.Data.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<Cars> Cars { get; set; } = new();
}
