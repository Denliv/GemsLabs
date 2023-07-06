using Task3.Enums;
using Task3.Models;

namespace Task3;

public class VenicleGenerator
{
    public static AVenicle GenerateVenicle()
    {
        VenicleColor color = (VenicleColor)new Random().Next(Enum.GetNames(typeof(VenicleColor)).Length);
        int licensePlateNumber = new Random().Next(100, 1000);
        bool hasPassenger = new Random().Next(0, 2) != 0;
        VenicleBodyType bodyType = (VenicleBodyType)new Random().Next(Enum.GetNames(typeof(VenicleBodyType)).Length);
        int speed = SpeedGenerator.GenerateSpeed(bodyType);
        var className = bodyType.ToString();
        var type = Type.GetType($"Task3.Models.{className}");
        return ((Activator.CreateInstance(type, color, licensePlateNumber, hasPassenger, speed)) as
            AVenicle);
    }
}