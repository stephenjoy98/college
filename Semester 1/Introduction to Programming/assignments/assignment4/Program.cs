/*
 * Programmer: Stephen Joy
 * Date: Winter 2021
 * Purpose: This program makes use of conditional if-else statements with boolean operators to nake a decision.
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;

            Title = "CSIS1175 - Assignment 4 - By Stephen Joy";

            DisplayBanner("Total Weighted Average Calculator");

            Write("\n");

            if (GetUserInput("Assignments", 0, 100, out assignments) && GetUserInput("Midterm Exam", 0, 100, out midtermExam) && GetUserInput("Quiz1", 0, 100, out quiz1) && GetUserInput("Quiz2", 0, 100, out quiz2) && GetUserInput("Final Exam", 0, 100, out finalExam))
            {
                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                WriteLine("\n");


                DisplayTableRow("Assessment", "Percentage", "Your Grade");
                DisplayTableRow("--------------", " -----------", "----------");
                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));

                WriteLine("----------------------------------------");

                DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage), LetterGrade(totalWeightedAverage));

                WriteLine("\n");

                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                weightedExams /= 0.8f;

                WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2} ({1})", Math.Ceiling(weightedExams), LetterGrade(weightedExams));

                if (weightedExams >= 50)
                {
                    WriteLine("The student PASSES the course.");
                }
                else
                {
                    WriteLine("The student FAILS the course.");
                }

            }

            Write("\nPress a key to quit...");

            ReadKey();
        }

        static void DisplayBanner(string banner)
        {
            Write("\\***************************************\\\n");
            Write("\\ \t\t\t\t\t\\\n");
            Write("\\  \"" + banner + "\"  \\\n");
            Write("\\ \t\t\t\t\t\\\n");
            Write("\\***************************************\\\n");
        }

        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            string userValue;
            float inputValue;
            bool isValid;

            Write("Enter a value for {0}: ", textMessage);
            userValue = ReadLine();
            isValid = float.TryParse(userValue, out inputValue);

            if (!isValid)
            {
                WriteLine($"\n!!!!!\nThe value for the {textMessage} must be a number!\n!!!!!");
                userInputValue = 0f;
                return false;
            }
            else
            {
                if ((inputValue < min) || (inputValue > max))
                {
                    WriteLine($"\n!!!!!\nThe value for the {textMessage} must be a number between {min} and {max} inclusive!\n!!!!!");
                    userInputValue = 0f;
                    return false;
                }
                else
                {
                    userInputValue = inputValue;
                    return true;
                }
            }

        }

        static float WeightedGrade(float value1, float value2)
        {

            return value1 * value2;
        }

        static void DisplayTableRow(string text1, string text2, string text3)
        {
            WriteLine("{0,14}{1,13}   {2,-1}", text1, text2, text3);
        }

        static void DisplayTableRow(string text, double value1, float value2, string grade)
        {
            WriteLine("{0,14}{1,13:p0}   {2,-7:F2}{3,-4}", text, value1, value2, grade);
        }
        
        static string LetterGrade(float score)
        {
            if (score >= 95)
            {
                return "A+";
            }
            else if (score < 95 && score >= 90)
            {
                return "A";
            }
            else if (score < 90 && score >= 85)
            {
                return "A-";
            }
            else if (score < 85 && score >= 80)
            {
                return "B+";
            }
            else if (score < 80 && score >= 75)
            {
                return "B";
            }
            else if (score < 75 && score >= 70)
            {
                return "B-";
            }
            else if (score < 70 && score >= 65)
            {
                return "C+";
            }
            else if (score < 65 && score >= 60)
            {
                return "C";
            }
            else if (score < 60 && score >= 55)
            {
                return "C-";
            }
            else if (score < 55 && score >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
