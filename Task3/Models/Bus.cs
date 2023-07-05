using Task3.Enums;

namespace Task3.Models;

public class Bus : AVenicle
{
    private int _speed;
    public override VenicleBodyType BodyType { get; }

    public Bus()
    {
        _speed = new Random().Next(80, 111);
        BodyType = VenicleBodyType.Bus;
    }

    public override int GetSpeed()
    {
        return _speed;
    }
}