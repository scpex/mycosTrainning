using System;
// Declare delefate method
public delegate void NookEventHandler();

class Program
{
    static void Cat()
    {
        Console.WriteLine("Cat");
    }

    static void Dog()
    {
        Console.WriteLine("Dog");
    }

    static void Mouse()
    {
        Console.WriteLine("Mouse");
    }
	//declare events
    public static event NookEventHandler _showAnimal;

    static void Main()
    {
        // Add event handlers to Show event.
        _showAnimal += new NookEventHandler(Dog);
        _showAnimal += new NookEventHandler(Cat);
        _showAnimal += new NookEventHandler(Mouse);
        //_showAnimal = new NookEventHandler(Mouse);
	
	
	//Type t = _showAnimal.GetType();
	//Console.WriteLine(t);

        // Invoke the event. Call events
        _showAnimal.Invoke();
    }

   
}