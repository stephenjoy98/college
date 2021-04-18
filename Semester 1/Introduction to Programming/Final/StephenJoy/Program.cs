/* Name = Stephen Joy
 * ID = 300329148
 */

using System;
using static System.Console;

namespace StephenJoy
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalString;
            finalString = GetUserString("Enter the First string: ");

            if (finalString != null)
            {
                WriteLine($"The result is \"{finalString}\"");
            }

            ReadKey();
        }

        public static string GetUserString(string textMessage)
        {
            string userString;
            string error = null;
            string finalString = "";
            int temp1, temp2 = 0;

            Write(textMessage);
            userString = ReadLine();

            if (userString.Length % 2 != 0)
            {
                WriteLine("The length of string must be even.");
                return error;
            }

            for (int i = 0; i < userString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (!int.TryParse(userString[i].ToString(), out temp1))
                    {
                        WriteLine($"A number is expected at position {i + 1}!");
                        return error;
                    }
                }
            }

            for (int i = 0; i < userString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int.TryParse(userString[i].ToString(), out temp2);
                }
                else
                {
                    for (int j = 0; j < temp2; j++)
                    {
                        finalString += userString[i];
                    }
                }
            }

            return finalString;
        }
    }
}