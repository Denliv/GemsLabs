namespace Task0;

public class Year
{
    public static bool CheckYear(int year)
    {
        return year >= 1 && (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
    }
}