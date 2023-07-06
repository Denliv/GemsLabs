using Task3.Enums;

namespace Task3.Models;

public class Truck : AVenicle
{
    private int _speed;
    
    public override VenicleBodyType BodyType { get; }

    public Truck(VenicleColor color, int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, licensePlateNumber, hasPassenger)
    {
        _speed = speed;
        BodyType = VenicleBodyType.Truck;
    }

    public override int GetSpeed()
    {
        return _speed;
    }

    public override string ToString()
    {
        return $"VenicleSpeed: {GetSpeed()}\n" + base.ToString();
    }

    public override AVenicle Create(VenicleColor color, int licensePlateNumber, bool hasPassenger, int speed)
    {
        return new Truck(color, licensePlateNumber, hasPassenger, speed);
    }
}