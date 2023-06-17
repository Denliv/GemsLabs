namespace Task0
{
    internal class Degree
    {
        public static string TransformDegree(int temp, char param)
        {
            return Char.ToUpper(param) == 'C' 
                ? Math.Round(temp * 9.0 / 5 + 32, 2).ToString() + "F"
                : Math.Round((temp - 32) * 5.0 / 9).ToString() + "C";
        }
    }
}
