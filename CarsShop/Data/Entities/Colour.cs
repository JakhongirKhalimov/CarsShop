namespace CarsShop.Data.Entities;

public class Colour : BaseEntity
{
    public string Nomi { get; set; } = string.Empty;
    public string HexCode { get; set; } = string.Empty;
    public int CarId { get; set; }
    public Cars Cars { get; set; } = new();
    public List<Image> Images { get; set; } = new(); 

}
