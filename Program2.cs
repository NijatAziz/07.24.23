public class Program
{
    public static int Add3ToLeft(int number)
    {
        int powerOf10 = 1;
        while (powerOf10 <= number)
            powerOf10 *= 10;

        return 3 * powerOf10 + number;
    }

    public static void Main()
    {
        int originalNumber = 8675;
        int modifiedNumber = Add3ToLeft(originalNumber);
        Console.WriteLine(modifiedNumber); 
    }
}