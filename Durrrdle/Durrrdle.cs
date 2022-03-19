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

                //ArrayList outputDisplay;
                //outputDisplay = new ArrayList();

                string outputDisplay = "";

                int containNumberCount = 0;

                //Console.WriteLine(durrrdleWord);
                if (userGuess == durrrdleWord)
                {
                    Console.WriteLine("You have guessed the Durrrdle. Thank you for playing!");
                    return;
                }
                //userinput character validation. do not print output display if validation failed
                if (userGuessLength == 3)
                {
                    bool containNumber = false;
                    for (int i = 0; i < userGuess.Length; i++)
                    {
                        if (char.IsDigit(userGuess[i]))
                        {
                            containNumber = true;
                            if (containNumber)
                            {
                                containNumberCount++;
                            }
                        }
                    }
                    if (containNumberCount > 0)
                    {
                        Console.WriteLine("That is not a valid guess. Your input contains a number. Please enter three letters and then press Enter.");
                    }
                }
                //userinput length validation. do not print output display if validation failed
                if (userGuessLength != 3)
                {
                    Console.WriteLine("That is not a valid guess. Please enter only three letters and then press Enter.");
                }
                //index userinput
                //retain character if it matches to a character of that index and display forever
                if (userGuess != durrrdleWord)
                {
                    if (containNumberCount < 1)
                    {
                        var userGuessCharOne = userGuess.ToCharArray()[0];
                        var userGuessCharTwo = userGuess.ToCharArray()[1];
                        var userGuessCharThree = userGuess.ToCharArray()[2];

                        char outputDisplayCharOne;
                        char outputDisplayCharTwo;
                        char outputDisplayCharThree;

                        var outputDisplayCharOneToString = "";
                        var outputDisplayCharTwoToString = "";
                        var outputDisplayCharThreeToString = "";

                        if (userGuessLength == 3)
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                if (durrrdleWordCharOne == userGuessCharOne)
                                {
                                    outputDisplay = String.Concat(outputDisplay, userGuessCharOne);
                                }
                                if (durrrdleWordCharOne != userGuessCharOne)
                                {
                                    outputDisplay = String.Concat(outputDisplay, "_");
                                }
                                if (durrrdleWordCharTwo == userGuessCharTwo)
                                {
                                    outputDisplay = String.Concat(outputDisplay, " ", userGuessCharTwo);
                                }
                                if (durrrdleWordCharTwo != userGuessCharTwo)
                                {
                                    outputDisplay = String.Concat(outputDisplay, " _");
                                }
                                if (durrrdleWordCharThree == userGuessCharThree)
                                {
                                    outputDisplay = String.Concat(outputDisplay, " ", userGuessCharThree);
                                }
                                if (durrrdleWordCharThree != userGuessCharThree)
                                {
                                    outputDisplay = String.Concat(outputDisplay, " _");
                                }

                                //if (durrrdleWordCharOne == userGuessCharOne)
                                //{
                                //    outputDisplayCharOneToString = userGuessCharOne.ToString();
                                //}
                                //if (durrrdleWordCharOne != userGuessCharOne)
                                //{
                                //    outputDisplayCharOneToString = " _";
                                //}
                                //if (durrrdleWordCharTwo == userGuessCharTwo)
                                //{
                                //    outputDisplayCharTwoToString = userGuessCharTwo.ToString();
                                //}
                                //if (durrrdleWordCharTwo != userGuessCharTwo)
                                //{
                                //    outputDisplayCharTwoToString = " _";
                                //}
                                //if (durrrdleWordCharThree == userGuessCharThree)
                                //{
                                //    outputDisplayCharThreeToString = userGuessCharThree.ToString();
                                //}
                                //if (durrrdleWordCharThree != userGuessCharThree)
                                //{
                                //    outputDisplayCharThreeToString = " _";
                                //}

                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine(outputDisplay);

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
}
