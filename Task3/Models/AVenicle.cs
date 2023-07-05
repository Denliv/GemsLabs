using Task3.Enums;

namespace Task3.Models;

public abstract class AVenicle
{
    public VenicleColor Color { get; }
    public abstract VenicleBodyType BodyType { get; }
    public int LicensePlateNumber { get; }
    public bool HasPassenger { get; }

    protected AVenicle()
    {
        Color = (VenicleColor)new Random().Next(Enum.GetNames(typeof(VenicleColor)).Length);
        LicensePlateNumber = new Random().Next(100, 1000);
        HasPassenger = new Random().Next(0, 2) != 0;
    }

    public virtual int GetSpeed()
    {
        return 0;
    }
}