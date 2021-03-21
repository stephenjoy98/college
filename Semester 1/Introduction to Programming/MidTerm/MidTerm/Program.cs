/*
 * Name         : Stephen Joy
 * Student ID   : 300329148
 */

using System;
using static System.Console;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            const float OVERTIME_LIMIT = 40f;
            const float TAX_RATE = 0.09f;

            float workHours, hourlyRate;
            double calculatedGrossPayment;

            Title = "CSIS1175 - Mid Term - By Stephen Joy";

            workHours = GetUserInput("number of work hours in this week");

            if (workHours > 0)
            {
                hourlyRate = GetUserInput("hourly rate");

                if (hourlyRate > 0)
                {
                    calculatedGrossPayment = GrossPayment(workHours, hourlyRate, OVERTIME_LIMIT);

                    Write("\n       Employee Pay Slip");
                    Write("\n\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"");

                    Write("\n{0,15} {1,9:F2} hours", "Total Hours", workHours);
                    Write("\n{0,15} {1,9:C}", "Hourly Rate", hourlyRate);

                    if (workHours > 40)
                    {
                        Write("\n{0,15} {1,9} hours", "Overtime Hours", (workHours - OVERTIME_LIMIT));
                    }
                    else
                    {
                        Write("\n{0,15} {1,9} hours", "Overtime Hours", 0f);
                    }

                    Write("\n{0,15} {1,9:C}", "Gross Pay", calculatedGrossPayment);
                    Write("\n{0,15} {1,9:C}", "Tax", (calculatedGrossPayment * TAX_RATE));
                    Write("\n\n{0,15} {1,9:C}\n", "Net Pay", Math.Ceiling(calculatedGrossPayment * (1 - TAX_RATE)));
                }
            }

            ReadKey();
        }

        static float GetUserInput(string text)
        {
            string userValue;
            float inputValue;
            bool isValid;

            Write($"Enter {text}: ");
            userValue = ReadLine();
            isValid = float.TryParse(userValue, out inputValue);

            if (!isValid)
            {
                Write("Enter a numeric value!");
                inputValue = 0f;
                return inputValue;
            }
            else
            {
                if (inputValue <= 0)
                {
                    Write("Enter a positive numeric value!");
                    inputValue = 0f;
                    return inputValue;
                }
                else
                {
                    return inputValue;
                }
            }
        }

        static double GrossPayment(float workHours, float hourlyRate, float overTimeLimit)
        {
            double grossPay = 0;

            if (workHours <= 40)
            {
                grossPay = workHours * hourlyRate;
                return grossPay;
            }
            else if ((workHours > 40) && (workHours < 50))
            {
                grossPay = ((workHours - overTimeLimit) * hourlyRate * 1.5) + (overTimeLimit * hourlyRate);
                return grossPay;
            }
            else if ((workHours >= 50) && (workHours < 60))
            {
                grossPay = ((workHours - overTimeLimit) * hourlyRate * 2) + (overTimeLimit * hourlyRate);
                return grossPay;
            }
            else
            {
                return 0f;
            }
        }
    }
}
