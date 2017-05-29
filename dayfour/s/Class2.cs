using System;
using Xunit;


class Class2
{
    delegate void DelegatesSimpleTest();
    static void Main(string[] args)
    {

        DelegatesSimpleTest de = new DelegatesSimpleTest(Callback1);   // ||DelegateEx de = Callback1;
        de();
        de = Callback2;
        de();
        Console.ReadLine();
    }

    static void Callback1()
    {
        Console.WriteLine("Hello!! First this Callback1 method...");
    }
    static void Callback2()
    {
        Console.WriteLine("Hello!! Second this Callback2 method...");
    }
}
