using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web;
using System.Xml;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a northern italian city in lower case.\n");
            //created a secretWord var
            string secretWord = "sanremo";
            // guess is storing what user guessed
            string guess = "";
            // guessCount keeping track how many times the user guessed right 
            int guessCount = 0;
            // guessLimit telling us how many times user can guess b
            int guessLimit = 4;
            // wether or not the user has run out of guesses 
            bool outOfGuesses = false;
            // this variable will store the number of attempts 
            int attempts = guessLimit;
            

            // loop keep going & asking the user to guess the word until
            // 1) the guess is not equal to the secret word 
            // 2) the user not out of guesses 
            // if either of these conditions are false we are going to break out of the loop 
            while (guess != secretWord && !outOfGuesses)
            {
                // if guesscount < guesslimit(havent guessed 4x) promt user for another guess 
                if (guessCount < guessLimit)
                {
                    Console.Write($"Enter guess word ({attempts} attempts left): ");
                    guess = Console.ReadLine();
                    attempts--;
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            // checking if user out of guesses 
            if (outOfGuesses)
            {
                Console.Write("You lose! You had " + attempts + " attempts. The word was " + secretWord + ".");
            }
            else
            {
                Console.Write("You win!");
            }
            Console.ReadLine();
        }
    }
}

