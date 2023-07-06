using Task3.Enums;
using Task3.Interfaces;

namespace Task3.Models;

public class Car : AVenicle, IGeneratable
{
    private int _speed;

    public override VenicleBodyType BodyType { get; }

    public Car(VenicleColor color, int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, licensePlateNumber, hasPassenger)
    {
        _speed = speed;
        BodyType = VenicleBodyType.Car;
    }

    public override int GetSpeed()
    {
        return _speed;
    }
    
    public override string ToString()
    {
        return $"VenicleSpeed: {GetSpeed()}\n" + base.ToString();
    }
}