using Task3.Models;

namespace Task3;

public class CheckPoint
{
    private CheckPointStatistics _statistics;
    private List<string> _stolenNumbers;

    public CheckPoint(CheckPointStatistics statistics, List<string> stolenNumbers)
    {
        _statistics = new CheckPointStatistics(statistics);
        _stolenNumbers = stolenNumbers;
    }

    public CheckPointStatistics Statistics
    {
        get => _statistics;
        set => _statistics = new CheckPointStatistics(value);
    }

    public List<string> StolenNumbers
    {
        get => _stolenNumbers;
        set
        {
            _stolenNumbers = new List<string>();
            _stolenNumbers.AddRange(value);
        } 
    }

    public void StartWorking()
    {
        while (!Console.KeyAvailable)
        {
            AVenicle venicle = VenicleGenerator.GenerateVenicle();
            Thread.Sleep(new Random().Next(5, 50) * 100);
            CheckPointService.ShowVenicle(venicle);
            CheckPointService.CheckVenicleType(venicle, ref _statistics);
            CheckPointService.CheckSpeed(venicle, ref _statistics);
            CheckPointService.CheckVenicleThieft(venicle, _stolenNumbers, ref _statistics);
        }
        CheckPointService.ShowStatistics(_statistics);
    }
}