using System;

namespace Durrrdle2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Durrrdle! You will be guessing the three letter Durrrdle. Please enter three letters and then press Enter.");
            Console.WriteLine("_ _ _");
            Console.WriteLine("");

            //make new instance of class Durrrdle aka make new object of type Durrrdle
            Durrrdle durrrdleWord = new Durrrdle();

            //call method(s) of object durrrdle
            durrrdleWord.GenerateDurrrdle();
        }
    }
}
