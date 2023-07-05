using Task3.Enums;

namespace Task3.Models;

public class Car : AVenicle
{
    private int _speed;
    public override VenicleBodyType BodyType { get; }

    public Car()
    {
        _speed = new Random().Next(90, 151);
        BodyType = VenicleBodyType.Car;
    }

    public override int GetSpeed()
    {
        return _speed;
    }
}