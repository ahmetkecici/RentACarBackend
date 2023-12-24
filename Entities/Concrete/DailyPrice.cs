namespace Entities.Concrete;

public class DailyPrice
{
    public int Id { get; set; }

    public int CurrencyId { get; set; }
    public int CarId { get; set; }
    public double Price { get; set; }

}