using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Durrrdle2._0
{
    class Durrrdle
    {
        public void BeginDurrrdle()
        {
            //generate random durrrdle to guess
            var durrrdleWord = "";
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                char randomChar = (char)rand.Next('a', 'c');
                durrrdleWord = $"{durrrdleWord}{randomChar}";
            }

            //Console.WriteLine("");
            Console.WriteLine($"DurrrdleWord is: { durrrdleWord}");

            var durrrdleWordCharOne = durrrdleWord.ToCharArray()[0];
            var durrrdleWordCharTwo = durrrdleWord.ToCharArray()[1];
            var durrrdleWordCharThree = durrrdleWord.ToCharArray()[2];

            //display letter banks
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

            //store outputDisplay
            string testOutputCharOneDisplay = "_";
            string testOutputCharTwoDisplay = "_";
            string testOutputCharThreeDisplay = "_";

            //declare guessAgain
            bool guessAgain = true;

            //quit after attempts remaining reaches 0
            int guessAttemptsRemaining = 3;

            //possibly add class constructor and class fields
            while (guessAgain)
            {
                if (guessAttemptsRemaining == 0)
                {
                    Console.WriteLine("You have 0 guesses remaining. Thank you for playing. Good bye!");
                    return;
                }

                string userGuess = Console.ReadLine();
                int userGuessLength = userGuess.Length;

                string outputDisplay = "";

                int correctCharCount = 0;

                int containInvalidCharCount = 0;

                bool userInputValidationPassed = true;

                if (userInputValidationPassed)
                {
                    //userinput length validation. do not print output display if validation failed
                    if (userGuessLength != 3)
                    {
                        userInputValidationPassed = false;
                        Console.WriteLine("That is not a valid guess. Please enter only three letters and then press Enter.");
                        Console.WriteLine("");
                    }
                    //userinput character validation. do not print output display if validation failed
                    if ((userGuessLength == 3) && (userInputValidationPassed))
                    {
                        //digit validation
                        for (int i = 0; i < userGuess.Length; i++)
                        {
                            if (char.IsDigit(userGuess[i]))
                            {
                                containInvalidCharCount++;
                            }
                        }
                        //initialize new object of type Regex
                        if (containInvalidCharCount == 0)
                        {
                            Regex RgxUrl = new Regex("[^a-z0-9]");
                            if (RgxUrl.IsMatch(userGuess))
                            {
                                containInvalidCharCount++;
                            }
                        }
                        if (containInvalidCharCount > 0)
                        {
                            userInputValidationPassed = false;
                            Console.WriteLine("That is not a valid guess. Your input contains a number(s) or special character(s). Please enter three letters and then press Enter.");
                            Console.WriteLine("");
                        }
                    }

                }
                //index userinput
                //retain character if it matches to a character of that index and display forever
                if (userInputValidationPassed)
                {
                    if (userGuess == durrrdleWord)
                    {
                        Console.WriteLine("You have guessed the Durrrdle. Thank you for playing!");
                        return;
                    }
                    else
                    {
                        guessAttemptsRemaining--;

                        var userGuessCharOne = userGuess.ToCharArray()[0];
                        var userGuessCharTwo = userGuess.ToCharArray()[1];
                        var userGuessCharThree = userGuess.ToCharArray()[2];

                        var outputDisplayCharOneToString = "";
                        var outputDisplayCharTwoToString = "";
                        var outputDisplayCharThreeToString = "";

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
                }
                //display character count for troubleshooting
                //Console.WriteLine("");
                //Console.WriteLine("Correct Character Count: " + correctCharCount);

                //display guessAttemptsRemaining
                Console.WriteLine($"Guess Attempt(s) Remaining: {guessAttemptsRemaining}");

                //display userinput
                //Console.WriteLine($"userInputDisplay: { outputDisplay}");

                //display output
                Console.WriteLine($"Progress: {testOutputCharOneDisplay} {testOutputCharTwoDisplay} {testOutputCharThreeDisplay}");

                //display letter bank
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

        //public string OutputDisplay = { get; private set; } = "";

        //public void BuildOutputDisplay(char durrrdleWordChar, char userGuessChar, string outputDisplayChar)
        //{
        //    if (durrrdleWordChar == userGuessChar)
        //    {
        //        outputDisplayChar = userGuessChar.ToString();
        //        OutputDisplay = String.Concat(OutputDisplay, outputDisplayChar);
        //        correctCharCount++;
        //    }
        //}
    }
}
