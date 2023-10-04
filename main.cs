using System;

class MathQuiz
{
    static void Main()
    {
        int num1, num2, answer, score = 0;
        string response;

        Console.WriteLine("Welcome to the Math Quiz!");
        Console.WriteLine("You will be given 10 problems.");
        Console.WriteLine("Please enter the correct answer for each problem.");

        // Generate and solve 10 addition problems
        for (int i = 1; i <= 10; i++)
        {
            num1 = new Random().Next(1, 11);
            num2 = new Random().Next(1, 11);

            Console.Write("{0}. What is {1} + {2}? ", i, num1, num2);

            // Try to parse user input as integer
            if (!int.TryParse(Console.ReadLine(), out answer))
            {
                Console.WriteLine("Invalid input, please enter an integer.");
                i--; // Repeat this problem
                continue;
            }

            if (answer == num1 + num2)
            {
                Console.WriteLine("Correct!");
                score++; // Increase score
            }
            else
            {
                Console.WriteLine("Incorrect. The answer was {0}.", num1 + num2);
            }
        }

        // Print final score
        Console.WriteLine("Quiz complete! You scored {0} out of 10.", score);

        // Prompt user to play again
        Console.Write("Do you want to play again? (y/n) ");
        response = Console.ReadLine().ToLower();

        if (response == "y" || response == "yes")
        {
            Main(); // Start over
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
