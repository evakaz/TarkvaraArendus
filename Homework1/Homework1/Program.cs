using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu nimi?");
            string name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine($"Tere {name}, soovin sulle kõike head.");
            }
            else
            {
                Console.WriteLine("Palun sisesta enda nime");
            }
        }
    }
}
