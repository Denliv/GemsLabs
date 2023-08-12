using Task7.Enums;
using Task7.Models;

namespace Task7.Events_Data;

public class VenicleEventArgs : EventArgs
{
    public VenicleColor Color { get; }
    public VenicleBodyType BodyType { get; }
    public int LicensePlateNumber { get; }
    public bool HasPassenger { get; }

    public VenicleEventArgs(AVenicle venicle)
    {
        Color = venicle.Color;
        BodyType = venicle.BodyType;
        LicensePlateNumber = venicle.LicensePlateNumber;
        HasPassenger = venicle.HasPassenger;
    }

    public override string ToString()
    {
        return $"VenicleBodyType : {BodyType}\nColor: {Color.ToString()}\nLicensePlateNumber: {LicensePlateNumber}\nHasPassenger: {HasPassenger}";
    }
}