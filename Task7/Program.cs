using Task7.Terminals;

namespace Task7;

public static class Program
{
    public static void Main()
    {
        var checkPoint =
            new CheckPoint(new CheckPointStatistics(), new List<string> { "121", "111", "999" });
        using var terminalRandom = new TrafficFlowTerminalRandom(checkPoint);
        using var terminalSpeeding = new TrafficFlowTerminalSpeeding(checkPoint);
        using var terminalStolen = new TrafficFlowTerminalStolen(checkPoint);
        checkPoint.StartWorking();
    }
}