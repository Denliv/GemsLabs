using Task7.Events_Data;

namespace Task7.Terminals;

public class TrafficFlowTerminalSpeeding : IDisposable
{
    private CheckPoint _checkPoint;

    public TrafficFlowTerminalSpeeding(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _checkPoint.OnVenicleSpeeding += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVenicleSpeeding -= EventHandler;
    }

    private void EventHandler(object? sender, VenicleEventArgs args)
    {
        Console.WriteLine("WARNING: Speed Limit Exceed");
    }
}