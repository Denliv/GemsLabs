using Task7.Enums;
using Task7.Interfaces;

namespace Task7.Models;

public class Bus : AVenicle, IGeneratable
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
}