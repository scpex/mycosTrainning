using System;
using Nook;
using System.Collections.Generic;

namespace Nook
{
    class Program
    {   
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Ianimal> listAnimal = new List<Ianimal>();
            Kangaroo Jojo = new Kangaroo();   
            listAnimal.Add(Jojo);

            // Dog need a name 
            Dog Dang = new Dog("Dang");
            listAnimal.Add(Dang);

            // i don know fox saying ?
            Fox Fox1 = new Fox("RingRingRing");
            listAnimal.Add(Fox1);
            Fox Fox2 = new Fox("PoawPoawPoaw");
            listAnimal.Add(Fox2);

            // say all
            foreach (var animal in listAnimal)
                animal.say();
        }
    }
}
