using System;
using Xunit;
public delegate void OnBadWeatherHandler(object sender, EventArgs e);

class EventExample
{
    static void Main(string[] args)
    {
        string[] weathers = { "Sunny", "Cloudy", "Rainy", "Snow" };

        BWEvent bwe = new BWEvent();
        bwe.BadWeatherEvent += new OnBadWeatherHandler(Callback);

        Random random = new Random();

        Console.WriteLine("Weather forecast this week");

        for (int i = 1; i <= 7; i++)
        {
            int rd = random.Next(weathers.Length);

            Console.WriteLine("Day " + i);

            if (weathers[rd] == "Rainy" || weathers[rd] == "Snow")
            {
                bwe.OnBadWeatherEvent();
            }
        }
        Console.ReadLine();
    }

    public static void Callback(object sender, EventArgs e)
    {
        Console.WriteLine("Bad weather Event occured");
    }
}

class BWEvent
{
    public event OnBadWeatherHandler BadWeatherEvent;

    public void OnBadWeatherEvent()
    {
        if (BadWeatherEvent != null)
            BadWeatherEvent(this, EventArgs.Empty);
    }
}