using Task3.Enums;

namespace Task3.Generators;

public class SpeedGenerator
{
    public static int GenerateSpeed(VenicleBodyType bodyType)
    {
        if (bodyType == VenicleBodyType.Car) return new Random().Next(90, 151);
        if (bodyType == VenicleBodyType.Bus) return new Random().Next(80, 111);
        if (bodyType == VenicleBodyType.Truck) return new Random().Next(70, 101);
        throw new ArgumentException("Error: No Such BodyType\n");
    }
}