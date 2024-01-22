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
    /// <param name="n">The number to count until</param>
    static void CountTo(int n)
    {
        Console.WriteLine("Counting to "+ n + "...");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
