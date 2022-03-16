using System;

namespace Durrrdle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Durrrdle! You will be guessing the three letter word. Please enter the three letters and then press Enter.");
            Console.WriteLine("_ _ _");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //proc loop
            bool guessAgain = true;
            while (guessAgain)
            {
                guessAgain = Durrrdle.GuessAgainOrNo("");
            }
            Console.WriteLine("You guessed the Durrrdle. Thank you for playing!");
        }
    }
}