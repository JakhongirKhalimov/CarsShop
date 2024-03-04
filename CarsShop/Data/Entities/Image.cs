namespace CarsShop.Data.Entities;

public class Image : BaseEntity
{
    public string PhotoUrl { get; set; } = string.Empty;
    public int ImageId { get; set; }
    public Colour Colour { get; set; } = new();

}
