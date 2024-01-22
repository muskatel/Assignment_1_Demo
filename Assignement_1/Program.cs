namespace Assignement_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Craig");
        
        CountTo(4);
    }

    static void CountTo(int num)
    {
        Console.WriteLine("Counting to "+ num + "...");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}