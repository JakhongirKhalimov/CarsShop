namespace CarsShop.Data.Entities;

public class Cars : BaseEntity
{
    public string Nomi { get; set; } = string.Empty;
    public string Tasnifi { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public int BrendId { get; set; }
    public Brend Brend { get; set; } = new();
    public List<Model> Models { get; set; } = new();
    public List<Colour> Colours { get; set; } = new();
    public List<Order> Orders { get; set; } = new();
}
