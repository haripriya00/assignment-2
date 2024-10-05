using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eg3
{
    internal class Program
    {
        static void Main(string[] args)
            //Lab 16: Countdown Timer
            //Assignment:
            //Write a C# program to simulate a countdown timer from 10 to 1 using a do-while loop,
            //displaying each second.









        //Lab 15: Sum of Squares
        //Assignment:
        //Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided
        //number using a while loop.

        //{
        //    Console.Write("Enter a positive integer: ");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //int sum = 0; 
        //int i = 1;   
        //while (i <= n)
        //{
        //    sum += i* i; 
        //i++;   
        //}
        //    Console.WriteLine($"The sum of squares from 1 to {n} is: {sum}");









        //Lab 14: Finding the Largest Number
        //Assignment:
        //Write a C# program that accepts 10 numbers from the user and finds the largest number using a
        //for loop.
        //{
        //    int largest = int.MinValue; 
        //    int number;

        //    Console.WriteLine("Enter 10 numbers:");
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write($"Number {i}: ");
        //        number = Convert.ToInt32(Console.ReadLine()); 
        //        if (number > largest)
        //        {
        //            largest = number; 
        //        }
        //    }
        //    Console.WriteLine($"The largest number entered is: {largest}");







        //    Lab 13: Sum of Digits
        //    Assignment:
        //       Write a C# program that accepts a number from the user and calculates the sum of its digits using
        //a do-while loop.
        //{
        //    Console.Write("Enter a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine()); 
        //    int sum = 0; 
        //    int originalNumber = number; 
        //    if (number < 0)
        //    {
        //        number = Math.Abs(number); 
        //    }
        //    do
        //    {
        //        int digit = number % 10; 
        //        sum += digit; 
        //        number /= 10; 
        //    } while (number > 0); 
        //    Console.WriteLine($"The sum of the digits of {originalNumber} is: {sum}");






        //Lab 12: Simple Calculator
        //Assignment:

        //Write a C# program to create a simple calculator using a switch-case statement. The program
        //should handle addition, subtraction, multiplication, and division.

        //{
        //    Console.WriteLine("Simple Calculator");
        //    Console.WriteLine("-----------------");
        //    Console.Write("Enter the first number: ");
        //    double num1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Enter the second number: ");
        //    double num2 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Select an operation: ");
        //    Console.WriteLine("1. Addition (+)");
        //    Console.WriteLine("2. Subtraction (-)");
        //    Console.WriteLine("3. Multiplication (*)");
        //    Console.WriteLine("4. Division (/)");
        //    Console.Write("Enter your choice (1/2/3/4): ");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    double result;
        //    switch (choice)
        //    {
        //        case 1: // Addition
        //            result = num1 + num2;
        //            Console.WriteLine($"Result: {num1} + {num2} = {result}");
        //            break;
        //        case 2: // Subtraction
        //            result = num1 - num2;
        //            Console.WriteLine($"Result: {num1} - {num2} = {result}");
        //            break;
        //        case 3: // Multiplication
        //            result = num1 * num2;
        //            Console.WriteLine($"Result: {num1} * {num2} = {result}");
        //            break;
        //        case 4: // Division
        //                // Check for division by zero
        //            if (num2 != 0)
        //            {
        //                result = num1 / num2;
        //                Console.WriteLine($"Result: {num1} / {num2} = {result}");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Error: Division by zero is not allowed.");
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice! Please select a valid operation.");
        //            break;

        //    }


        //Lab 11: Guess the Number Game
        //Assignment:
        //Write a C# program that generates a random number between 1 and 100. The user has to guess
        //   the number, and the program should give hints("too high" or "too low") until the user guesses
        //    correctly.Use a nested do-while loop to allow the user to play multiple rounds.

        //{
        //    Random random = new Random(); 
        //    char playAgain;

        //    do
        //    {
        //        int randomNumber = random.Next(1, 101);
        //        int guess;
        //        bool isGuessedCorrectly = false; 
        //        Console.WriteLine("I have generated a random number between 1 and 100.");
        //        do
        //        {
        //            Console.Write("Enter your guess: ");
        //            guess = Convert.ToInt32(Console.ReadLine());

        //            if (guess < randomNumber)
        //            {
        //                Console.WriteLine("Too low! Try again.");
        //            }
        //            else if (guess > randomNumber)
        //            {
        //                Console.WriteLine("Too high! Try again.");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Congratulations! You've guessed the number correctly.");
        //                isGuessedCorrectly = true;
        //            }
        //        } while (!isGuessedCorrectly); 
        //        Console.Write("Do you want to play again? (y/n): ");
        //        playAgain = Console.ReadKey().KeyChar;
        //        Console.WriteLine();
        //    } while (playAgain == 'y' || playAgain == 'Y');
        //    Console.WriteLine("Thank you for playing! Goodbye!");






        //    Lab 10: Number Pyramid
        //    Assignment:
        //    Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
        //    1
        //   2 2
        //  3 3 3
        // 4 4 4 4
        //5 5 5 5 5

        //    {
        //       Console.Write("Enter the number of rows for the pyramid: ");
        //    int rows = Convert.ToInt32(Console.ReadLine());
        //    int i = 1; 
        //    while (i <= rows)
        //    {
        //        int j = 1; 
        //        while (j <= i)
        //        {
        //            Console.Write(i + " ");
        //            j++; 
        //        }

        //Console.WriteLine(); 
        //        i++; 
        //    }



        //Lab 9: Factorial Calculation
        //Assignment:
        //Write a C# program to calculate the factorial of a given number using a while loop.

        //{
        //    Console.Write("Enter a number to calculate its factorial: ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int factorial = 1;
        //    int i = number;  
        //    while (i > 0)
        //    {
        //        factorial *= i; 
        //        i--;           
        //    }
        //    Console.WriteLine("The factorial of " + number + " is: " + factorial);

        //}












        //Lab 8: Sum of Odd Numbers
        //Assignment:
        // Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.

        //{
        //    int sum = 0; 
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            sum += i; 
        //        }
        //    }

        //    Console.WriteLine("The sum of all odd numbers between 1 and 100 is: " + sum);

        //}





        //  Lab 7: Print All Numbers From 1 to 100
        //Assignment:
        //Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
        //numbers that are divisible by 3, and use the break statement to stop the loop if the number
        //exceeds 50.

        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            continue;
        //        }
        //        if (i > 50)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(i);
        //    }








        // Lab 6: Create Menu Driven Calculator
        //Assignment:
        //Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
        //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
        //user chooses to exit.
        //{
        //    char choice;

        //    do
        //    {
        //        Console.Write("Enter the first number: ");
        //        double num1 = Convert.ToDouble(Console.ReadLine());
        //        Console.Write("Enter the second number: ");
        //        double num2 = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Choose an operation (+, -, *, /): ");
        //        char operation = Console.ReadKey().KeyChar;
        //        Console.WriteLine();
        //        switch (operation)
        //        {
        //            case '+':
        //                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
        //                break;
        //            case '-':
        //                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
        //                break;
        //            case '*':
        //                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
        //                break;
        //            case '/':
        //                if (num2 != 0)
        //                {
        //                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Error: Division by zero is not allowed.");
        //                }
        //                break;
        //            default:
        //                Console.WriteLine("Invalid operation! Please choose one of +, -, *, or /.");
        //                break;
        //        }
        //        Console.WriteLine("Do you want to perform another calculation? (y/n): ");
        //        choice = Console.ReadKey().KeyChar;
        //        Console.WriteLine();

        //    } while (choice == 'y' || choice == 'Y');

        //    Console.WriteLine("Thank you for using the calculator. Goodbye!");
        //}



        //    //    Lab 5: Print Positive Number
        //    //    Assignment:
        //    //    Write a C# program to keep asking the user to enter a positive number and print it. The program
        //    //    should stop when the user enters a negative number.
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a positive number :");
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        if (number < 0)
        //        {
        //            Console.WriteLine("Negative number entered. Stopping the program.");
        //            break;
        //        }

        //        Console.WriteLine($"You entered: {number}");
        //    }
        //}







        //    //Lab 4: Multiplication table from 1 to 5
        //    //Assignment:
        //    //Write a C# program to print a multiplication table from 1 to 5 using nested while loops.
        //{
        //    int i = 1;
        //    while (i <= 5)
        //    {
        //        int j = 1;
        //        while (j <= 10)
        //        {
        //            Console.Write($"{i} x {j} = {i * j}\n");
        //            j++;
        //        }
        //        Console.WriteLine();
        //        i++;

        //    }
        //}






        //    // Lab 3:
        //    //Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while
        //    //loop.
        //        {
        //            int sum = 0;
        //    int number = 2;
        //            while (number <= 100)
        //            {
        //                sum += number;
        //                number += 2;
        //            }
        //Console.WriteLine("The sum of all even numbers between 1 and 100 is: " + sum);

        //        }






        //Lab: 2 Display a right - angled triangle
        //Assignment:
        //Write a C# program to display a right-angled triangle pattern using nested for loops.
        //{
        //    Console.WriteLine("Enter the number of rows for the triangle:");
        //    int rows = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= rows; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();

        //    }


        //}





        //    //Lab 1: Multiplication table of a given number
        //    //Assignment:
        //    //Write a C# program to print the multiplication table of a given number using the for loop.
        //{
        //    Console.WriteLine("Enter the number for the multiplication table:");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"{number} x {i} = {number * i}");
        //    }

        //}
     }
}
}