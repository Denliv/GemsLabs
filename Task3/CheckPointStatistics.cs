namespace Task3;

public class CheckPointStatistics
{
    public int CarsCount { get; set; }
    public int TrucksCount { get; set; }
    public int BusesCount { get; set; }
    public int SpeedLimitBreakersCount { get; set; }
    public int CarJackersCount { get; set; }
    public int OverallSpeed { get; set; }

    public int AverageSpeed
    {
        get => OverallSpeed / (CarsCount + BusesCount + TrucksCount);
    }

    public CheckPointStatistics() : this(0, 0, 0, 0, 0, 0)
    {
    }

    public CheckPointStatistics(CheckPointStatistics statistics) :
        this(statistics.CarsCount,
            statistics.TrucksCount,
            statistics.BusesCount,
            statistics.SpeedLimitBreakersCount,
            statistics.CarJackersCount,
            statistics.OverallSpeed)
    {
    }

    public CheckPointStatistics(int carsCount, int trucksCount, int busesCount, int speedLimitBreakersCount,
        int carJackersCount, int overallSpeed)
    {
        CarsCount = carsCount;
        TrucksCount = trucksCount;
        BusesCount = busesCount;
        SpeedLimitBreakersCount = speedLimitBreakersCount;
        CarJackersCount = carJackersCount;
        OverallSpeed = overallSpeed;
    }

    public override string ToString()
    {
        return $"CarsCount: {CarsCount}\nTrucksCount: {TrucksCount}\nBusesCount:{BusesCount}\n" +
               $"SpeedLimitBreakersCount: {SpeedLimitBreakersCount}\nCarJackersCount: {CarJackersCount}" +
               $"\nAverageSpeed: {AverageSpeed}";
    }
}