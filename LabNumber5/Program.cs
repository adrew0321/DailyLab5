using System;

namespace LabNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Calculate the factorial of a number
            Console.WriteLine($"Welcome to the Factorial Calculator!");
            Console.ReadLine();

            long userNumber = 0;

            bool repeat1 = true;
            while (repeat1)
            {

                bool repeat2 = true;
                while (repeat2)
                {
                    //**INPUT***
                    Console.Write($"Enter an integar that's greater than 0 but less than 20: ");

                    //***PROCESSSING***
                    try
                    {
                        userNumber = long.Parse(Console.ReadLine());

                        //Checks if input is less than 0 or more than 20
                        if (userNumber < 0)
                        {
                            Console.WriteLine($"Invalid Input: {userNumber} is less than 0. Please try again...\n");
                        }
                        else if (userNumber > 20)
                        {
                            Console.WriteLine($"Invalid Input: {userNumber} is greater than 20. Please try again...\n");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Your input is not a numerical number. Please try again...\n");
                        repeat2 = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"The number you inserted is too large. Please try again...\n");
                        repeat2 = true;
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine($"Invalid Input: Input cannot be void. Please try again...\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Critical Error: {e.Message}");
                        repeat1 = false;
                        repeat2 = true;
                    }

                }

                //***OUTPUT***
                Console.WriteLine($"The factorial of {userNumber} is {Factorial(userNumber)}\n");

                bool continueResponse = true;
                while (continueResponse)
                {
                    Console.Write($"Would you like to continue? ");
                    string userResponse = Console.ReadLine();

                    //Checks UserResponse 
                    if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                    {
                        repeat1 = true;
                        continueResponse = false;
                    }
                    else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                    {
                        Console.WriteLine($"It's been a pleasure working with you. Until next time...Goodbye!\n");
                        repeat1 = false;
                        continueResponse = false;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Response: Please try again...\n");
                        repeat1 = false;
                        continueResponse = true;
                    }

                }

            }
        }

        public static long Factorial(long userNumber)
        {
            long answer = 1;
            for (int i = 1; i <= userNumber; i++)
            {
                answer = i * answer;
            }
            return answer;

        }

    }

}

