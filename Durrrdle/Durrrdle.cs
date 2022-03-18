﻿using System;
using System.Collections;

namespace Durrrdle2._0
{
    class Durrrdle
    {
        public void GenerateDurrrdle()
        {
            //generate random durrrdle to guess
            var durrrdleWord = "";
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                char randomChar = (char)rand.Next('a', 'c');
                durrrdleWord = $"{durrrdleWord}{randomChar}";
            }

            //print durrrdleWord as a sanity check
            Console.WriteLine(durrrdleWord);
            Console.WriteLine("");

            var durrrdleWordCharOne = durrrdleWord.ToCharArray()[0];
            var durrrdleWordCharTwo = durrrdleWord.ToCharArray()[1];
            var durrrdleWordCharThree = durrrdleWord.ToCharArray()[2];

            //display letter bank
            var letterBankValueOne = "a";
            var letterBankValueTwo = "b";
            var letterBankValueThree = "c";

            Console.WriteLine("Letter Bank: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{letterBankValueOne} ");
            Console.Write($"{letterBankValueTwo} ");
            Console.Write($"{letterBankValueThree}");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");

            //create logic to turn color of letter from letter bank if not correct

            //proc loop to guess again
            //validate input and provide response
            string userGuess;
            while (true)
            {
                userGuess = Console.ReadLine();
                int userGuessLength = userGuess.Length;

                var userGuessCharOne = userGuess.ToCharArray()[0];
                var userGuessCharTwo = userGuess.ToCharArray()[1];
                var userGuessCharThree = userGuess.ToCharArray()[2];

                ArrayList outputDisplay;
                outputDisplay = new ArrayList();

                if (userGuessLength != 3)
                {
                    Console.WriteLine("That is not a valid guess. Please enter the three letters and then press Enter.");
                }
                //Console.WriteLine(durrrdleWord);
                if (userGuess == durrrdleWord)
                {
                    Console.WriteLine("You have guessed the Durrrdle. Thank you for playing!");
                    return;
                }
                if (userGuess != durrrdleWord)
                {
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
                    Console.WriteLine("");
                    foreach (var item in outputDisplay)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Letter Bank: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{letterBankValueOne} ");
                    Console.Write($"{letterBankValueTwo} ");
                    Console.Write($"{letterBankValueThree}");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
    }
}
