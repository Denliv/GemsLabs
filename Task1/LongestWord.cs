namespace Task1
{
    public class LongestWord
    {
        public static string GetLongestWord(List<string> words)
        {
            string result = string.Empty;
            foreach (string i in words)
            {
                if (i.Length > result.Length)
                {
                    result = i;
                }
            }
            return $"\"{result.ToUpper()}\" ({result.Length})";
        }
    }
}
