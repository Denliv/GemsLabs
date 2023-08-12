using Task7.Events_Data;
using Task7.Generators;
using Task7.Models;

namespace Task7;

public class CheckPoint
{
    public event EventHandler<VenicleEventArgs> OnVeniclePass = delegate { };
    public event EventHandler<VenicleEventArgs> OnVenicleSpeeding = delegate { };
    public event EventHandler<VenicleEventArgs> OnVenicleStolen = delegate { };
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
            CheckPointService.ShowVenicle(venicle, OnVeniclePass);
            CheckPointService.CheckVenicleType(venicle, ref _statistics);
            CheckPointService.CheckSpeed(venicle, ref _statistics, OnVenicleSpeeding);
            CheckPointService.CheckVenicleThieft(venicle, _stolenNumbers, ref _statistics, OnVenicleStolen);
        }

        CheckPointService.ShowStatistics(_statistics);
    }
}