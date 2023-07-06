namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            CheckPoint checkPoint = new CheckPoint(new CheckPointStatistics(), new List<string>(){"121", "111", "999"});
            checkPoint.StartWorking();
        }
    }
}