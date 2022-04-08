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
            Console.WriteLine($"DurrrdleWord is: {durrrdleWord}");

            var durrrdleWordCharOne = durrrdleWord.ToCharArray()[0];
            var durrrdleWordCharTwo = durrrdleWord.ToCharArray()[1];
            var durrrdleWordCharThree = durrrdleWord.ToCharArray()[2];

            //display letter banks
            var letterBankValueOne = "a";
            var letterBankValueTwo = "b";
            var letterBankValueThree = "c";

            Console.WriteLine("Letter Bank: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{letterBankValueOne} {letterBankValueTwo} {letterBankValueThree}");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");

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

                string userGuess = Console.ReadLine().ToLower();

                int userGuessLength = userGuess.Length;

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

                        var outputDisplayCharOneToString = "_";
                        var outputDisplayCharTwoToString = "_";
                        var outputDisplayCharThreeToString = "_";

                        testOutputCharOneDisplay = BuildOutputDisplay(durrrdleWordCharOne, userGuessCharOne, outputDisplayCharOneToString, testOutputCharOneDisplay);
                        testOutputCharTwoDisplay = BuildOutputDisplay(durrrdleWordCharTwo, userGuessCharTwo, outputDisplayCharTwoToString, testOutputCharTwoDisplay);
                        testOutputCharThreeDisplay = BuildOutputDisplay(durrrdleWordCharThree, userGuessCharThree, outputDisplayCharThreeToString, testOutputCharThreeDisplay);
                    }
                }
                //display guessAttemptsRemaining
                Console.WriteLine($"Guess Attempt(s) Remaining: {guessAttemptsRemaining}");

                //display output
                Console.WriteLine($"Progress: {testOutputCharOneDisplay} {testOutputCharTwoDisplay} {testOutputCharThreeDisplay}");

                //display letter bank
                Console.WriteLine("");
                Console.WriteLine("Letter Bank: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{letterBankValueOne} {letterBankValueTwo} {letterBankValueThree}");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        //method to build outputDisplay
        public string BuildOutputDisplay(char durrrdleWordChar, char userGuessChar, string outputDisplayChar, string testOutputDisplayChar)
        {
            if (durrrdleWordChar == userGuessChar)
            {
                outputDisplayChar = userGuessChar.ToString();
            }
            if (outputDisplayChar != "_")
            {
                testOutputDisplayChar = outputDisplayChar;
            }
            return testOutputDisplayChar;
        }
    }
}
