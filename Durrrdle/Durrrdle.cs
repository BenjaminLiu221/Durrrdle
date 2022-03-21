using System;
using System.Collections;
using System.Text.RegularExpressions;

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
            //update word bank to utilize recursive logic
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

            //proc loop to guess again

            //store outputdisplay
            string testOutputCharOneDisplay = "_";
            string testOutputCharTwoDisplay = "_";
            string testOutputCharThreeDisplay = "_";

            while (true)
            {
                string userGuess;
                userGuess = Console.ReadLine();
                int userGuessLength = userGuess.Length;

                string outputDisplay = "";

                int containNumberCount = 0;

                int correctCharCount = 0;

                //Console.WriteLine(durrrdleWord);
                //implement try catch exception for cleaner error handling
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
                    bool containSpecialCharacter;
                    //initialize new object of type Regex
                    Regex RgxUrl = new Regex("[^a-z0-9]");
                    containSpecialCharacter = RgxUrl.IsMatch(userGuess);
                    if (containSpecialCharacter = true)
                    {
                        Console.WriteLine("That is not a valid guess. Your input contains a special character. Please enter three letters and then press Enter.");
                    }
                }
                //userinput length validation. do not print output display if validation failed
                //implement try catch exception for cleaner error handling
                if (userGuessLength != 3)
                {
                    Console.WriteLine("That is not a valid guess. Please enter only three letters and then press Enter.");
                }
                //index userinput
                //retain character if it matches to a character of that index and display forever
                if (userGuessLength == 3)
                {
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
                                        outputDisplayCharOneToString = userGuessCharOne.ToString();
                                        outputDisplay = String.Concat(outputDisplay, outputDisplayCharOneToString);
                                        correctCharCount++;
                                    }
                                    if (durrrdleWordCharOne != userGuessCharOne)
                                    {
                                        outputDisplayCharOneToString = "_";
                                        outputDisplay = String.Concat(outputDisplay, outputDisplayCharOneToString);
                                    }
                                    if (durrrdleWordCharTwo == userGuessCharTwo)
                                    {
                                        outputDisplayCharTwoToString = userGuessCharTwo.ToString();
                                        outputDisplay = String.Concat(outputDisplay, " ", outputDisplayCharTwoToString);
                                        correctCharCount++;
                                    }
                                    if (durrrdleWordCharTwo != userGuessCharTwo)
                                    {
                                        outputDisplayCharTwoToString = "_";
                                        outputDisplay = String.Concat(outputDisplay, " ", outputDisplayCharTwoToString);
                                    }
                                    if (durrrdleWordCharThree == userGuessCharThree)
                                    {
                                        outputDisplayCharThreeToString = userGuessCharThree.ToString();
                                        outputDisplay = String.Concat(outputDisplay, outputDisplayCharThreeToString);
                                        correctCharCount++;
                                    }
                                    if (durrrdleWordCharThree != userGuessCharThree)
                                    {
                                        outputDisplayCharThreeToString = "_";
                                        outputDisplay = String.Concat(outputDisplay, " ", outputDisplayCharThreeToString);
                                    }
                                }
                                //logic to store correct character of durrrdleWord
                                if (testOutputCharOneDisplay == "_")
                                {
                                    if (outputDisplayCharOneToString != "_")
                                    {
                                        testOutputCharOneDisplay = outputDisplayCharOneToString;
                                    }
                                }
                                if (testOutputCharTwoDisplay == "_")
                                {
                                    if (outputDisplayCharTwoToString != "_")
                                    {
                                        testOutputCharTwoDisplay = outputDisplayCharTwoToString;
                                    }
                                }
                                if (testOutputCharThreeDisplay == "_")
                                {
                                    if (outputDisplayCharThreeToString != "_")
                                    {
                                        testOutputCharThreeDisplay = outputDisplayCharThreeToString;
                                    }
                                }
                            }

                            Console.WriteLine("");
                            //display character count for troubleshooting
                            Console.WriteLine("Correct Character Count: " + correctCharCount);
                            //display userinput
                            Console.WriteLine($"userInputDisplay: { outputDisplay}");
                            //display output
                            Console.WriteLine($"testOutputDisplay: {testOutputCharOneDisplay} {testOutputCharTwoDisplay} {testOutputCharThreeDisplay}");

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
}
