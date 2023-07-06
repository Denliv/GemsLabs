using Task3.Enums;
using Task3.Models;

namespace Task3;

public class CheckPointService
{
    public static void CheckVenicleType(AVenicle venicle, ref CheckPointStatistics statistics)
    {
        if (venicle.BodyType == VenicleBodyType.Car) statistics.CarsCount++;
        else if (venicle.BodyType == VenicleBodyType.Bus) statistics.BusesCount++;
        else if (venicle.BodyType == VenicleBodyType.Truck) statistics.TrucksCount++;
    }

    public static void CheckSpeed(AVenicle venicle, ref CheckPointStatistics statistics)
    {
        statistics.OverallSpeed += venicle.GetSpeed();
        if (venicle.GetSpeed() > 110)
        {
            Console.WriteLine("WARNING: Speed Limit Exceed");
            statistics.SpeedLimitBreakersCount++;
        }
    }

    public static void CheckVenicleThieft(AVenicle venicle, List<string> stolenNumbers, ref CheckPointStatistics statistics)
    {
        if (stolenNumbers.Contains(venicle.LicensePlateNumber.ToString()))
        {
            Console.WriteLine("Interception");
            statistics.CarJackersCount++;
        }
    }
    
    public static void ShowVenicle(AVenicle venicle)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine(venicle.ToString());
    }

    public static void ShowStatistics(CheckPointStatistics statistics)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine(statistics.ToString());
    }
}