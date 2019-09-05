using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryAttempts = 0;
            Random rand = new Random();
            int numToGuess; 

            while(tryAttempts < 3)
            {
                numToGuess = rand.Next(10);
                int guessAttempts = 0;
                while (guessAttempts < 2)
                {
                    Console.WriteLine("Enter a number 1-10");
                    Console.WriteLine("After 2 attempts the number will change");

                    string userGuess = Console.ReadLine();

                    if(Convert.ToInt32(userGuess) == numToGuess)
                    {
                        Console.WriteLine("YOU HAVE WON, 1 BILLION fake monies!");
                    }

                    switch (Convert.ToInt32(userGuess))
                    {
                        case 0:
                            Console.WriteLine("Please enter a number from 1-10, idiot.");
                            guessAttempts++;
                            break;
                        case -1:
                            Environment.Exit(1);
                            guessAttempts++;
                            break;
                        default:
                            Console.WriteLine("Guess again, suckaaaaaaa!");
                            if (Convert.ToInt32(userGuess) > numToGuess) Console.WriteLine("The number is less than your number");
                            if (Convert.ToInt32(userGuess) < numToGuess) Console.WriteLine("The number is greater than your number");
                            guessAttempts++;
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                tryAttempts++;
            }
            Console.WriteLine("You Lost");
            Console.ReadLine();
        }
    }
}
