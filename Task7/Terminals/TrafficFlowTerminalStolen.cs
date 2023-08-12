using Task7.Events_Data;

namespace Task7.Terminals;

public class TrafficFlowTerminalStolen : IDisposable
{
    private CheckPoint _checkPoint;

    public TrafficFlowTerminalStolen(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _checkPoint.OnVenicleStolen += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVenicleStolen -= EventHandler;
    }

    private void EventHandler(object? sender, VenicleEventArgs args)
    {
        Console.WriteLine("Interception");
    }
}