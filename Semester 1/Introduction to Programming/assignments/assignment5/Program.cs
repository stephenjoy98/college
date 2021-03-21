/*
 * Name : Stephen Joy
 * ID   : 300329148
 */

using System;
using static System.Console;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ACCEPTED_LETTERS = "EHLNTXZ";
            string userString = GetUserString(ACCEPTED_LETTERS);
            int dimension = GetUserInput("an odd integer number greater than 2 for the dimension of the shape:");

            Title = "CSIS1175 - Assignment 5 - By Stephen Joy";

            for (int i = 0; i < userString.Length; i++)
            {
                switch (char.ToUpper(userString[i]))
                {
                    case 'E':
                        DrawE(dimension);
                        break;
                    case 'H':
                        DrawH(dimension);
                        break;
                    case 'L':
                        DrawL(dimension);
                        break;
                    case 'N':
                        DrawN(dimension);
                        break;
                    case 'T':
                        DrawT(dimension);
                        break;
                    case 'X':
                        DrawX(dimension);
                        break;
                    case 'Z':
                        DrawZ(dimension);
                        break;
                    default: break;
                }
            }
            Write("Press a key to quit...");
            ReadKey();
        }

        static string GetUserString(string acceptedLetters)
        {
            string userString, invalidCharacters;

            do
            {
                bool flag = false;
                invalidCharacters = "";

                Write($"Enter a string, including only the following characters ( {acceptedLetters} ) : ");
                userString = ReadLine();

                for (int i = 0; i < userString.Length; i++)
                {
                    if (acceptedLetters.IndexOf(char.ToUpper(userString[i])) == -1)
                    {
                        invalidCharacters += userString[i];
                        flag = true;
                    }
                }

                if (flag)
                {
                    WriteLine($"{invalidCharacters} is not accepted, only {acceptedLetters} characters are accepted! Re-enter your characters.\n");
                }
            }
            while (invalidCharacters != "");

            return userString;
        }

        static int GetUserInput(string message)
        {
            int dimension;
            string userInput;
            bool flag = false;

            do
            {
                Write($"\nEnter {message} ");
                userInput = ReadLine();

                if (!int.TryParse(userInput, out dimension))
                {
                    WriteLine($"{userInput} is not a number!");
                }
                else if (dimension < 3)
                {
                    WriteLine("Must be greater than 3!");
                }
                else if (dimension % 2 == 0)
                {
                    WriteLine("Must be an odd number!");
                }
                else
                {
                    flag = true;
                }

            } while (!flag);

            return dimension;
        }

        static void DrawE(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || row == (dimension + 1) / 2 || row == dimension || col == 1)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawH(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == (dimension + 1) / 2 || col == 1 || col == dimension)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawL(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == dimension || col == 1)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawN(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == col || col == 1 || col == dimension)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawT(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || col == (dimension + 1) / 2)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawX(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == col || row + col - 1 == dimension)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        static void DrawZ(int dimension)
        {
            WriteLine();

            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || row == dimension || row + col - 1 == dimension)
                    {
                        Write(" *");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

    }
}