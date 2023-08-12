using Task7.Enums;
using Task7.Events_Data;
using Task7.Models;

namespace Task7;

public static class CheckPointService
{
    public static void CheckVenicleType(AVenicle venicle, ref CheckPointStatistics statistics)
    {
        switch (venicle.BodyType)
        {
            case VenicleBodyType.Car:
                statistics.CarsCount++;
                break;
            case VenicleBodyType.Bus:
                statistics.BusesCount++;
                break;
            case VenicleBodyType.Truck:
                statistics.TrucksCount++;
                break;
        }
    }

    public static void CheckSpeed(AVenicle venicle, ref CheckPointStatistics statistics,
        EventHandler<VenicleEventArgs> onVenicleSpeeding)
    {
        statistics.OverallSpeed += venicle.GetSpeed();
        if (venicle.GetSpeed() <= 110) return;
        onVenicleSpeeding.Invoke(null, new VenicleEventArgs(venicle));
        statistics.SpeedLimitBreakersCount++;
    }

    public static void CheckVenicleThieft(AVenicle venicle, List<string> stolenNumbers,
        ref CheckPointStatistics statistics, EventHandler<VenicleEventArgs> onVenicleStolen)
    {
        if (!stolenNumbers.Contains(venicle.LicensePlateNumber.ToString())) return;
        onVenicleStolen.Invoke(null, new VenicleEventArgs(venicle));
        statistics.CarJackersCount++;
    }

    public static void ShowVenicle(AVenicle venicle, EventHandler<VenicleEventArgs> onVeniclePass)
    {
        Console.WriteLine("--------------------------");
        onVeniclePass.Invoke(null, new VenicleEventArgs(venicle));
    }

    public static void ShowStatistics(CheckPointStatistics statistics)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine(statistics.ToString());
    }
}