using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitFixMe
{
    class Program
    {
        static void Main(string[] args)
        {
            CalAsync();
            var x = Console.ReadLine();
        }
        
        private static async void CalAsync()
        {

            // Eq = Func1() + Func2() + Func4(Func3())
            // Result = 90 + 100 + (55*2) = 300 mm

            Console.WriteLine("Running CalAsync Method");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int rf1 = 0, rf2 = 0, rf3 = 0, rf4 = 0;

            Task<int> t1 = Func1();
            Console.WriteLine("Calculating Func1....");

            Task<int> t2 = Func2();
            Console.WriteLine("Calculating Func2....");
            
            Task<int> t3 = Func3();
            Console.WriteLine("Calculating Func3....");
            rf3 = await t3;

            Task<int> t4 = Func4(rf3);
            Console.WriteLine("Calculating Func4....");
            int []rf3_and_rf4 = await Task.WhenAll(t3, t4);
            rf4 = rf3_and_rf4[1];

            rf1 = t1.Result;
            rf2 = t2.Result;
            int sum = rf1 + rf2 + rf4;

            stopWatch.Stop();
            Console.WriteLine("Func1 : " + rf1);
            Console.WriteLine("Func2 : " + rf2);
            Console.WriteLine("Func3 : " + rf3);
            Console.WriteLine("Func4 : " + rf4);
            Console.WriteLine("Result Func1() + Func2() + Func4(Func3()) : " + sum);
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Elapsed time :" + ts.TotalMilliseconds);
        }
        
        private static Task<int> Func1()
        {
            return Task.Run<int>(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += 9;
                    Thread.Sleep(1000);
                }
                return sum;
            });
        }

        private static Task<int> Func2()
        {

            return Task.Run<int>(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += 10;
                    Thread.Sleep(500);

                }
                return sum;
            });
        }
        
        private static Task<int> Func3()
        {
            return Task.Run<int>(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += i;
                    Thread.Sleep(500);
                }
                return sum;
            });
        }

        private static Task<int> Func4(int num = 0)
        {
            Thread.Sleep(2000);
            return Task.FromResult(num*2);
        }
    }
}
