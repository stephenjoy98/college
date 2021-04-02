/*
 * Programmer: Saeed Mirjalili
 * Date: Spring 2019
 * Purpose: This program uses if-else statemnts for user input validation
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WACValidation
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


            Title = "CSIS1175 - Assignment 4 - By Saeed Mirjalili";

            DisplayBanner("Total Weighted Average Calculator");


            // The user enters the grades, the program gets them and stores them in the corresponding variable
            // solution 1: note that here a short-circuit evaluation happens. If the first GetUserInput method returns false, the rest of methods are not executed
            // because if several conditions are combined by && and one of them is false, the entire condition is false and no need to continue evalauting next methods
            // read more here: https://www.c-sharpcorner.com/article/short-circuit-evaluation-in-c-sharp/

            if (GetUserInput("Assignments", 0, 100, out assignments) &&
                GetUserInput("Midterm Exam", 0, 100, out midtermExam) &&
                GetUserInput("Quiz1", 0, 100, out quiz1) &&
                GetUserInput("Quiz2", 0, 100, out quiz2) &&
                GetUserInput("Final Exam", 0, 100, out finalExam))
            {
                // solution2: another solution is nested ifs as follows:

                //if (GetUserInput("Midterm Exam", 0, 100, out midtermExam)) // you can write if-stataments in two lines instead of 1 line as follows
                //{                                                          // bool isInputValid = GetUserInput("Midterm Exam", 0, 100, out midtermExam)
                //    if (GetUserInput("Quiz1", 0, 100, out quiz1))          // if (isInputValid) {
                //    {                                                      //     isInputValid = GetUserInput("Quiz1", 0, 100, out quiz1);
                //        if (GetUserInput("Quiz2", 0, 100, out quiz2))      //     if (isInputValid) {
                //        {                                                  //           isInputValid = GetUserInput("Quiz2", 0, 100, out quiz2);
                //            if (GetUserInput("Final Exam", 0, 100, out finalExam))      if (isInputValid) {
                //            {                                              //                 isInputValid = GetUserInput("Final Exam", 0, 100, out finalExam);
                //                 if (isInputValid) { 
                WriteLine("\n");
                // Total Weighted Average is sum of products of grades and their weight
                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                DisplayTableRow("Assessment", "Percentage", "Your Grade");
                DisplayTableRow("--------------", " -----------", "----------");

                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));

                WriteLine("----------------------------------------");

                // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
                totalWeightedAverage = (float)Math.Floor(totalWeightedAverage);
                DisplayTableRow("Weighted Total", 1, totalWeightedAverage, LetterGrade(totalWeightedAverage));

                WriteLine("\n");

                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                weightedExams /= 0.8f;

                // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
                weightedExams = (float)Math.Ceiling(weightedExams);
                WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2} ({1})", weightedExams, LetterGrade(weightedExams));
                if (weightedExams >= 50)
                {
                    WriteLine("The student PASSES the course.");
                }
                else
                {
                    WriteLine("The student FAILS the course.");
                }
                //}     // these braces are needed if nested-ifs solution (solution 2) was selected.
                // }
                //  }
                //  }

            }
            Write("\nPress a key to quit...");
            ReadKey();
        }

        private static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            float userValue;
            bool isValidInput;

            Write("Enter a value for {0}: ", textMessage);
            isValidInput = float.TryParse(ReadLine(), out userValue);
            if (!isValidInput)
            {
                WriteLine("\n!!!!!\nThe value for {0} must be a number!\n!!!!!\n", textMessage);
                userInputValue = 0;
                return false;
            }
            else
            {
                if (userValue < min || userValue > max)
                {
                    WriteLine("\n!!!!!\nThe value for {0} must be a number between {1} and {2} inclusive!\n!!!!!\n", textMessage, min, max);
                    userInputValue = 0;
                    return false;
                }
                else
                {
                    userInputValue = userValue;
                    return true;
                }
            }
        }

        // This method displays a banner on top of the screen
        static void DisplayBanner(string textMessage)
        {
            Write("\\***************************************\\\n");
            Write("\\\t\t\t\t\t\\\n");
            Write("\\  \"{0}\"  \\\n", textMessage);
            Write("\\\t\t\t\t\t\\\n");
            Write("\\***************************************\\\n");
            WriteLine();
        }
        // this method displays a header row in a table with 3 columns
        static void DisplayTableRow(string column1, string column2, string column3)
        {
            WriteLine("{0,14}{1,13}   {2,-7}", column1, column2, column3);
        }

        // this method display a row in a table with 3 columns
        static void DisplayTableRow(string column1, float column2, float column3, string column4)
        {
            WriteLine("{0,14}{1,13:P0}   {2,-7:F2}{3,-5}", column1, column2, column3, column4);
        }

        // this method received grade and weight and returns product of these two parameters as weightedGrade 
        static float WeightedGrade(float grade, float weight)
        {
            return grade * weight;
        }
        //this method gets a grade number value and returns a grade letter value
        /* static string LetterGrade(float numberGrade)
         {
             if (0 <= numberGrade && numberGrade < 50)
             {
                 return "F";
             }
             else if (50 <= numberGrade && numberGrade < 55)
             {
                 return "D";
             }
             else if (55 <= numberGrade && numberGrade < 60)
             {
                 return "C-";
             }
             else if (60 <= numberGrade && numberGrade < 65)
             {
                 return "C";
             }
             else if (65 <= numberGrade && numberGrade < 70)
             {
                 return "C+";
             }
             else if (70 <= numberGrade && numberGrade < 75)
             {
                 return "B-";
             }
             else if (75 <= numberGrade && numberGrade < 80)
             {
                 return "B";
             }
             else if (80 <= numberGrade && numberGrade < 85)
             {
                 return "B+";
             }
             else if (85 <= numberGrade && numberGrade < 90)
             {
                 return "A-";
             }
             else if (90 <= numberGrade && numberGrade < 95)
             {
                 return "A";
             }
             else
             {
                 return "A+";
             }
         }
         */

        
        //another solution for LetterGrade method
        static string LetterGrade(float numberGrade)
        {
            if (numberGrade >= 95)
            {
                return "A+";
            }
            else if (numberGrade >= 90)
            {
                return "A";
            }
            else if (numberGrade >= 85)
            {
                return "A-";
            }
            else if (numberGrade >= 80)
            {
                return "B+";
            }
            else if (numberGrade >= 75)
            {
                return "B";
            }
            else if (numberGrade >= 70)
            {
                return "B-";
            }
            else if (numberGrade >= 65)
            {
                return "C+";
            }
            else if (numberGrade >= 60)
            {
                return "C";
            }
            else if (numberGrade >= 55)
            {
                return "C-";
            }
            else if (numberGrade >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        

        /*
        //another solution for LetterGrade method
        static string LetterGrade(float numberGrade)
        {
            switch ((int)numberGrade / 5)
            {
                case 20:
                case 19:
                    return "A+";
                case 18:
                    return "A";
                case 17:
                    return "A-";
                case 16:
                    return "B+";
                case 15:
                    return "B";
                case 14:
                    return "B-";
                case 13:
                    return "C+";
                case 12:
                    return "C";
                case 11:
                    return "C-";
                case 10:
                    return "D";
                default:
                    return "F";
            }
        }
        */
    }
}

