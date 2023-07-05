using Task3.Enums;

namespace Task3.Models;

public class Truck : AVenicle
{
    private int _speed;
    public override VenicleBodyType BodyType { get; }

    public Truck()
    {
        _speed = new Random().Next(70, 101);
        BodyType = VenicleBodyType.Truck;
    }

    public override int GetSpeed()
    {
        return _speed;
    }
}