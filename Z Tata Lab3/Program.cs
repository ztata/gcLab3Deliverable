using System;

namespace Z_Tata_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userRepeat = true;
            //prompts user to enter name as well as number.
            //saves both inputs into corresponding type variables
            Console.Write("Hello! Please enter your name: ");
            string userName = Console.ReadLine();

            // do-while loop allows users to repeat the game after entering one number if they choose
            do
            {
                //two nested loops to check if the number is acceptable. 
                //Will continue to ask until they get it right or go to exit
                bool numberIsBad = true;
                string userInput = "";
                int userNumber = 0;
                bool parseSuccess = false;
                do
                {
                    //checks to see if the number is an integer. if not it will loop until it is good.  
                    do
                    {
                        Console.WriteLine($"Hello, {userName}, please enter an integer between 1 and 100 or 'exit' to quit.");
                        userInput = Console.ReadLine();
                        parseSuccess = int.TryParse(userInput, out userNumber);
                        if (parseSuccess == false && userInput.Trim().ToLower() == "exit")
                        {
                            goto Exit;
                        }
                        else if (parseSuccess == false)
                        {
                            Console.WriteLine($"Sorry, {userName}, but the number needs to be an integer. Please try again.");
                        }

                        else
                        {
                            parseSuccess = true;
                        }
                    } while (parseSuccess == false);

                    //checks to see if the number is between 1 and 100
                    numberIsBad = true;
                    if (userNumber > 100 || userNumber < 1)
                    {
                        Console.WriteLine("That number is outside the accepted range, please enter an integer between 1 and 100.");
                        numberIsBad = true;
                    }
                    else
                    {
                        Console.WriteLine($"Thanks, {userName}! See below for output: ");
                        numberIsBad = false;
                    }

                } while (numberIsBad == true);


                //responds with differing messages depending on the characteristics of the number entered 
                if (userNumber % 2 != 0)
                {
                    Console.WriteLine($"{userNumber}, Odd.");
                }

                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }

                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine("Even.");
                }

                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    Console.WriteLine($"{userNumber}, Even.");
                }

                else if (userNumber % 2 != 0 && userNumber > 60)
                {
                    Console.WriteLine($"{userNumber}, Odd.");
                }

                //prompts user if they would like to repeat the game
                Console.Write("Would you like to try again? Type 'Yes' to repeat or anything else to exit.");
                string goAgainAnswer = Console.ReadLine();

                if (goAgainAnswer.Trim().ToLower() == "yes")
                {
                    userRepeat = true;
                }

                else
                {
                    userRepeat = false;
                }


            } while (userRepeat == true);

        Exit:
            Console.WriteLine($"Thank you for playing {userName}. Please press any key to exit");
            Console.ReadKey();

        }
    }
}
