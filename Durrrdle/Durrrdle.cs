using System;
using System.Collections;

namespace Durrrdle
{
    class Durrrdle
    {
        public static bool GuessAgainOrNo(string response)
        {
            //create var to guess
            var durrrdleWord = "lol";

            //character index
            var durrrdleWordCharOne = durrrdleWord.ToCharArray()[0];
            var durrrdleWordCharTwo = durrrdleWord.ToCharArray()[1];
            var durrrdleWordCharThree = durrrdleWord.ToCharArray()[2];

            //create loop to guess again
            //display char if correct char in correct index
            //if statements for char check

            string userGuess;
            while (true)
            {
                userGuess = Console.ReadLine();
                var userGuessCharOne = userGuess.ToCharArray()[0];
                var userGuessCharTwo = userGuess.ToCharArray()[1];
                var userGuessCharThree = userGuess.ToCharArray()[2];

                ArrayList outputDisplay;
                outputDisplay = new ArrayList();

                if (userGuess == durrrdleWord)
                    return false;
                if (userGuess != durrrdleWord)
                    for (int i = 0; i < 2; i++)
                    {
                        if (durrrdleWordCharOne == userGuessCharOne)
                            outputDisplay.Add(durrrdleWordCharOne);
                        if (durrrdleWordCharOne != userGuessCharOne)
                            outputDisplay.Add("_");
                        if (durrrdleWordCharTwo == userGuessCharTwo)
                            outputDisplay.Add(durrrdleWordCharTwo);
                        if (durrrdleWordCharTwo != userGuessCharTwo)
                            outputDisplay.Add("_");
                    }
                    foreach (var item in outputDisplay) 
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" " + item);
                    }
                    return true;
            }
        }
    }
}