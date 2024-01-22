namespace Assignement_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Craig");
        
        CountTo(4);
    }

    /// <summary>
    /// Counts from zero to the provided number.
    /// </summary>
    /// <param name="number">The number to count until</param>
    static void CountTo(int number)
    {
        Console.WriteLine("Counting to "+ number + "...");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}