using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            string temp = string.Empty;
            List<string> list = new List<string>();
            Console.WriteLine("Part1\n" +
                "Enter the words with ENTER as separator between words\n" +
                "Enter \"exit\" to end");
            do
            {
                temp = Console.ReadLine();
                list.Add(temp);
            } while (!temp.Equals("exit"));
            Console.WriteLine($"The longest word: {LongestWord.getLongestWord(list)}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Part2");
            HeadsOrTails.Start();
        }
    }
}
