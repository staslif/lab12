csharp
using System;
using System.Threading;

class Program
{
    private static readonly object lockObject = new object();
    private static string lastWord = "";

    static void Main(string[] args)
    {
        Thread chickenThread = new Thread(PrintChicken);
        Thread eggThread = new Thread(PrintEgg);

        chickenThread.Start();
        eggThread.Start();

        chickenThread.Join();
        eggThread.Join();
    }

    private static void PrintChicken()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                lastWord = "Курица";
                Console.WriteLine(lastWord);
                Thread.Sleep(100); // Задержка для наглядности
            }
        }
    }

    private static void PrintEgg()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                lastWord = "Яйцо";
                Console.WriteLine(lastWord);
                Thread.Sleep(100); // Задержка для наглядности
            }
        }
    }
}
