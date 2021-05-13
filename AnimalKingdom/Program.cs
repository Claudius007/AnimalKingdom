using System;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deer deer = new Deer(7,5,true);

            //deer.what_to_do();

            Mountain_Lion lion = new Mountain_Lion(3,5,true);

            lion.what_to_do();

        }
    }
}
