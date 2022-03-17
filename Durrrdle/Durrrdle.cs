using System;
using System.Collections;

namespace Durrrdle
{
    class Durrrdle
    {
        public static bool GuessAgainOrNo(string response)
        {
            //create durrrdle to guess

            //ArrayList generateDurrrdle;
            //generateDurrrdle = new ArrayList();
            //for (int i = 0; i < 3; i++)
            //{
            //    Random rand = new Random();
            //    char randomChar = (char)rand.Next('a', 'z');
            //    generateDurrrdle.Add(randomChar);
            //}
            //var durrrdleWord = generateDurrrdle;

            var durrrdleWord = "lol";

            //character index
            var durrrdleWordCharOne = durrrdleWord.ToCharArray()[0];
            var durrrdleWordCharTwo = durrrdleWord.ToCharArray()[1];
            var durrrdleWordCharThree = durrrdleWord.ToCharArray()[2];

            //create loop to guess again
            //display char if correct char in correct index
            //if statements for char check
            //validate input
            //display letter bank
            //generate random 3 letters to guess

            string userGuess;
            while (true)
            {
                userGuess = Console.ReadLine();

                int userGuessLength = userGuess.Length;

                ArrayList outputDisplay;
                outputDisplay = new ArrayList();

                if (userGuessLength != 3)
                {
                    Console.WriteLine("That is not a valid guess. Please enter the three letters and then press Enter.");
                    return true;
                }
                if (userGuess == durrrdleWord)
                {
                    return false;
                }
                if (userGuess != durrrdleWord)
                {
                    var userGuessCharOne = userGuess.ToCharArray()[0];
                    var userGuessCharTwo = userGuess.ToCharArray()[1];
                    var userGuessCharThree = userGuess.ToCharArray()[2];
                    for (int i = 0; i < 1; i++)
                    {
                        if (durrrdleWordCharOne == userGuessCharOne)
                        {
                            outputDisplay.Add(durrrdleWordCharOne);
                        }
                        if (durrrdleWordCharOne != userGuessCharOne)
                        {
                            outputDisplay.Add("_");
                        }
                        if (durrrdleWordCharTwo == userGuessCharTwo)
                        {
                            outputDisplay.Add(durrrdleWordCharTwo);
                        }
                        if (durrrdleWordCharTwo != userGuessCharTwo)
                        {
                            outputDisplay.Add("_");
                        }
                        if (durrrdleWordCharThree == userGuessCharThree)
                        {
                            outputDisplay.Add(durrrdleWordCharThree);
                        }
                        if (durrrdleWordCharThree != userGuessCharThree)
                        {
                            outputDisplay.Add("_");
                        }
                    }
                    foreach (var item in outputDisplay)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine("");
                    return true;
                }
            }
        }
    }
}