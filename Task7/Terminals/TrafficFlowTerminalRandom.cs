using Task7.Events_Data;

namespace Task7.Terminals;

public class TrafficFlowTerminalRandom : IDisposable
{
    private CheckPoint _checkPoint;
    private Random _random;

    public TrafficFlowTerminalRandom(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _random = new Random();
        _checkPoint.OnVeniclePass += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVeniclePass -= EventHandler;
    }

    private void EventHandler(object? sender, VenicleEventArgs args)
    {
        if (_random.Next(0, 2) == 1) Console.WriteLine(args.ToString());
    }
}