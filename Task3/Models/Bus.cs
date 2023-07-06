using Task3.Enums;

namespace Task3.Models;

public class Bus : AVenicle
{
    private int _speed;
    
    public override VenicleBodyType BodyType { get; }

    public Bus(VenicleColor color, int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, licensePlateNumber, hasPassenger)
    {
        _speed = speed;
        BodyType = VenicleBodyType.Bus;
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
        return new Bus(color, licensePlateNumber, hasPassenger, speed);
    }
}