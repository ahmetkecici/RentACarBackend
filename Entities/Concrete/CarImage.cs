namespace Entities.Concrete;

public class CarImage
{
    public int Id { get; set; }

    public string Path { get; set; }
    public int CarId { get; set; }
    public bool IsMain { get; set; }


}