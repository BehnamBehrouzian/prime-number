
class Program
{
    static void Main()
    {
        Console.WriteLine("enter number 1 :");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("enter number 2 :");
        int num2 = int.Parse(Console.ReadLine());

        for (int i = num1; i <= num2; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    // تابع برای بررسی اول بودن عدد
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}