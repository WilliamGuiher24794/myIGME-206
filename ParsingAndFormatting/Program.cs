using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParsingAndFormatting
{
    /*
     * Class: program
     * Author: William Guiher
     * Purpose: using random numbers and comparing numbers
     */
    class Program
    {
        /*
         * Method: Main
         * Perpose: Make a random number from 0 - 100 and ask the user for a number
         *          and check that number with the randomly generated number
         */
        static void Main(string[] args)
        {

            Random rand = new Random();
            int numGuess=0;
            string input;
            int counter;
            bool valid;

            //a label in case you wanted to play the game again
        Start:           
            //Make a random number between 0 - 100 (inclusive)
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber);
            
            for (counter = 0; counter < 8; counter++)
            {
                valid = false;
                Console.WriteLine("Guess the hidden number");
                //make sure they make a valid guess and not incrementing the counter until the user makes one
                do
                {
                //a lable to jump to the start of the loop
                loop1:
                    input = Console.ReadLine();
                    //test to make sure the input is a number
                    try
                    {
                        numGuess = int.Parse(input);
                    }
                    catch
                    {
                        Console.WriteLine("Enter a number");
                        goto loop1;
                    }
                    //test if the number is in the valid range of 0 - 100
                    if (numGuess < 0 || numGuess > 100)
                    {
                        Console.WriteLine("Enter a number from 0 to 100");
                    }
                    else
                    {
                        valid = true;
                    }
                } while (!valid);
                
                //compare the guessed value the at hiddenvalue
                if(numGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }else if (numGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else
                {
                    Console.WriteLine("Your guess was correct");
                    counter++;
                    break;
                }
                counter++;
            }

            //tell the user how fast they beat the game or what the number is if they didnt
            if(numGuess == randomNumber)
            {
                Console.WriteLine("You beat the game in " + counter + " rounds");
            }
            else
            {
                Console.WriteLine("The correct number was " + randomNumber);
            }

            //
            Console.WriteLine("Do you wanna play the game again");

            string replay;
            replay = Console.ReadLine();
            replay = replay.ToLower();
            if (replay == "yes" || replay == "y")
            {
                goto Start;
            }

        }
    }
}
