using System;
public delegate void BreakEventHandler();

class Program
{

    static void Walk()
    {
        ConsoleKeyInfo keyinfo;
        do
        {        
            Console.WriteLine("Start walking...press X to stop walking");
            keyinfo = Console.ReadKey();
               Console.WriteLine("\nWalking stop");
        }
        while (keyinfo.Key != ConsoleKey.X);

    }
      static void Run()
    {
             ConsoleKeyInfo keyinfo;
        do
        {
            Console.WriteLine("Start running...press X to stop running");
            keyinfo = Console.ReadKey();
            Console.WriteLine("\nRuning stop");
        }
        while (keyinfo.Key != ConsoleKey.X);
    }
    public static event BreakEventHandler _distance;
    static void Main()
    {
        _distance += new BreakEventHandler(Run);
        _distance += new BreakEventHandler(Walk);
        _distance.Invoke();
    }

   
}