using System;
using System.Timers;

namespace _3QuestionsUT1
{

    class Program
    {
        static bool bTimeOut = false;

        // timeOutTimer Timer
        static Timer timeOutTimer;

        static void Main(string[] args)
        {
        Start:
            int choice = 0;
            string answer;
            string question;
            bool correct = false;
            string playAgain;

            
            bool valid = false;
            do
            {
                Console.Write("Choose your question (1-3): ");
                question = Console.ReadLine();
                try
                {
                    choice = int.Parse(question);

                    if (choice >= 1 && choice <= 3)
                    {
                        valid = true;
                    }
                }
                catch
                {
                    Console.Write("enter a number");
                }


            } while (!valid);


            timeOutTimer = new Timer(3000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
            bTimeOut = false;
            while (!bTimeOut)
            {
                timeOutTimer.Start();
                if (choice == 1)
                {
                    Console.WriteLine("What is your favorite color?");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "black")
                    {
                        correct = true;
                        timeOutTimer.Stop();
                    }
                    else
                    {
                        Console.WriteLine("The answer is: black");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "42")
                    {
                        correct = true;
                        timeOutTimer.Stop();
                    }
                    else
                    {
                        Console.WriteLine("The answer is: 42");
                    }
                }
                else
                {
                    Console.WriteLine("What is the airspeed velocity of an swallow");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "what do you mean? african or european swallow?")
                    {

                        correct = true;
                        timeOutTimer.Stop();
                    }
                    else
                    {
                        Console.WriteLine("The answer is: what do you mean? african or european swallow?");
                    }
                }
            }

            if (correct)
            {
                Console.WriteLine("Well done!");
            }
            Console.WriteLine("Play again?");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
            if(playAgain.StartsWith("y"))
            {
                goto Start;
            }
        }

        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");

            // set the bTimeOut flag to quit the game
            bTimeOut = true;

            // stop the timeOutTimer
            timeOutTimer.Stop();
        }
    }
}

