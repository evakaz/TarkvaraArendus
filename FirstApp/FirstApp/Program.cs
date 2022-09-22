using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Tere";
            bool yes = true;
            //Console.WriteLine(word);
            string myInpute = Console.ReadLine();
            //Console.WriteLine("Konsooli kirjutati: " + myInpute);
            if (word == "Tere")
            {
                Console.WriteLine("eskere");
            }
            if(yes == true)
            {
                Console.WriteLine("yeees");
            }
            if (myInpute != String.Empty)
            {
                Console.WriteLine("Huuraaa");
            }
            else 
            {
                Console.WriteLine("Gucci Gang");
            }
            Console.ReadKey();
        }
    }
}