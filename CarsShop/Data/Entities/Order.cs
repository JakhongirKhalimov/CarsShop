namespace CarsShop.Data.Entities;

public class Order : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = new User();
    public DateTime Date { get; set; } = DateTime.Now;
    public int CarId { get; set; }
    public Cars Cars { get; set; } = new Cars();
    public string ColorName { get; set; } = null!;
    public string ModelId { get; set; } = null!;
    public double Narxi { get; set; }


}
