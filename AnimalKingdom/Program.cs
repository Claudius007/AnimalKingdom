using System;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deer deer = new Deer(2,5,true);

            deer.what_to_do();

            Mountain_Lion.what_to_do();

        }
    }
}
