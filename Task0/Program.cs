using System.Text.RegularExpressions;

namespace Task0;

public class Program
{
    public static void Main()
    {
        string? temp;
        do
        {
            Console.Clear();
            Console.Write("Enter the year: ");
            temp = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(temp)
                 || !Regex.IsMatch(temp, @"^\d+"));

        var year = int.Parse(temp);
        Console.WriteLine($"{year} - is {(Year.CheckYear(year) ? "" : "not ")}leap year");
        Console.ReadKey();
        do
        {
            Console.Clear();
            Console.Write("Enter the temperature with scale(F(f) or C(c)): ");
            temp = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(temp)
                 || !Regex.IsMatch(temp, @"^\d+[Ff|Cc]"));

        int degree = int.Parse(temp.Substring(0, temp.Length - 1));
        char param = temp.ElementAt(temp.Length - 1);
        Console.WriteLine($"Result: {Degree.TransformDegree(degree, param)}");
        Console.ReadKey();
    }
}