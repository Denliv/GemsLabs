using Task3.Enums;

namespace Task3.Models;

public abstract class AVenicle
{
    public VenicleColor Color { get; }
    public virtual VenicleBodyType BodyType { get; }
    public int LicensePlateNumber { get; }
    public bool HasPassenger { get; }

    protected AVenicle(VenicleColor color, int licensePlateNumber, bool hasPassenger)
    {
        Color = color;
        LicensePlateNumber = licensePlateNumber;
        HasPassenger = hasPassenger;
    }

    public virtual int GetSpeed()
    {
        return 0;
    }

    public virtual AVenicle Create(VenicleColor color, int licensePlateNumber, bool hasPassenger, int speed)
    {
        throw new ArgumentException("Error\n");
    }

    public override string ToString()
    {
        return $"VenicleBodyType : {BodyType}\nColor: {Color.ToString()}\nLicensePlateNumber: {LicensePlateNumber}\nHasPassenger: {HasPassenger}";
    }
}