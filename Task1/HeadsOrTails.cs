using System;

namespace Task1
{
    public class HeadsOrTails
    {
        public static void Start()
        {
            Random random = new Random();
            string temp = string.Empty;
            int successfulTries = 0;
            int tries = 0;
            Console.WriteLine("Game started");
            do
            {
                Console.Write("Enter number: ");
                temp = Console.ReadLine();
                if (temp != null && temp.Equals(random.NextInt64(2).ToString()))
                {
                    successfulTries++;
                    Console.WriteLine("You guessed right");
                } else
                {
                    Console.WriteLine("Try again");
                }
                tries++;
            } while (temp.Equals("0") || temp.Equals("1"));
            Console.WriteLine($"Game ended with score {successfulTries}" +
                $", you guessed {Math.Round(successfulTries * 100.0 / tries, 0)}% of throws");
        }
    }
}
